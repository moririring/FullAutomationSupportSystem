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
        FASS gFass = new FASS(); 

        public MainForm()
        {
            InitializeComponent();
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        private void AddDataGridView(TaskData task)
        {
            int count = taskDataBindingSource.Add(task);
            dataGridView1[dataGridView1.Columns["run"].Index, count].Value = "実行";
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
                gFass.taskDataList[e.RowIndex] = editTask;
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //セルかどうかは位置で見るしかない？
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
                    gFass.taskDataList.Add(editTask);
                    AddDataGridView(editTask);
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
            using (var ms = new FileStream(saveFileDialog1.FileName, FileMode.Create))
            {
                using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true }))
                {
                    //xw.Flush();
                    var serializer = new DataContractSerializer(typeof(FASS));
                    serializer.WriteObject(xw, gFass);
                }
            }
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var serializer = new DataContractSerializer(typeof(FASS));
            //読み込むファイルを開く
            using (var fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
            {
                gFass = (FASS)serializer.ReadObject(fs);
                foreach (var task in gFass.taskDataList)
                {
                    AddDataGridView(task);
                }
                fs.Close();
            }
        }


    }
}
