using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;

namespace FullAutomationSupportSystem
{
    public partial class MainForm : Form
    {
        TaskManager gTaskList = new TaskManager(); 

        public MainForm()
        {
            InitializeComponent();
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        private void FolderAddToolStripButton_Click(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var editTask = (TaskData)taskDataBindingSource[e.RowIndex];
            var form = new TaskForm(editTask);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                taskDataBindingSource[e.RowIndex] = editTask;
                gTaskList[e.RowIndex] = editTask;
            }
        }
        private void AddTaskToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NameSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (var fs = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8))
            {
                var serializer = new DataContractSerializer(typeof(TaskManager));

                using (var ms = new MemoryStream())
                using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true }))
                {
                    serializer.WriteObject(xw, gTaskList);
                    xw.Flush();
                    var xml = Encoding.UTF8.GetString(ms.ToArray(), 0, (int)ms.Length);
                    serializer.WriteObject(fs, xml);
                }
                fs.Close();
            }



/*
            using (var fs = new XmlTextWriter(saveFileDialog1.FileName, Encoding.UTF8))
            {
                var serializer = new DataContractSerializer(typeof(TaskManager));
                //serializer.WriteObject(fs, gTaskList);

                using (var ms = new MemoryStream())
                using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true }))
                {
                    serializer.WriteObject(xw, gTaskList);
                    xw.Flush();
                    var xml = Encoding.UTF8.GetString(ms.ToArray(), 0, (int)ms.Length);
                    serializer.W.WriteObject(fs, xml);
                }
                fs.Close();
            }
 */ 
        }
    }
}
