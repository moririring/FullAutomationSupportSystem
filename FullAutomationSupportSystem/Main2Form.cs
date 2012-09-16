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
    public partial class Main2Form : Form
    {
        public Main2Form()
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
            if (folderBrowserDialog1.ShowDialog(this) == DialogResult.OK)
            {
                WorkFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
                NameTextBox.Text = "名前を入力してください";
                //文字を全部青い選択状態にする
                NameTextBox.Focus();
                CommandListView.Items.Add("コマンドを追加してください");
            }
        }
    }
}
