using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FullAutomationSupportSystem;
using System.IO;

namespace FullAutomationSupportSystem
{
    public partial class CommandForm : Form
    {
        private CommandListData gCommandListData = null;
        private CommandData gCommandData = null;
        public CommandForm(CommandData data)
        {
            InitializeComponent();

            gCommandData = data;
            gCommandListData = CommandListManager.GetInstance()[(int)data.Type];
            Param1ReadTextBox.Text = gCommandListData.Param1Txt;
            Param2ReadTextBox.Text = gCommandListData.Param2Txt;
            SetParam1CommandListData();
            SetParam2CommandListData();
        }
        private void SetParam1CommandListData()
        {
            if (gCommandListData.Param1Type == CommandListParamType.File)
            {
                Param1Button.Click += new EventHandler(Param1Button_Click_FileOpen);
                //
                Param1TextBox.Multiline = false;
                Param1TextBox.Text = gCommandData.Param1;
                Param1TextBox.AllowDrop = true;
            }
            if (gCommandListData.Param1Type == CommandListParamType.OneLine)
            {
                Param1TextBox.Multiline = false;
                Param1Button.Visible = false;
            }
        }
        private void SetParam2CommandListData()
        {
            if (gCommandListData.Param2Type == CommandListParamType.TrueFalse)
            {
                Param2Button.Visible = false;
                Param2TextBox.Visible = false;

                Param2ComboBox.Items.Add("true");
                Param2ComboBox.Items.Add("false");
                Param2ComboBox.Text = (gCommandData.Param2 != "") ? gCommandData.Param2 : "true";
            }
            if (gCommandListData.Param2Type == CommandListParamType.OneLine)
            {
                Param2Button.Visible = false;
                Param2ComboBox.Visible = false;
                Param2TextBox.Text = gCommandData.Param2;
                Param2TextBox.Multiline = false;
            }
        }
        private void Param1Button_Click_FileOpen(object sender, EventArgs e)
        {
            if(File.Exists(Param1TextBox.Text) == true)
            {
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(Param1TextBox.Text);
                openFileDialog1.FileName = Param1TextBox.Text;
            }
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Param1TextBox.Text = openFileDialog1.FileName;
        }
        private void CommandForm_Resize(object sender, EventArgs e)
        {
            Param1Panel.Width = this.Width / 2;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if(gCommandListData.Param1Type == CommandListParamType.File)
            {
                gCommandData.Param1 = Param1TextBox.Text;
            }
            if (gCommandListData.Param2Type == CommandListParamType.OneLine)
            {
                gCommandData.Param2 = Param2TextBox.Text;
            }
            if (gCommandListData.Param2Type == CommandListParamType.TrueFalse)
            {
                gCommandData.Param2 = Param2ComboBox.Text;
            }
        }
        private string DropFileName = "";

        private void Param1TextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var fileName = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(fileName[0]) == true)
                {
                    DropFileName = fileName[0];
                    e.Effect = DragDropEffects.All;
                }
            }
        }
        private void Param1TextBox_DragDrop(object sender, DragEventArgs e)
        {
            Param1TextBox.Text = DropFileName;
        }
    }
}
