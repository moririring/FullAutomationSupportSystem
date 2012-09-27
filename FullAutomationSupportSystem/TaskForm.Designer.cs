namespace FullAutomationSupportSystem
{
    partial class TaskForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.commandDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommandListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogFolderComboBox = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.IntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RepositoryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProjectFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CommandButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExportFolderTextBox = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDataBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.CommandListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(761, 212);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkedDataGridViewCheckBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.param1DataGridViewTextBoxColumn,
            this.param2DataGridViewTextBoxColumn,
            this.Run});
            this.dataGridView1.DataSource = this.commandDataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(757, 208);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // checkedDataGridViewCheckBoxColumn
            // 
            this.checkedDataGridViewCheckBoxColumn.DataPropertyName = "Checked";
            this.checkedDataGridViewCheckBoxColumn.HeaderText = "ﾁｪｯｸ";
            this.checkedDataGridViewCheckBoxColumn.Name = "checkedDataGridViewCheckBoxColumn";
            this.checkedDataGridViewCheckBoxColumn.Width = 36;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            this.typeDataGridViewTextBoxColumn.Width = 55;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名前";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // param1DataGridViewTextBoxColumn
            // 
            this.param1DataGridViewTextBoxColumn.DataPropertyName = "Param1";
            this.param1DataGridViewTextBoxColumn.HeaderText = "ﾊﾟﾗﾒｰﾀ1";
            this.param1DataGridViewTextBoxColumn.Name = "param1DataGridViewTextBoxColumn";
            this.param1DataGridViewTextBoxColumn.Width = 74;
            // 
            // param2DataGridViewTextBoxColumn
            // 
            this.param2DataGridViewTextBoxColumn.DataPropertyName = "Param2";
            this.param2DataGridViewTextBoxColumn.HeaderText = "ﾊﾟﾗﾒｰﾀ2";
            this.param2DataGridViewTextBoxColumn.Name = "param2DataGridViewTextBoxColumn";
            this.param2DataGridViewTextBoxColumn.Width = 74;
            // 
            // Run
            // 
            this.Run.HeaderText = "実行";
            this.Run.Name = "Run";
            this.Run.Width = 35;
            // 
            // commandDataBindingSource
            // 
            this.commandDataBindingSource.DataSource = typeof(FullAutomationSupportSystem.CommandData);
            // 
            // CommandListView
            // 
            this.CommandListView.CheckBoxes = true;
            this.CommandListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.CommandListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandListView.FullRowSelect = true;
            this.CommandListView.GridLines = true;
            this.CommandListView.HideSelection = false;
            this.CommandListView.Location = new System.Drawing.Point(0, 0);
            this.CommandListView.MultiSelect = false;
            this.CommandListView.Name = "CommandListView";
            this.CommandListView.Size = new System.Drawing.Size(757, 208);
            this.CommandListView.TabIndex = 1;
            this.CommandListView.UseCompatibleStateImageBehavior = false;
            this.CommandListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名前";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.ExportFolderTextBox);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.LogFolderComboBox);
            this.panel6.Controls.Add(this.numericUpDown1);
            this.panel6.Controls.Add(this.IntervalCheckBox);
            this.panel6.Controls.Add(this.TimerCheckBox);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.RepositoryTextBox);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.ProjectFolderTextBox);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.NameTextBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(761, 129);
            this.panel6.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(618, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 22);
            this.button2.TabIndex = 16;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(726, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "ログ番号";
            // 
            // LogFolderComboBox
            // 
            this.LogFolderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LogFolderComboBox.FormattingEnabled = true;
            this.LogFolderComboBox.Location = new System.Drawing.Point(81, 53);
            this.LogFolderComboBox.Name = "LogFolderComboBox";
            this.LogFolderComboBox.Size = new System.Drawing.Size(531, 20);
            this.LogFolderComboBox.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(698, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 19);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IntervalCheckBox
            // 
            this.IntervalCheckBox.AutoSize = true;
            this.IntervalCheckBox.Location = new System.Drawing.Point(81, 104);
            this.IntervalCheckBox.Name = "IntervalCheckBox";
            this.IntervalCheckBox.Size = new System.Drawing.Size(80, 16);
            this.IntervalCheckBox.TabIndex = 11;
            this.IntervalCheckBox.Text = "インターバル";
            this.IntervalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimerCheckBox
            // 
            this.TimerCheckBox.AutoSize = true;
            this.TimerCheckBox.Location = new System.Drawing.Point(15, 104);
            this.TimerCheckBox.Name = "TimerCheckBox";
            this.TimerCheckBox.Size = new System.Drawing.Size(60, 16);
            this.TimerCheckBox.TabIndex = 10;
            this.TimerCheckBox.Text = "タイマー";
            this.TimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "リポジトリ";
            // 
            // RepositoryTextBox
            // 
            this.RepositoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.RepositoryTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RepositoryTextBox.Location = new System.Drawing.Point(81, 79);
            this.RepositoryTextBox.Name = "RepositoryTextBox";
            this.RepositoryTextBox.ReadOnly = true;
            this.RepositoryTextBox.Size = new System.Drawing.Size(666, 19);
            this.RepositoryTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "ログフォルダ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "作業フォルダ";
            // 
            // ProjectFolderTextBox
            // 
            this.ProjectFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectFolderTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProjectFolderTextBox.Location = new System.Drawing.Point(82, 29);
            this.ProjectFolderTextBox.Name = "ProjectFolderTextBox";
            this.ProjectFolderTextBox.Size = new System.Drawing.Size(638, 19);
            this.ProjectFolderTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "名前";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.NameTextBox.Location = new System.Drawing.Point(82, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(310, 19);
            this.NameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 30);
            this.panel1.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OKButton.Location = new System.Drawing.Point(342, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CommandButton
            // 
            this.CommandButton.Location = new System.Drawing.Point(12, 6);
            this.CommandButton.Name = "CommandButton";
            this.CommandButton.Size = new System.Drawing.Size(124, 41);
            this.CommandButton.TabIndex = 17;
            this.CommandButton.Text = "新しいコマンド...";
            this.CommandButton.UseVisualStyleBackColor = true;
            this.CommandButton.Click += new System.EventHandler(this.CommandButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CommandTextBox);
            this.panel2.Controls.Add(this.CommandComboBox);
            this.panel2.Controls.Add(this.CommandButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 53);
            this.panel2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "説明";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "コマンド名";
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandTextBox.Location = new System.Drawing.Point(322, 5);
            this.CommandTextBox.Multiline = true;
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.ReadOnly = true;
            this.CommandTextBox.Size = new System.Drawing.Size(425, 40);
            this.CommandTextBox.TabIndex = 21;
            // 
            // CommandComboBox
            // 
            this.CommandComboBox.FormattingEnabled = true;
            this.CommandComboBox.Location = new System.Drawing.Point(142, 25);
            this.CommandComboBox.Name = "CommandComboBox";
            this.CommandComboBox.Size = new System.Drawing.Size(173, 20);
            this.CommandComboBox.TabIndex = 19;
            this.CommandComboBox.SelectedIndexChanged += new System.EventHandler(this.CommandComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "英数フォルダ名";
            // 
            // ExportFolderTextBox
            // 
            this.ExportFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportFolderTextBox.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.ExportFolderTextBox.Location = new System.Drawing.Point(485, 4);
            this.ExportFolderTextBox.Name = "ExportFolderTextBox";
            this.ExportFolderTextBox.Size = new System.Drawing.Size(262, 19);
            this.ExportFolderTextBox.TabIndex = 17;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.statusStrip1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandDataBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView CommandListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox IntervalCheckBox;
        private System.Windows.Forms.CheckBox TimerCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RepositoryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProjectFolderTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LogFolderComboBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource commandDataBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn param1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn param2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExportFolderTextBox;
    }
}