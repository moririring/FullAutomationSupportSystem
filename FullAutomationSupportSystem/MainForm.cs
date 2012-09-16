using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FullAutomationSupportSystem
{
    public partial class MainForm : Form
    {
        TaskList gTaskList = new TaskList(); 

        public MainForm()
        {
            InitializeComponent();
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
            ツールバーはやめてボタンを作る！
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();

        }

        private void FolderAddToolStripButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var editTask = new TaskData();
                editTask.ProjectFolder = folderBrowserDialog1.SelectedPath;
                editTask.LogFolder = folderBrowserDialog1.SelectedPath;

                var form = new TaskForm(editTask);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    editTask.Checked = true;
                    gTaskList.Add(editTask);
                    int count = taskDataBindingSource.Add(editTask);
                    dataGridView1[dataGridView1.Columns["run"].Index, count].Value = "実行";
                }
            }

        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var editTask = (TaskData)taskDataBindingSource[e.RowIndex];
            var form = new TaskForm(editTask);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                taskDataBindingSource[e.RowIndex] = editTask;
                gTaskList.Edit(e.RowIndex, editTask);
            }
        }
    }
}
