﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FullAutomationSupportSystem;
using System.IO;

namespace FullAutomationSupportSystem
{
    public partial class TaskForm : Form
    {
        static readonly public string gNamePlease = "新しいタスク";
        private TaskData gTaskData = null;
        public TaskForm(TaskData data, TaskList lists)
        {
            InitializeComponent();
            gTaskData = data;
            foreach(var task in lists)
            {
                LogPathComboBox.Items.Add(task.LogPath);
                ProjectPathComboBox.Items.Add(task.ProjectPath);
            }
            NameTextBox.Text = data.Name;
            LogFolderTextBox.Text = data.ExportPath;
            if (data.LogNumber == -1)
            {
                for (int i = 0; i <= lists.Count; i++)
                {
                    if (lists.Cast<TaskData>().Count(t => t.LogNumber == i) == 0)
                    {
                        LogNumericUpDown.Value = i;
                        break;
                    }
                }
            }
            else
            {
                LogNumericUpDown.Value = data.LogNumber;
            }

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            foreach (var command in gTaskData.CommandDataList)
            {
                AddDataGridView(command);
            }
            NameTextBox.Text = gTaskData.Name;
            LogFolderTextBox.Text = gTaskData.ExportPath;
            ProjectPathComboBox.Text = gTaskData.ProjectPath;
            //ProjectFolderComboBox.Text = gTaskData.ProjectPath[0];
            //foreach (var folder in gTaskData.ProjectPath)
            //{
            //    ProjectFolderComboBox.Items.Add(folder);
            //}
            LogPathComboBox.Text = gTaskData.LogPath;
            //LogNumericUpDown.
            RepositoryTextBox.Text = gTaskData.Repository;
            NameTextBox.Focus();
            foreach (CommandListData commandList in CommandListManager.GetInstance())
            {
                CommandComboBox.Items.Add(commandList.Name);
            }
            CommandComboBox.Text = CommandComboBox.Items[0].ToString();

        }
        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void AddDataGridView(CommandData command)
        {
            int count = commandDataBindingSource.Add(command);
            dataGridView1["run", count].Value = "実行";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ProjectPathComboBox.Text) == false)
            {
                MessageBox.Show("作業フォルダが存在しません");
                return;
            }
            if (Directory.Exists(LogPathComboBox.Text) == false)
            {
                MessageBox.Show("ログフォルダが存在しません");
                return;
            }

            this.DialogResult = DialogResult.OK;

            gTaskData.Name = NameTextBox.Text;
            gTaskData.ExportPath = LogFolderTextBox.Text;
            gTaskData.ProjectPath = ProjectPathComboBox.Text;
            //gTaskData.ProjectPath.Clear();
            //foreach(var item in ProjectFolderComboBox.Items)
            //{
            //    gTaskData.ProjectPath.Add(item.ToString());
            //}
            gTaskData.LogPath = LogPathComboBox.Text;
            gTaskData.Repository = RepositoryTextBox.Text;
            gTaskData.Timer = TimerCheckBox.Checked;
            gTaskData.Span = IntervalCheckBox.Checked;
            gTaskData.LogNumber = (int)LogNumericUpDown.Value;
        }

        private void CommandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var commandListTex = CommandListManager.GetInstance()[CommandComboBox.SelectedIndex].CommandListTxt;
            CommandTextBox.Text = commandListTex;
        }

        private void CommandButton_Click(object sender, EventArgs e)
        {
            var data = new CommandData();
            data.Name = CommandListManager.GetInstance()[CommandComboBox.SelectedIndex].Name;
            data.Type = CommandListManager.GetInstance()[CommandComboBox.SelectedIndex].Type;
            data.Checked = true;
            gTaskData.CommandDataList.Add(data);
            var form = new CommandForm(gTaskData.CommandDataList[gTaskData.CommandDataList.Count - 1]);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                AddDataGridView(data);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //実行を押された
            if(e.ColumnIndex == dataGridView1.Columns["run"].Index)
            {
                var command = gTaskData.CommandDataList[e.RowIndex];
                CommandListManager.GetInstance().Run(command.Type, command.Param1, command.Param2);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var editCommand = (CommandData)commandDataBindingSource[e.RowIndex];
            var form = new CommandForm(editCommand);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                commandDataBindingSource[e.RowIndex] = editCommand;
                gTaskData.CommandDataList[e.RowIndex] = editCommand;
            }
        }
        private void ExportFolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //--------------------------------------------------------------------------
        //ドラッグ&ドロップ
        //--------------------------------------------------------------------------
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dataGridView1.DoDragDrop(dataGridView1.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }
        private int rowIndexFromDragOver;
        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridView1.PointToClient(new Point(e.X, e.Y));
            rowIndexFromDragOver = dataGridView1.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //e.Effect = DragDropEffects.All;
            }

            if (rowIndexFromDragOver != -1)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            //ファイルドロップ
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (Directory.Exists(s[0]) == true)
                {
                }
                else if (File.Exists(s[0]) == true)
                {
                }
            }
            //コントロール内操作
            else
            {
                var command = (CommandData)commandDataBindingSource[rowIndexFromMouseDown];
                commandDataBindingSource.RemoveAt(rowIndexFromMouseDown);
                commandDataBindingSource.Insert(rowIndexFromDragOver, command);
                gTaskData.CommandDataList.RemoveAt(rowIndexFromMouseDown);
                gTaskData.CommandDataList.Insert(rowIndexFromDragOver, command);
                dataGridView1["run", rowIndexFromDragOver].Value = "実行";
            }
        }

        private void LogFolderButton_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(LogPathComboBox.Text))
            {
                folderBrowserDialog1.SelectedPath = LogPathComboBox.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                LogPathComboBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void ProjectFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ProjectPathComboBox.Text))
            {
                folderBrowserDialog1.SelectedPath = ProjectPathComboBox.Text;
            }
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ProjectPathComboBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private string DropFileName = "";
        private void FolderComboBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (Directory.Exists(fileName[0]) == true)
                {
                    DropFileName = fileName[0];
                    e.Effect = DragDropEffects.All;
                }
                else if (Directory.Exists(Path.GetDirectoryName(fileName[0])) == true)
                {
                    DropFileName = Path.GetDirectoryName(fileName[0]);
                    e.Effect = DragDropEffects.All;
                }
            }
        }
        private void LogFolderComboBox_DragDrop(object sender, DragEventArgs e)
        {
            LogPathComboBox.Text = DropFileName;
        }
        private void ProjectFolderComboBox_DragDrop(object sender, DragEventArgs e)
        {
            ProjectPathComboBox.Text = DropFileName;

        }

    }
}
