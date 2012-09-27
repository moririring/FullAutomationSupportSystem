using System;
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
        public TaskForm(TaskData data)
        {
            InitializeComponent();
            gTaskData = data;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            foreach (var command in gTaskData.CommandDataList)
            {
                AddDataGridView(command);
            }
            if (string.IsNullOrWhiteSpace(gTaskData.Name))
            {
                NameTextBox.Text = gNamePlease;
            }
            else
            {
                NameTextBox.Text = gTaskData.Name;
            }
            if (string.IsNullOrWhiteSpace(gTaskData.ExportFolder))
            {
                ExportFolderTextBox.Text = "NewTask";
            }
            else
            {
                ExportFolderTextBox.Text = gTaskData.ExportFolder;
            }
            ProjectFolderTextBox.Text = gTaskData.ProjectFolder;
            LogFolderComboBox.Text = gTaskData.LogFolder;
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
            dataGridView1[dataGridView1.Columns["run"].Index, count].Value = "実行";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ProjectFolderTextBox.Text) == false)
            {
                MessageBox.Show("作業フォルダが存在しません");
                return;
            }
            if (Directory.Exists(LogFolderComboBox.Text) == false)
            {
                MessageBox.Show("ログフォルダが存在しません");
                return;
            }

            this.DialogResult = DialogResult.OK; 

            gTaskData.Name = NameTextBox.Text;
            gTaskData.ExportFolder = ExportFolderTextBox.Text;
            gTaskData.ProjectFolder = ProjectFolderTextBox.Text;
            gTaskData.LogFolder = LogFolderComboBox.Text;
            gTaskData.Repository = RepositoryTextBox.Text;
            gTaskData.Timer = TimerCheckBox.Checked;
            gTaskData.Span = IntervalCheckBox.Checked;
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


    }
}
