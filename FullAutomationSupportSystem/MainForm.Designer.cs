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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpanNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpanCheckBox = new System.Windows.Forms.CheckBox();
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.TimerCheckBox = new System.Windows.Forms.CheckBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タスクTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskEditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TaskCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectPaths = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProjectPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.LogPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Log = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Run = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridVewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OptionButton = new System.Windows.Forms.Button();
            this.NewTaskButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SpanTextBox = new System.Windows.Forms.TextBox();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Span = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandListDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerstionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SpanNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataGridVewContextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandListDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "←";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "←";
            // 
            // SpanNumericUpDown
            // 
            this.SpanNumericUpDown.Location = new System.Drawing.Point(123, 34);
            this.SpanNumericUpDown.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.SpanNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpanNumericUpDown.Name = "SpanNumericUpDown";
            this.SpanNumericUpDown.Size = new System.Drawing.Size(52, 19);
            this.SpanNumericUpDown.TabIndex = 6;
            this.SpanNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpanNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpanNumericUpDown.ValueChanged += new System.EventHandler(this.SpanNumericUpDown_ValueChanged);
            // 
            // SpanCheckBox
            // 
            this.SpanCheckBox.AutoSize = true;
            this.SpanCheckBox.Location = new System.Drawing.Point(33, 35);
            this.SpanCheckBox.Name = "SpanCheckBox";
            this.SpanCheckBox.Size = new System.Drawing.Size(76, 16);
            this.SpanCheckBox.TabIndex = 5;
            this.SpanCheckBox.Text = "スパン実行";
            this.SpanCheckBox.UseVisualStyleBackColor = true;
            this.SpanCheckBox.CheckedChanged += new System.EventHandler(this.SpanCheckBox_CheckedChanged);
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Location = new System.Drawing.Point(231, 11);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.ReadOnly = true;
            this.TimerTextBox.Size = new System.Drawing.Size(48, 19);
            this.TimerTextBox.TabIndex = 4;
            this.TimerTextBox.Text = "--:--:--";
            this.TimerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TimerCheckBox
            // 
            this.TimerCheckBox.AutoSize = true;
            this.TimerCheckBox.Location = new System.Drawing.Point(33, 13);
            this.TimerCheckBox.Name = "TimerCheckBox";
            this.TimerCheckBox.Size = new System.Drawing.Size(84, 16);
            this.TimerCheckBox.TabIndex = 1;
            this.TimerCheckBox.Text = "タイマー実行";
            this.TimerCheckBox.UseVisualStyleBackColor = true;
            this.TimerCheckBox.CheckedChanged += new System.EventHandler(this.TimerCheckBox_CheckedChanged);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(3, 14);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(124, 41);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "実行";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(761, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.タスクTToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTaskToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator3,
            this.SaveToolStripMenuItem,
            this.NameSaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // AddTaskToolStripMenuItem
            // 
            this.AddTaskToolStripMenuItem.Name = "AddTaskToolStripMenuItem";
            this.AddTaskToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.AddTaskToolStripMenuItem.Text = "新しいタスク(&T)...";
            this.AddTaskToolStripMenuItem.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.OpenFileToolStripMenuItem.Text = "ファイルを開く(&O)...";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CloseToolStripMenuItem.Text = "閉じる(&C)";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.SaveToolStripMenuItem.Text = "保存(&S)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // NameSaveToolStripMenuItem
            // 
            this.NameSaveToolStripMenuItem.Name = "NameSaveToolStripMenuItem";
            this.NameSaveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NameSaveToolStripMenuItem.Text = "名前を付けて保存(&A)...";
            this.NameSaveToolStripMenuItem.Click += new System.EventHandler(this.NameSaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ExitToolStripMenuItem.Text = "終了(&X)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // タスクTToolStripMenuItem
            // 
            this.タスクTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskEditToolStripMenuItem1,
            this.TaskDeleteToolStripMenuItem1,
            this.toolStripSeparator4,
            this.TaskCopyToolStripMenuItem});
            this.タスクTToolStripMenuItem.Name = "タスクTToolStripMenuItem";
            this.タスクTToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.タスクTToolStripMenuItem.Text = "タスク(&T)";
            // 
            // TaskEditToolStripMenuItem1
            // 
            this.TaskEditToolStripMenuItem1.Name = "TaskEditToolStripMenuItem1";
            this.TaskEditToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TaskEditToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.TaskEditToolStripMenuItem1.Text = "編集(&E)";
            this.TaskEditToolStripMenuItem1.Click += new System.EventHandler(this.TaskEditToolStripMenuItem1_Click);
            // 
            // TaskDeleteToolStripMenuItem1
            // 
            this.TaskDeleteToolStripMenuItem1.Name = "TaskDeleteToolStripMenuItem1";
            this.TaskDeleteToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.TaskDeleteToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.TaskDeleteToolStripMenuItem1.Text = "削除(&D)";
            this.TaskDeleteToolStripMenuItem1.Click += new System.EventHandler(this.TaskDeleteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(148, 6);
            // 
            // TaskCopyToolStripMenuItem
            // 
            this.TaskCopyToolStripMenuItem.Name = "TaskCopyToolStripMenuItem";
            this.TaskCopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.TaskCopyToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.TaskCopyToolStripMenuItem.Text = "コピー(&C)";
            this.TaskCopyToolStripMenuItem.Click += new System.EventHandler(this.TaskCopyToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checked,
            this.dataGridViewTextBoxColumn1,
            this.LastRun,
            this.ProjectPaths,
            this.ProjectPath,
            this.LogPath,
            this.dataGridViewTextBoxColumn4,
            this.Timer,
            this.Span,
            this.Log,
            this.Run});
            this.dataGridView1.ContextMenuStrip = this.dataGridVewContextMenuStrip;
            this.dataGridView1.DataSource = this.taskDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(761, 217);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // LastRun
            // 
            this.LastRun.DataPropertyName = "LastRunTime";
            this.LastRun.HeaderText = "最終実行時間";
            this.LastRun.Name = "LastRun";
            this.LastRun.ReadOnly = true;
            this.LastRun.Width = 102;
            // 
            // ProjectPaths
            // 
            this.ProjectPaths.HeaderText = "プロジェクト";
            this.ProjectPaths.Name = "ProjectPaths";
            this.ProjectPaths.Visible = false;
            this.ProjectPaths.Width = 62;
            // 
            // ProjectPath
            // 
            this.ProjectPath.HeaderText = "作業パス";
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProjectPath.Width = 73;
            // 
            // LogPath
            // 
            this.LogPath.HeaderText = "ログパス";
            this.LogPath.Name = "LogPath";
            this.LogPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LogPath.Width = 67;
            // 
            // Log
            // 
            this.Log.HeaderText = "ログ";
            this.Log.Name = "Log";
            this.Log.Width = 29;
            // 
            // Run
            // 
            this.Run.HeaderText = "実行";
            this.Run.Name = "Run";
            this.Run.ReadOnly = true;
            this.Run.Width = 35;
            // 
            // dataGridVewContextMenuStrip
            // 
            this.dataGridVewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集EToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.dataGridVewContextMenuStrip.Name = "contextMenuStrip1";
            this.dataGridVewContextMenuStrip.Size = new System.Drawing.Size(111, 48);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            this.編集EToolStripMenuItem.Click += new System.EventHandler(this.TaskEditToolStripMenuItem1_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.TaskDeleteToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.OptionButton);
            this.panel1.Controls.Add(this.NewTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 58);
            this.panel1.TabIndex = 10;
            // 
            // OptionButton
            // 
            this.OptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionButton.Location = new System.Drawing.Point(623, 6);
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(124, 41);
            this.OptionButton.TabIndex = 2;
            this.OptionButton.Text = "オプション...";
            this.OptionButton.UseVisualStyleBackColor = true;
            this.OptionButton.Visible = false;
            // 
            // NewTaskButton
            // 
            this.NewTaskButton.Location = new System.Drawing.Point(3, 6);
            this.NewTaskButton.Name = "NewTaskButton";
            this.NewTaskButton.Size = new System.Drawing.Size(124, 41);
            this.NewTaskButton.TabIndex = 1;
            this.NewTaskButton.Text = "新しいタスク...";
            this.NewTaskButton.UseVisualStyleBackColor = true;
            this.NewTaskButton.Click += new System.EventHandler(this.AddTaskToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "fas";
            this.saveFileDialog1.Filter = "fasファイル|*.fas";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "fas";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "fasファイル|*.fas";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.RunButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 75);
            this.panel2.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimerCheckBox);
            this.groupBox1.Controls.Add(this.TimerDateTimePicker);
            this.groupBox1.Controls.Add(this.SpanNumericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SpanCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TimerTextBox);
            this.groupBox1.Controls.Add(this.SpanTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(133, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 54);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // TimerDateTimePicker
            // 
            this.TimerDateTimePicker.CustomFormat = "HH:mm:ss";
            this.TimerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimerDateTimePicker.Location = new System.Drawing.Point(123, 11);
            this.TimerDateTimePicker.Name = "TimerDateTimePicker";
            this.TimerDateTimePicker.ShowUpDown = true;
            this.TimerDateTimePicker.Size = new System.Drawing.Size(71, 19);
            this.TimerDateTimePicker.TabIndex = 13;
            this.TimerDateTimePicker.Value = new System.DateTime(2012, 10, 17, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "残り";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "残り";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "分";
            // 
            // SpanTextBox
            // 
            this.SpanTextBox.Location = new System.Drawing.Point(232, 33);
            this.SpanTextBox.Name = "SpanTextBox";
            this.SpanTextBox.ReadOnly = true;
            this.SpanTextBox.Size = new System.Drawing.Size(47, 19);
            this.SpanTextBox.TabIndex = 9;
            this.SpanTextBox.Text = "--:--:--";
            this.SpanTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Checked
            // 
            this.Checked.DataPropertyName = "Checked";
            this.Checked.HeaderText = "チェック";
            this.Checked.Name = "Checked";
            this.Checked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checked.Width = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "ﾌﾟﾛｾｽｸﾞﾙｰﾌﾟ名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Repository";
            this.dataGridViewTextBoxColumn4.HeaderText = "リポジトリ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // Timer
            // 
            this.Timer.DataPropertyName = "Timer";
            this.Timer.HeaderText = "タイマー";
            this.Timer.Name = "Timer";
            this.Timer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Timer.Width = 66;
            // 
            // Span
            // 
            this.Span.DataPropertyName = "Span";
            this.Span.HeaderText = "スパン";
            this.Span.Name = "Span";
            this.Span.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Span.Width = 58;
            // 
            // taskDataBindingSource
            // 
            this.taskDataBindingSource.DataSource = typeof(FullAutomationSupportSystem.TaskData);
            this.taskDataBindingSource.CurrentItemChanged += new System.EventHandler(this.taskDataBindingSource_CurrentItemChanged);
            // 
            // commandListDataBindingSource
            // 
            this.commandListDataBindingSource.DataSource = typeof(FullAutomationSupportSystem.CommandListData);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerstionToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // VerstionToolStripMenuItem
            // 
            this.VerstionToolStripMenuItem.Name = "VerstionToolStripMenuItem";
            this.VerstionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.VerstionToolStripMenuItem.Text = "バージョン情報(&A)";
            this.VerstionToolStripMenuItem.Click += new System.EventHandler(this.VerstionToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "フルタイムブラウニー - FullTimeBrownie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpanNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataGridVewContextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandListDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpanNumericUpDown;
        private System.Windows.Forms.CheckBox SpanCheckBox;
        private System.Windows.Forms.TextBox TimerTextBox;
        private System.Windows.Forms.CheckBox TimerCheckBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logFolderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repositoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn timerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn intervalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTaskToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewTaskButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NameSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource commandListDataBindingSource;
        private System.Windows.Forms.BindingSource taskDataBindingSource;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem タスクTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaskEditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TaskDeleteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip dataGridVewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SpanTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimerDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRun;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProjectPaths;
        private System.Windows.Forms.DataGridViewLinkColumn ProjectPath;
        private System.Windows.Forms.DataGridViewLinkColumn LogPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Timer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Span;
        private System.Windows.Forms.DataGridViewButtonColumn Log;
        private System.Windows.Forms.DataGridViewButtonColumn Run;
        private System.Windows.Forms.Button OptionButton;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerstionToolStripMenuItem;
    }
}