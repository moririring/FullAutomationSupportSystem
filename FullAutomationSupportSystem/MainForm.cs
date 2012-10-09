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
        static public readonly string gSaveTempFileName = @"Fass\SaveTemp.txt";
        static public string gFileName = "";
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
                var saveTempFileName = Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), gSaveTempFileName);
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
                File.Delete(saveTempFileName);
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
            //セーブ
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
        //Task編集
        //--------------------------------------------------------------------------
        private void EditTask(int idx)
        {
            var editTask = (TaskData)taskDataBindingSource[idx];
            var form = new TaskForm(editTask, gTaskList);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                editTask.SetLastRun();
                taskDataBindingSource[idx] = editTask;
                gTaskList[idx] = editTask;
            }
        }
        //--------------------------------------------------------------------------
        //dataGridView追加
        //--------------------------------------------------------------------------
        private void AddDataGridView(TaskData task)
        {
            task.SetLastRun();
            int count = taskDataBindingSource.Add(task);
            dataGridView1[dataGridView1.Columns["Log"].Index, count].Value = "ログ";
            dataGridView1[dataGridView1.Columns["Run"].Index, count].Value = "実行";
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //セルかどうかは位置で見るしかない？
        }
        //--------------------------------------------------------------------------
        //新しいタスク
        //--------------------------------------------------------------------------
        private void AddTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var editTask = new TaskData();
                //かぶらないファイル名を作る
                var co = 1;
                while (true)
                {
                    var NumberTaskName = "新しいタスク" + co++;
                    if (gTaskList.Count(t => t.Name == NumberTaskName) == 0)
                    {
                        editTask.Name = NumberTaskName;
                        break;
                    }
                }
                var eco = 1;
                while (true)
                {
                    var NumberExportFolder = "NewTask" + eco++;
                    if (gTaskList.Count(t => t.ExportFolder == NumberExportFolder) == 0)
                    {
                        editTask.ExportFolder = NumberExportFolder;
                        break;
                    }
                }
                editTask.ProjectFolder.Add(folderBrowserDialog1.SelectedPath);
                editTask.LogFolder = folderBrowserDialog1.SelectedPath;
                var form = new TaskForm(editTask, gTaskList);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    editTask.Checked = true;
                    gTaskList.Add(editTask);
                    AddDataGridView(editTask);
                }
            }
        }
        //--------------------------------------------------------------------------
        //時間表示
        //--------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerTextBox.Text = DateTime.Now.ToLongTimeString();
        }
        //--------------------------------------------------------------------------
        //終了
        //--------------------------------------------------------------------------
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
        private void RunButton_Click(object sender, EventArgs e)
        {
            RunButton.Enabled = false;
            var RunForm = new RunForm((TaskList)gTaskList.Clone());
            RunForm.Show();
            RunForm.Disposed += new EventHandler(gRunForm_Disposed);
        }
        //--------------------------------------------------------------------------
        //実行終了処理
        //--------------------------------------------------------------------------
        void gRunForm_Disposed(object sender, EventArgs e)
        {
            RunButton.Enabled = true;
            for(int i = 0; i < gTaskList.Count; i++)
            {
                var task = gTaskList[i];
                if (task.Checked)
                {
                    task.SetLastRun();
                    taskDataBindingSource[i] = task;
                }
            }
        }
        //--------------------------------------------------------------------------
        //セルクリック
        //--------------------------------------------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var task = gTaskList[e.RowIndex];
            //実行
            if (e.ColumnIndex == dataGridView1.Columns["ProjectFolder"].Index)
            {
                //Process.Start(task.ProjectFolder[0]);
            }
            //ログ
            else if (e.ColumnIndex == dataGridView1.Columns["Log"].Index)
            {
                var logName = Path.Combine(task.LogFolder, "RunLog.html");
                if (File.Exists(logName))
                {
                    Process.Start(logName);
                }
                else
                {
                    MessageBox.Show(logName + "が見つかりません");
                }
            }
        }
        //--------------------------------------------------------------------------
        //タスクコピー
        //--------------------------------------------------------------------------
        private void TaskCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        //--------------------------------------------------------------------------
        //タスク編集
        //--------------------------------------------------------------------------
        private void TaskEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                EditTask(row.Index);
            }
        }
        //--------------------------------------------------------------------------
        //タスク編集
        //--------------------------------------------------------------------------
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditTask(e.RowIndex);
        }
        //--------------------------------------------------------------------------
        //タスク削除
        //--------------------------------------------------------------------------
        private void TaskDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                gTaskList.RemoveAt(row.Index);
                taskDataBindingSource.RemoveAt(row.Index);
            }
        }

    }
}
