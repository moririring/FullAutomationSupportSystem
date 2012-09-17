using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FullAutomationSupportSystem;

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

            if(gCommandListData.Param1Type == CommandListParamType.File)
            {
                Param1TextBox.Multiline = false;
                Param1Button.Click += new EventHandler(Param1Button_Click_FileOpen);
            }



            if (gCommandListData.Param2Type == CommandListParamType.TrueFalse)
            {
                Param2Button.Visible = false;
                Param2TextBox.Visible = false;

                Param2ComboBox.Items.Add("true");
                Param2ComboBox.Items.Add("false");
                Param2ComboBox.Text = "true";
            }


        }
        private void Param1Button_Click_FileOpen(object sender, EventArgs e)
        {
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

            if (gCommandListData.Param2Type == CommandListParamType.TrueFalse)
            {
                gCommandData.Param2 = Param2ComboBox.Text;
            }
        }
    }
}
