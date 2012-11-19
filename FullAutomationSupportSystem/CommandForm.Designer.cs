namespace FullAutomationSupportSystem
{
    partial class CommandForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Param1ReadTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Param1TextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Param1Panel = new System.Windows.Forms.Panel();
            this.Param1Button = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Param2ComboBox = new System.Windows.Forms.ComboBox();
            this.Param2Button = new System.Windows.Forms.Button();
            this.Param2ReadTextBox = new System.Windows.Forms.TextBox();
            this.Param2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.Param1Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Param1ReadTextBox
            // 
            this.Param1ReadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Param1ReadTextBox.Location = new System.Drawing.Point(12, 27);
            this.Param1ReadTextBox.Multiline = true;
            this.Param1ReadTextBox.Name = "Param1ReadTextBox";
            this.Param1ReadTextBox.ReadOnly = true;
            this.Param1ReadTextBox.Size = new System.Drawing.Size(363, 46);
            this.Param1ReadTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "パラメータ1";
            // 
            // Param1TextBox
            // 
            this.Param1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Param1TextBox.Location = new System.Drawing.Point(12, 88);
            this.Param1TextBox.Multiline = true;
            this.Param1TextBox.Name = "Param1TextBox";
            this.Param1TextBox.Size = new System.Drawing.Size(339, 24);
            this.Param1TextBox.TabIndex = 5;
            this.Param1TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Param1TextBox_DragDrop);
            this.Param1TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Param1TextBox_DragEnter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 30);
            this.panel1.TabIndex = 14;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(340, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 158);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Param1Panel
            // 
            this.Param1Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Param1Panel.Controls.Add(this.Param1Button);
            this.Param1Panel.Controls.Add(this.Param1ReadTextBox);
            this.Param1Panel.Controls.Add(this.Param1TextBox);
            this.Param1Panel.Controls.Add(this.label1);
            this.Param1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Param1Panel.Location = new System.Drawing.Point(0, 0);
            this.Param1Panel.Name = "Param1Panel";
            this.Param1Panel.Size = new System.Drawing.Size(392, 128);
            this.Param1Panel.TabIndex = 15;
            // 
            // Param1Button
            // 
            this.Param1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Param1Button.AutoSize = true;
            this.Param1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Param1Button.Location = new System.Drawing.Point(353, 88);
            this.Param1Button.Name = "Param1Button";
            this.Param1Button.Size = new System.Drawing.Size(21, 22);
            this.Param1Button.TabIndex = 10;
            this.Param1Button.Text = "...";
            this.Param1Button.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(392, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 128);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Param2ComboBox);
            this.panel3.Controls.Add(this.Param2Button);
            this.panel3.Controls.Add(this.Param2ReadTextBox);
            this.panel3.Controls.Add(this.Param2TextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(395, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 128);
            this.panel3.TabIndex = 17;
            // 
            // Param2ComboBox
            // 
            this.Param2ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2ComboBox.FormattingEnabled = true;
            this.Param2ComboBox.Location = new System.Drawing.Point(12, 88);
            this.Param2ComboBox.Name = "Param2ComboBox";
            this.Param2ComboBox.Size = new System.Drawing.Size(337, 20);
            this.Param2ComboBox.TabIndex = 12;
            // 
            // Param2Button
            // 
            this.Param2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2Button.AutoSize = true;
            this.Param2Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Param2Button.Location = new System.Drawing.Point(328, 88);
            this.Param2Button.Name = "Param2Button";
            this.Param2Button.Size = new System.Drawing.Size(21, 22);
            this.Param2Button.TabIndex = 11;
            this.Param2Button.Text = "...";
            this.Param2Button.UseVisualStyleBackColor = true;
            // 
            // Param2ReadTextBox
            // 
            this.Param2ReadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2ReadTextBox.Location = new System.Drawing.Point(12, 27);
            this.Param2ReadTextBox.Multiline = true;
            this.Param2ReadTextBox.Name = "Param2ReadTextBox";
            this.Param2ReadTextBox.ReadOnly = true;
            this.Param2ReadTextBox.Size = new System.Drawing.Size(337, 46);
            this.Param2ReadTextBox.TabIndex = 9;
            // 
            // Param2TextBox
            // 
            this.Param2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Param2TextBox.Location = new System.Drawing.Point(12, 88);
            this.Param2TextBox.Multiline = true;
            this.Param2TextBox.Name = "Param2TextBox";
            this.Param2TextBox.Size = new System.Drawing.Size(313, 24);
            this.Param2TextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "パラメータ2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "bat";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "batファイル|*.bat";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CommandForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 180);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Param1Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CommandForm";
            this.Text = "プロセスフォーム";
            this.Resize += new System.EventHandler(this.CommandForm_Resize);
            this.panel1.ResumeLayout(false);
            this.Param1Panel.ResumeLayout(false);
            this.Param1Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Param1ReadTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Param1TextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel Param1Panel;
        private System.Windows.Forms.Button Param1Button;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Param2ReadTextBox;
        private System.Windows.Forms.TextBox Param2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Param2Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox Param2ComboBox;
    }
}