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
        //のこり時間
        //--------------------------------------------------------------------------
        private string GetRemainingLongTime(DateTime longTime)
        {
            //longTimeを今日にパースしてから引き算
            var remainingTime = DateTime.Parse(longTime.ToLongTimeString()) - DateTime.Now;
            //現在が15時で設定時間が17時だと+2、設定時間が13だと-2が変える
            if (remainingTime.TotalDays < 0.0)
            {
                //マイナス2時間とは表示出来ないので1日プラス
                remainingTime = remainingTime.Add(new TimeSpan(1, 0, 0, 0));
            }
            //TimeSpanはToLongTimeString関数がないので、DataTimeにパースしてから取得
            return DateTime.Parse(remainingTime.ToString()).ToLongTimeString();
        }
        //--------------------------------------------------------------------------
        //のこり分
        //--------------------------------------------------------------------------
        private DateTime StartSpanTime;
        private string GetRemainingLongTime(int minutes)
        {
            var remainingTime = new TimeSpan(0, minutes, 0);
            remainingTime = remainingTime - (DateTime.Now - StartSpanTime);
            return DateTime.Parse(remainingTime.ToString()).ToLongTimeString();
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
                    AddDataGridView(task, taskDataBindingSource.Add(task));
                }
                gFileName = fileName;
            }
        }
        //--------------------------------------------------------------------------
        //タスク編集
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
        //タスク追加
        //--------------------------------------------------------------------------
        private void AddTask(string path)
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
            editTask.ProjectFolder.Add(path);
            editTask.LogFolder = path;
            var form = new TaskForm(editTask, gTaskList);
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                editTask.Checked = true;
                gTaskList.Add(editTask);
                AddDataGridView(editTask, taskDataBindingSource.Add(editTask));
            }
        }
        //--------------------------------------------------------------------------
        //タスク実行
        //--------------------------------------------------------------------------
        private void RunTask(TaskList taskList)
        {
            RunButton.Enabled = false;
            var RunForm = new RunForm(taskList);
            RunForm.Show();
            RunForm.Disposed += new EventHandler(gRunForm_Disposed);
        }
        //--------------------------------------------------------------------------
        //dataGridView追加
        //--------------------------------------------------------------------------
        private void AddDataGridView(TaskData task, int count)
        {
            task.SetLastRun();
            var folders = new List<string>();
            folders.AddRange(task.ProjectFolder);
            var combobind = dataGridView1["ProjectFolder", count] as DataGridViewComboBoxCell;
            combobind.DataSource = new BindingSource(folders, string.Empty); 
            dataGridView1["ProjectFolder", count].Value = task.ProjectFolder[0];
            dataGridView1["Log", count].Value = "ログ";
            dataGridView1["Run", count].Value = "実行";
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
                AddTask(folderBrowserDialog1.SelectedPath);
            }
        }
        //--------------------------------------------------------------------------
        //時間表示
        //--------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            //タイマー
            if (TimerCheckBox.Checked == true)
            {
                TimerTextBox.Text = GetRemainingLongTime(TimerDateTimePicker.Value);
                if (TimerTextBox.Text == "0:00:00")
                {
                    var taskList = (TaskList)gTaskList.Clone();
                    foreach (var task in taskList)
                    {
                        task.Checked = (task.Timer == true && task.Checked == true);
                    }
                    RunTask(taskList);
                }
            }
            //スパン
            if (SpanCheckBox.Checked == true)
            {
                SpanTextBox.Text = GetRemainingLongTime((int)SpanNumericUpDown.Value);
                if (SpanTextBox.Text == "0:00:00")
                {
                    StartSpanTime = DateTime.Now;
                    var taskList = (TaskList)gTaskList.Clone();
                    foreach (var task in taskList)
                    {
                        task.Checked = (task.Span == true && task.Checked == true);
                    }
                    RunTask(taskList);
                }
            }

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
            RunTask((TaskList)gTaskList.Clone());
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
        private void dataGridView1CheckboxCheck(string name, DataGridViewCellEventArgs e)
        {
            //チェック
            if (e.ColumnIndex == dataGridView1.Columns[name].Index)
            {
                //全部以外ははじく
                if (e.RowIndex != -1) return;

                var count = dataGridView1.Rows.Cast<DataGridViewRow>().Count(r => (bool)r.Cells[name].EditedFormattedValue == true);
                var bCheckd = (count != dataGridView1.Rows.Count);
                for (int i = 0; i < gTaskList.Count; i++)
                {
                    if (name == "Checked")
                    {
                        gTaskList[i].Checked = bCheckd;
                    }
                    else if (name == "Timer")
                    {
                        gTaskList[i].Timer = bCheckd;
                    }
                    else if (name == "Span")
                    {
                        gTaskList[i].Span = bCheckd;
                    }
                    taskDataBindingSource[i] = gTaskList[i];
                }
            }
        }
        //--------------------------------------------------------------------------
        //セルクリック
        //--------------------------------------------------------------------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1CheckboxCheck("Checked", e);
            dataGridView1CheckboxCheck("Timer", e);
            dataGridView1CheckboxCheck("Span", e);

            //実行
            if (e.ColumnIndex == dataGridView1.Columns["ProjectFolder"].Index)
            {
                //Process.Start(task.ProjectFolder[0]);
            }
            //ログ
            else if (e.ColumnIndex == dataGridView1.Columns["Log"].Index)
            {
                if (e.RowIndex == -1) return;
                var task = gTaskList[e.RowIndex];

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
        private void taskDataBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
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
            if (e.RowIndex == -1) return;
            EditTask(e.RowIndex);
        }
        //--------------------------------------------------------------------------
        //タスク削除
        //--------------------------------------------------------------------------
        private void TaskDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            DialogResult result = MessageBox.Show("本当に削除してよろしいですか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                gTaskList.RemoveAt(row.Index);
                taskDataBindingSource.RemoveAt(row.Index);
            }
        }
        //--------------------------------------------------------------------------
        //dataGridViewがワンクリックですむおまじない
        //--------------------------------------------------------------------------
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "ProjectFolder" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                SendKeys.Send("{F4}");
            }
        }
        //--------------------------------------------------------------------------
        //dataGridViewがストップしないおまじない
        //--------------------------------------------------------------------------
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }
        //--------------------------------------------------------------------------
        //dataGridViewドラッグ&ドロップ
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
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left && dataGridView1.Rows.Count > rowIndexFromMouseDown)
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
                e.Effect = DragDropEffects.All;
            }
            else if (rowIndexFromDragOver != -1)
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
                    AddTask(s[0]);
                }
                else if (File.Exists(s[0]) == true)
                {
                    AddTask(Path.GetDirectoryName(s[0]));
                }
            }
            //コントロール内操作
            else
            {
                var editTask = (TaskData)taskDataBindingSource[rowIndexFromMouseDown];
                taskDataBindingSource.RemoveAt(rowIndexFromMouseDown);
                taskDataBindingSource.Insert(rowIndexFromDragOver, editTask);
                gTaskList.RemoveAt(rowIndexFromMouseDown);
                gTaskList.Insert(rowIndexFromDragOver, editTask);
                AddDataGridView(editTask, rowIndexFromDragOver);
            }
        }
        private void SpanNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            StartSpanTime = DateTime.Now;
        }

        private void TimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var check = sender as CheckBox;
            TimerTextBox.Text =  (check.Checked == true) ? GetRemainingLongTime(TimerDateTimePicker.Value) : "--:--:--";
        }

        private void SpanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            StartSpanTime = DateTime.Now;

            var check = sender as CheckBox;
            SpanTextBox.Text = (check.Checked == true) ? GetRemainingLongTime((int)SpanNumericUpDown.Value) : "--:--:--";
        }

    }
}
