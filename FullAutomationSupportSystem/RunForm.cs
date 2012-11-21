using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FullAutomationSupportSystem
{
    public partial class RunForm : Form
    {
        private TaskList gTaskList = null;
        public RunForm(TaskList list)
        {
            InitializeComponent();
            gTaskList = list;
            backgroundWorker1.RunWorkerAsync();
        }
        //--------------------------------------------------------------------------
        //キャンセル
        //--------------------------------------------------------------------------
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CommandCancelButton.Enabled = false;
            backgroundWorker1.CancelAsync();
        }
        //--------------------------------------------------------------------------
        //実行
        //--------------------------------------------------------------------------
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;


            foreach (var task in gTaskList)
            {
                if (task.Checked == false) continue;
                try
                {
                    //プロセスログは最初に全消し
                    var deleteFiles = Directory.GetFiles(Path.Combine(task.LogPath, task.LogFolder), "RunLogProcess*.txt");
                    foreach (var deleteFile in deleteFiles)
                    {
                        File.Delete(deleteFile);
                    }
                    //
                    var StartTime = DateTime.Now;
                    //HTML
                    task.WriteRunLogHTML(true);
                    //ログテキストファイル生成
                    task.WriteRunLogNow(true, task.Name);
                    int logCounter = 0;
                    foreach (var command in task.CommandDataList)
                    {
                        if (command.Checked == false) continue;
                        backgroundWorker1.ReportProgress(counter++);

                        var processLogFileName = Path.Combine(task.LogPath, task.LogFolder + "\\RunLogProcess" + logCounter + ".txt");
                        var runMsg = CommandListManager.GetInstance().Run(processLogFileName, command.Type, command.Param1, command.Param2);

                        var name = "";
                        if (command.Type == CommandListType.Bat)
                        {
                            name = "<a href = 'RunLogProcess" + logCounter + ".txt'>" + command.Name + "</a>";
                        }
                        else
                        {
                            name = command.Name;
                        }
                        task.WriteRunLogNow(name, command.Param1, command.Param2, runMsg);
                        logCounter++;
                    }
                    task.WriteRunLogNow(false, "");
                    //ログcsvファイル生成
                    var EndTime = DateTime.Now;
                    var TotalTime = EndTime - StartTime;
                    task.WriteRunLogHistory(StartTime + "," + EndTime + "," + TotalTime + ",");
                    //HTML
                    task.WriteRunLogHTML(false);
                }
                catch (Exception ex)
                {
                    task.WriteRunLogNow(false, ex.Message);
                    throw;
                }
            }
        }
        //--------------------------------------------------------------------------
        //プログレス処理
        //--------------------------------------------------------------------------
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var index = e.ProgressPercentage;
            var co = 0;
            var max = 0;
            while (true)
            {
                //操作対象
                if (index < gTaskList[co].CommandDataList.Count + max)
                {
                    NowTaskTextBox.Text = gTaskList[co].Name;
                    NowCommandTextBox.Text = gTaskList[co].CommandDataList[index - max].Name;
                    //最初
                    if (index - max == 0)
                    {
                        var tlv = RunListView.Items.Add(gTaskList[co].Name);
                        tlv.SubItems.Add(gTaskList[co].ProjectPath);
                        tlv.SubItems.Add("");
                    }
                    if (gTaskList[co].CommandDataList.Count != index - max + 1)
                    {
                        NextCommandTextBox.Text = gTaskList[co].CommandDataList[index - max + 1].Name;
                    }
                    else
                    {
                        NextCommandTextBox.Text = "End";
                    }
                    var clv = RunListView.Items.Add(gTaskList[co].CommandDataList[index - max].Name);
                    var command = gTaskList[co].CommandDataList[index - max].Param1 + " : " +
                        gTaskList[co].CommandDataList[index - max].Param2;
                    clv.SubItems.Add(command);
                    clv.SubItems.Add("");
                    RunListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    break;
                }
                max += gTaskList[co].CommandDataList.Count;
                co++;
            }
        }
        //--------------------------------------------------------------------------
        //終了
        //--------------------------------------------------------------------------
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
            }
            else if (e.Cancelled)
            {
            }
            else
            {
            }
            this.Close();
        }
    }
}
