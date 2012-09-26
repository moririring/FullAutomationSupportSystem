﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        public void SetIndex(int index)
        {
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
                foreach (var command in task.CommandDataList)
                {
                    backgroundWorker1.ReportProgress(counter++);
                    CommandListManager.GetInstance().Run(command.Type, command.Param1, command.Param2);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           SetIndex(e.ProgressPercentage);
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
                this.Close();
            }
        }
    }
}
