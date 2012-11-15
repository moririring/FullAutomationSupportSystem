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
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.param2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridVewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommandListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.ProjectPathButton = new System.Windows.Forms.Button();
            this.LogFolderTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectPathComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LogPathButton = new System.Windows.Forms.Button();
            this.ProjectFolderDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogPathComboBox = new System.Windows.Forms.ComboBox();
            this.LogNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RepositoryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CommandButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.CommandComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridVewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandDataBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogNumericUpDown)).BeginInit();
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
            this.panel3.Location = new System.Drawing.Point(0, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 191);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.param1DataGridViewTextBoxColumn,
            this.param2DataGridViewTextBoxColumn,
            this.Run});
            this.dataGridView1.ContextMenuStrip = this.dataGridVewContextMenuStrip;
            this.dataGridView1.DataSource = this.commandDataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(569, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // Checked
            // 
            this.Checked.DataPropertyName = "Checked";
            this.Checked.HeaderText = "ﾁｪｯｸ";
            this.Checked.Name = "Checked";
            this.Checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checked.Width = 55;
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
            // dataGridVewContextMenuStrip
            // 
            this.dataGridVewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteDToolStripMenuItem});
            this.dataGridVewContextMenuStrip.Name = "contextMenuStrip1";
            this.dataGridVewContextMenuStrip.Size = new System.Drawing.Size(133, 48);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.EditToolStripMenuItem.Text = "編集(&E)";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteDToolStripMenuItem
            // 
            this.DeleteDToolStripMenuItem.Name = "DeleteDToolStripMenuItem";
            this.DeleteDToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteDToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.DeleteDToolStripMenuItem.Text = "削除(&D)";
            this.DeleteDToolStripMenuItem.Click += new System.EventHandler(this.DeleteDToolStripMenuItem_Click);
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
            this.CommandListView.Size = new System.Drawing.Size(569, 187);
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
            this.panel6.Controls.Add(this.ProjectPathButton);
            this.panel6.Controls.Add(this.LogFolderTextBox);
            this.panel6.Controls.Add(this.NameTextBox);
            this.panel6.Controls.Add(this.ProjectPathComboBox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.LogPathButton);
            this.panel6.Controls.Add(this.ProjectFolderDeleteButton);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.LogPathComboBox);
            this.panel6.Controls.Add(this.LogNumericUpDown);
            this.panel6.Controls.Add(this.IntervalCheckBox);
            this.panel6.Controls.Add(this.TimerCheckBox);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.RepositoryTextBox);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(573, 150);
            this.panel6.TabIndex = 0;
            // 
            // ProjectPathButton
            // 
            this.ProjectPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathButton.AutoSize = true;
            this.ProjectPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectPathButton.Location = new System.Drawing.Point(504, 29);
            this.ProjectPathButton.Name = "ProjectPathButton";
            this.ProjectPathButton.Size = new System.Drawing.Size(21, 22);
            this.ProjectPathButton.TabIndex = 25;
            this.ProjectPathButton.Text = "...";
            this.ProjectPathButton.UseVisualStyleBackColor = true;
            this.ProjectPathButton.Click += new System.EventHandler(this.ProjectFolderButton_Click);
            // 
            // LogFolderTextBox
            // 
            this.LogFolderTextBox.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.LogFolderTextBox.Location = new System.Drawing.Point(82, 79);
            this.LogFolderTextBox.Name = "LogFolderTextBox";
            this.LogFolderTextBox.Size = new System.Drawing.Size(303, 19);
            this.LogFolderTextBox.TabIndex = 24;
            this.LogFolderTextBox.TextChanged += new System.EventHandler(this.CommandChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(82, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(303, 19);
            this.NameTextBox.TabIndex = 23;
            this.NameTextBox.TextChanged += new System.EventHandler(this.CommandChanged);
            // 
            // ProjectPathComboBox
            // 
            this.ProjectPathComboBox.AllowDrop = true;
            this.ProjectPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathComboBox.FormattingEnabled = true;
            this.ProjectPathComboBox.Location = new System.Drawing.Point(81, 29);
            this.ProjectPathComboBox.Name = "ProjectPathComboBox";
            this.ProjectPathComboBox.Size = new System.Drawing.Size(417, 20);
            this.ProjectPathComboBox.TabIndex = 20;
            this.ProjectPathComboBox.TextChanged += new System.EventHandler(this.CommandChanged);
            this.ProjectPathComboBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ProjectFolderComboBox_DragDrop);
            this.ProjectPathComboBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderComboBox_DragEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "ログフォルダ";
            // 
            // LogPathButton
            // 
            this.LogPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPathButton.AutoSize = true;
            this.LogPathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogPathButton.Location = new System.Drawing.Point(504, 51);
            this.LogPathButton.Name = "LogPathButton";
            this.LogPathButton.Size = new System.Drawing.Size(21, 22);
            this.LogPathButton.TabIndex = 16;
            this.LogPathButton.Text = "...";
            this.LogPathButton.UseVisualStyleBackColor = true;
            this.LogPathButton.Click += new System.EventHandler(this.LogFolderButton_Click);
            // 
            // ProjectFolderDeleteButton
            // 
            this.ProjectFolderDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectFolderDeleteButton.AutoSize = true;
            this.ProjectFolderDeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectFolderDeleteButton.Location = new System.Drawing.Point(486, 2);
            this.ProjectFolderDeleteButton.Name = "ProjectFolderDeleteButton";
            this.ProjectFolderDeleteButton.Size = new System.Drawing.Size(39, 22);
            this.ProjectFolderDeleteButton.TabIndex = 15;
            this.ProjectFolderDeleteButton.Text = "削除";
            this.ProjectFolderDeleteButton.UseVisualStyleBackColor = true;
            this.ProjectFolderDeleteButton.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "ログ番号";
            // 
            // LogPathComboBox
            // 
            this.LogPathComboBox.AllowDrop = true;
            this.LogPathComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPathComboBox.FormattingEnabled = true;
            this.LogPathComboBox.Location = new System.Drawing.Point(81, 53);
            this.LogPathComboBox.Name = "LogPathComboBox";
            this.LogPathComboBox.Size = new System.Drawing.Size(417, 20);
            this.LogPathComboBox.TabIndex = 13;
            this.LogPathComboBox.SelectedIndexChanged += new System.EventHandler(this.LogPathComboBox_SelectedIndexChanged);
            this.LogPathComboBox.TextChanged += new System.EventHandler(this.CommandChanged);
            this.LogPathComboBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LogFolderComboBox_DragDrop);
            this.LogPathComboBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FolderComboBox_DragEnter);
            // 
            // LogNumericUpDown
            // 
            this.LogNumericUpDown.Location = new System.Drawing.Point(444, 79);
            this.LogNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.LogNumericUpDown.Name = "LogNumericUpDown";
            this.LogNumericUpDown.Size = new System.Drawing.Size(49, 19);
            this.LogNumericUpDown.TabIndex = 12;
            this.LogNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IntervalCheckBox
            // 
            this.IntervalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalCheckBox.AutoSize = true;
            this.IntervalCheckBox.Location = new System.Drawing.Point(445, 130);
            this.IntervalCheckBox.Name = "IntervalCheckBox";
            this.IntervalCheckBox.Size = new System.Drawing.Size(80, 16);
            this.IntervalCheckBox.TabIndex = 11;
            this.IntervalCheckBox.Text = "インターバル";
            this.IntervalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimerCheckBox
            // 
            this.TimerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerCheckBox.AutoSize = true;
            this.TimerCheckBox.Location = new System.Drawing.Point(379, 130);
            this.TimerCheckBox.Name = "TimerCheckBox";
            this.TimerCheckBox.Size = new System.Drawing.Size(60, 16);
            this.TimerCheckBox.TabIndex = 10;
            this.TimerCheckBox.Text = "タイマー";
            this.TimerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 108);
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
            this.RepositoryTextBox.Location = new System.Drawing.Point(81, 105);
            this.RepositoryTextBox.Name = "RepositoryTextBox";
            this.RepositoryTextBox.ReadOnly = true;
            this.RepositoryTextBox.Size = new System.Drawing.Size(478, 19);
            this.RepositoryTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "ログパス";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "作業パス";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "名前";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 30);
            this.panel1.TabIndex = 12;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(248, 3);
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
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
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
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 53);
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
            this.CommandTextBox.Size = new System.Drawing.Size(237, 40);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 416);
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
            this.dataGridVewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.commandDataBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LogPathComboBox;
        private System.Windows.Forms.NumericUpDown LogNumericUpDown;
        private System.Windows.Forms.Button LogPathButton;
        private System.Windows.Forms.Button ProjectFolderDeleteButton;
        private System.Windows.Forms.Button CommandButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CommandComboBox;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource commandDataBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProjectPathComboBox;
        private System.Windows.Forms.TextBox LogFolderTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ProjectPathButton;
        private System.Windows.Forms.ContextMenuStrip dataGridVewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn param1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn param2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
    }
}