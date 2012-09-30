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
using System.Diagnostics;

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
            var iniFileName = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gApplicationIniFileName);
            if (Directory.Exists(Path.GetDirectoryName(iniFileName)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(iniFileName));
            }
            //タスクがなければセーブチェックなし
            bool bSave = (gTaskList.Count == 0) ? false : true;
            //既存セーブファイルがあれば
            if (bSave == true && gFileName != "")
            {
                var saveTempFileName = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Fass\SaveTemp.txt");
                gTaskList.Save(saveTempFileName);
                var sr1 = new StreamReader(saveTempFileName, Encoding.UTF8);
                var sr2 = new StreamReader(gFileName, Encoding.UTF8);
                //変更がなければセーブチェックなし
                if (sr1.ReadToEnd() == sr2.ReadToEnd())
                {
                    bSave = false;
                }
                sr1.Close();
                sr2.Close();
            }
            //セーブチェック
            if (bSave)
            {
                DialogResult result = MessageBox.Show("セーブしますか？", "確認", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    if (gFileName == "")
                    {
                        saveFileDialog1.ShowDialog();
                    }
                    else
                    {
                        gTaskList.Save(gFileName);
                    }
                }
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
            if (gTaskList.Load(fileName))
            {
                foreach (var task in gTaskList)
                {
                    AddDataGridView(task);
                }
                gFileName = fileName;
            }
        }
        //--------------------------------------------------------------------------
        //dataGridView追加
        //--------------------------------------------------------------------------
        private void AddDataGridView(TaskData task)
        {
            int count = taskDataBindingSource.Add(task);
            dataGridView1[dataGridView1.Columns["Log"].Index, count].Value = "ログ";
            dataGridView1[dataGridView1.Columns["Run"].Index, count].Value = "実行";
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
        //--------------------------------------------------------------------------
        //名前を付けて保存
        //--------------------------------------------------------------------------
        private void NameSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
        //--------------------------------------------------------------------------
        //保存
        //--------------------------------------------------------------------------
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gFileName == "")
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                gTaskList.Save(gFileName);
            }
        }
        //--------------------------------------------------------------------------
        //保存する
        //--------------------------------------------------------------------------
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (gTaskList.Save(saveFileDialog1.FileName))
            {
                gFileName = saveFileDialog1.FileName;
            }
        }
        //--------------------------------------------------------------------------
        //開く
        //--------------------------------------------------------------------------
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        //--------------------------------------------------------------------------
        //ロード
        //--------------------------------------------------------------------------
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            FileLoad(openFileDialog1.FileName);
        }
        //--------------------------------------------------------------------------
        //閉じる
        //--------------------------------------------------------------------------
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gTaskList.Clear();
            taskDataBindingSource.Clear();
            gFileName = "";
        }
        //--------------------------------------------------------------------------
        //実行
        //--------------------------------------------------------------------------
        private RunForm gRunForm = null;
        private void RunButton_Click(object sender, EventArgs e)
        {
            RunButton.Enabled = false;
            gRunForm = new RunForm((TaskList)gTaskList.Clone());
            gRunForm.Show();
            gRunForm.Disposed += new EventHandler(gRunForm_Disposed);
        }
        void gRunForm_Disposed(object sender, EventArgs e)
        {
            RunButton.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //実行を押された
            if (e.ColumnIndex == dataGridView1.Columns["ProjectFolder"].Index)
            {
                var task = gTaskList[e.RowIndex];
                Process.Start(task.ProjectFolder);
            }
        }


    }
}
