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
            NameTextBox.Text = "名前を入力してください";
            ProjectFolderTextBox.Text = gTaskData.ProjectFolder;
            LogFolderComboBox.Text = gTaskData.ProjectFolder;
            NameTextBox.Focus();
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
    }
}
