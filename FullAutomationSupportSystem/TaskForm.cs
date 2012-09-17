using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FullAutomationSupportSystem;

namespace FullAutomationSupportSystem
{
    public partial class TaskForm : Form
    {
        private TaskData gTaskData = null;
        public TaskForm(TaskData data)
        {
            InitializeComponent();
            gTaskData = data;
            foreach (var command in gTaskData)
            {
                commandDataBindingSource.Add(command);
            }

            NameTextBox.Text = "名前を入力してください";
            ProjectFolderTextBox.Text = gTaskData.ProjectFolder;
            LogFolderComboBox.Text = gTaskData.ProjectFolder;
            NameTextBox.Focus();

            foreach (CommandListData commandList in CommandListManager.GetInstance())
            {
                CommandComboBox.Items.Add(commandList.Name);
            }
            CommandComboBox.Text = CommandComboBox.Items[0].ToString();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            gTaskData.Name = NameTextBox.Text;
            gTaskData.ProjectFolder = ProjectFolderTextBox.Text;
            gTaskData.LogFolder = LogFolderComboBox.Text;
            gTaskData.Repository = RepositoryTextBox.Text;
            gTaskData.Timer = TimerCheckBox.Checked;
            gTaskData.Interval = IntervalCheckBox.Checked;
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
            gTaskData.Add(data);
            var form = new CommandForm(gTaskData[gTaskData.Count - 1]);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int count = commandDataBindingSource.Add(data);
                dataGridView1[dataGridView1.Columns["run"].Index, count].Value = "実行";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //実行を押された
            if(e.ColumnIndex == dataGridView1.Columns["run"].Index)
            {
                var task = gTaskData[e.RowIndex];
                CommandListManager.GetInstance().Run(task.Type, task.Param1, task.Param2);
            }
        }
    }
}
