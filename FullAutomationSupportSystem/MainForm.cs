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
        TaskList gTaskList = new TaskList();
        static public readonly string gApplicationIniFileName = @"Fass\Fass.ini";
        static public string gFileName ="";
        //--------------------------------------------------------------------------
        //コンストラクタ
        //--------------------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        //--------------------------------------------------------------------------
        //開始
        //--------------------------------------------------------------------------
        private void MainForm_Load(object sender, EventArgs e)
        {
            var iniFileName = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gApplicationIniFileName);
            if (File.Exists(iniFileName))
            {
                //読み込むファイルを開く
                using (var fs = new FileStream(iniFileName, FileMode.Open))
                {
                    var serializer = new DataContractSerializer(typeof(IniData));
                    var iniData = (IniData)serializer.ReadObject(fs);
                    FileLoad(iniData.FileName);
                    fs.Close();
                }
            }
        }
        //--------------------------------------------------------------------------
        //終了
        //--------------------------------------------------------------------------
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //一時ファイルをセーブして、比較する出力場所はTEMP
            //(gTaskList.Save(saveFileDialog1.FileName))

            if (MessageBox.Show("終了してもいいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }


            var iniFileName = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gApplicationIniFileName);
            if(Directory.Exists(Path.GetDirectoryName(iniFileName)) ==false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(iniFileName));
            }
            using (var ms = new FileStream(iniFileName, FileMode.Create))
            {
                using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true }))
                {
                    var serializer = new DataContractSerializer(typeof(IniData));
                    var iniData = new IniData();
                    iniData.FileName = gFileName;
                    serializer.WriteObject(xw, iniData);
                }
            }
        }
        //--------------------------------------------------------------------------
        //ファイルロード
        //--------------------------------------------------------------------------
        private void FileLoad(string fileName)
        {
            if (File.Exists(fileName) == false) return;
            //読み込むファイルを開く
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var serializer = new DataContractSerializer(typeof(TaskList));
                gTaskList = (TaskList)serializer.ReadObject(fs);
                //Load処理
                foreach (var task in gTaskList)
                {
                    AddDataGridView(task);
                }
                fs.Close();
                gFileName = fileName;
            }
        }
        //--------------------------------------------------------------------------
        //dataGridView追加
        //--------------------------------------------------------------------------
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
                gTaskList[e.RowIndex] = editTask;
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
                    gTaskList.Add(editTask);
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
            if (gTaskList.Save(saveFileDialog1.FileName))
            {
                gFileName = saveFileDialog1.FileName;
            }
        }
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileLoad(openFileDialog1.FileName);
        }

    }
}
