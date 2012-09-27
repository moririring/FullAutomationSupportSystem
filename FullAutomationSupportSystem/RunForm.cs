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
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButton.Enabled = false;
            backgroundWorker1.CancelAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int counter = 0;
            foreach (var task in gTaskList)
            {
                //ファイル生成
                var logFile = Path.Combine(task.LogFolder, task.ExportFolder + "\\" + "RunLog.txt");
                if (Directory.Exists(Path.GetDirectoryName(logFile)) == false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(logFile));
                }
                using (var sw = new StreamWriter(logFile, false, Encoding.UTF8))
                {
                    var msg = task.Name + " : " + task.ProjectFolder;
                    sw.WriteLine("Start!!");
                    sw.WriteLine(msg);
                }
                foreach (var command in task.CommandDataList)
                {
                    backgroundWorker1.ReportProgress(counter++);
                    CommandListManager.GetInstance().Run(command.Type, command.Param1, command.Param2);
                    using (var sw = new StreamWriter(logFile, true, Encoding.UTF8))
                    {
                        var msg = command.Name  + " : " + command.Param1  + " : " + command.Param2;
                        sw.WriteLine(msg);
                    }
                }
                using (var sw = new StreamWriter(logFile, true, Encoding.UTF8))
                {
                    sw.WriteLine("End!!");
                }
            }
        }

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
                        tlv.SubItems.Add(gTaskList[co].ProjectFolder);
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
            //
            foreach (var task in gTaskList)
            {
            }

            this.Close();
        }
    }
}
