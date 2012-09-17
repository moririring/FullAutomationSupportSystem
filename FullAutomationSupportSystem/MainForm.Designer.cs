namespace FullAutomationSupportSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logFolderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repositoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intervalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 21);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "←";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "←";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(391, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 19);
            this.numericUpDown1.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(282, 28);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "インターバル実行";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Location = new System.Drawing.Point(477, 5);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.ReadOnly = true;
            this.TimerTextBox.Size = new System.Drawing.Size(61, 19);
            this.TimerTextBox.TabIndex = 4;
            this.TimerTextBox.Text = "00:00:00";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(449, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(372, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "00:00:00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(282, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "タイマー実行";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(737, 274);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check,
            this.nameDataGridViewTextBoxColumn,
            this.projectFolderDataGridViewTextBoxColumn,
            this.logFolderDataGridViewTextBoxColumn,
            this.repositoryDataGridViewTextBoxColumn,
            this.timerDataGridViewCheckBoxColumn,
            this.intervalDataGridViewCheckBoxColumn,
            this.Run});
            this.dataGridView1.DataSource = this.taskDataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 274);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Check
            // 
            this.Check.DataPropertyName = "Checked";
            this.Check.HeaderText = "ﾁｪｯｸ";
            this.Check.Name = "Check";
            this.Check.Width = 36;
            // 
            // Run
            // 
            this.Run.HeaderText = "実行";
            this.Run.Name = "Run";
            this.Run.ReadOnly = true;
            this.Run.Width = 35;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.TimerTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 53);
            this.panel1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "新しいタスク...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTaskToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // AddTaskToolStripMenuItem
            // 
            this.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem";
            this.AddTaskToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.AddTaskToolStripMenuItem.Text = "新しいタスク(&T)...";
            this.AddTaskToolStripMenuItem.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名前";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // projectFolderDataGridViewTextBoxColumn
            // 
            this.projectFolderDataGridViewTextBoxColumn.DataPropertyName = "ProjectFolder";
            this.projectFolderDataGridViewTextBoxColumn.HeaderText = "パス";
            this.projectFolderDataGridViewTextBoxColumn.Name = "projectFolderDataGridViewTextBoxColumn";
            this.projectFolderDataGridViewTextBoxColumn.ReadOnly = true;
            this.projectFolderDataGridViewTextBoxColumn.Width = 49;
            // 
            // logFolderDataGridViewTextBoxColumn
            // 
            this.logFolderDataGridViewTextBoxColumn.DataPropertyName = "LogFolder";
            this.logFolderDataGridViewTextBoxColumn.HeaderText = "LogFolder";
            this.logFolderDataGridViewTextBoxColumn.Name = "logFolderDataGridViewTextBoxColumn";
            this.logFolderDataGridViewTextBoxColumn.ReadOnly = true;
            this.logFolderDataGridViewTextBoxColumn.Visible = false;
            this.logFolderDataGridViewTextBoxColumn.Width = 80;
            // 
            // repositoryDataGridViewTextBoxColumn
            // 
            this.repositoryDataGridViewTextBoxColumn.DataPropertyName = "Repository";
            this.repositoryDataGridViewTextBoxColumn.HeaderText = "Repository";
            this.repositoryDataGridViewTextBoxColumn.Name = "repositoryDataGridViewTextBoxColumn";
            this.repositoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.repositoryDataGridViewTextBoxColumn.Visible = false;
            this.repositoryDataGridViewTextBoxColumn.Width = 85;
            // 
            // timerDataGridViewCheckBoxColumn
            // 
            this.timerDataGridViewCheckBoxColumn.DataPropertyName = "Timer";
            this.timerDataGridViewCheckBoxColumn.HeaderText = "ﾀｲﾏｰ";
            this.timerDataGridViewCheckBoxColumn.Name = "timerDataGridViewCheckBoxColumn";
            this.timerDataGridViewCheckBoxColumn.Width = 39;
            // 
            // intervalDataGridViewCheckBoxColumn
            // 
            this.intervalDataGridViewCheckBoxColumn.DataPropertyName = "Interval";
            this.intervalDataGridViewCheckBoxColumn.HeaderText = "ｲﾝﾀｰﾊﾞﾙ";
            this.intervalDataGridViewCheckBoxColumn.Name = "intervalDataGridViewCheckBoxColumn";
            this.intervalDataGridViewCheckBoxColumn.Width = 58;
            // 
            // taskDataBindingSource
            // 
            this.taskDataBindingSource.DataSource = typeof(FullAutomationSupportSystem.TaskData);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox TimerTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource taskDataBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repositoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn timerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn intervalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTaskToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}