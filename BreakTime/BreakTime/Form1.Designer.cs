namespace BreakTime
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblColon = new System.Windows.Forms.Label();
            this.imgLock = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtHour = new System.Windows.Forms.MaskedTextBox();
            this.txtMinute = new System.Windows.Forms.MaskedTextBox();
            this.txtFraction = new System.Windows.Forms.MaskedTextBox();
            this.txtSecond = new System.Windows.Forms.MaskedTextBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.cboTasks = new System.Windows.Forms.ComboBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddMinutes = new System.Windows.Forms.ToolStripButton();
            this.cboSelectMinutes = new System.Windows.Forms.ToolStripComboBox();
            this.btnSubtractMinutes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnRoundUp = new System.Windows.Forms.ToolStripButton();
            this.cboRound = new System.Windows.Forms.ToolStripComboBox();
            this.btnRoundDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrefs = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMax = new System.Windows.Forms.ToolStripMenuItem();
            this.imgLog = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon.Location = new System.Drawing.Point(27, -8);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(23, 37);
            this.lblColon.TabIndex = 4;
            this.lblColon.Text = ":";
            // 
            // imgLock
            // 
            this.imgLock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLock.ImageStream")));
            this.imgLock.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLock.Images.SetKeyName(0, "Lock Lock.png");
            this.imgLock.Images.SetKeyName(1, "Lock Unlock.png");
            // 
            // txtHour
            // 
            this.txtHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHour.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtHour.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(-1, -7);
            this.txtHour.Mask = "00";
            this.txtHour.Name = "txtHour";
            this.txtHour.PromptChar = '-';
            this.txtHour.ReadOnly = true;
            this.txtHour.Size = new System.Drawing.Size(36, 36);
            this.txtHour.TabIndex = 2;
            this.txtHour.TabStop = false;
            this.txtHour.Text = "00";
            this.txtHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHour.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.txtHour, "Hour");
            this.txtHour.Leave += new System.EventHandler(this.txtHour_Leave);
            // 
            // txtMinute
            // 
            this.txtMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinute.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMinute.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMinute.Location = new System.Drawing.Point(39, -7);
            this.txtMinute.Mask = "00";
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.PromptChar = '-';
            this.txtMinute.ReadOnly = true;
            this.txtMinute.Size = new System.Drawing.Size(36, 36);
            this.txtMinute.TabIndex = 1;
            this.txtMinute.TabStop = false;
            this.txtMinute.Text = "00";
            this.txtMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinute.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.txtMinute, "Minute");
            this.txtMinute.TextChanged += new System.EventHandler(this.txtMinute_TextChanged);
            this.txtMinute.Leave += new System.EventHandler(this.txtMinute_Leave);
            // 
            // txtFraction
            // 
            this.txtFraction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFraction.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtFraction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFraction.Location = new System.Drawing.Point(12, 58);
            this.txtFraction.Mask = "00.00";
            this.txtFraction.Name = "txtFraction";
            this.txtFraction.PromptChar = '-';
            this.txtFraction.ReadOnly = true;
            this.txtFraction.Size = new System.Drawing.Size(42, 22);
            this.txtFraction.TabIndex = 11;
            this.txtFraction.TabStop = false;
            this.txtFraction.Text = "0000";
            this.txtFraction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFraction.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.txtFraction, "Fractional Hour");
            this.txtFraction.Leave += new System.EventHandler(this.txtFraction_Leave);
            // 
            // txtSecond
            // 
            this.txtSecond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecond.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(82, 5);
            this.txtSecond.Mask = "00";
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.PromptChar = '-';
            this.txtSecond.ReadOnly = true;
            this.txtSecond.Size = new System.Drawing.Size(19, 22);
            this.txtSecond.TabIndex = 12;
            this.txtSecond.TabStop = false;
            this.txtSecond.Text = "00";
            this.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSecond.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.txtSecond, "Seconds");
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            this.txtSecond.Leave += new System.EventHandler(this.txtSecond_Leave);
            // 
            // btnLock
            // 
            this.btnLock.ImageIndex = 1;
            this.btnLock.ImageList = this.imgLock;
            this.btnLock.Location = new System.Drawing.Point(90, 58);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(24, 24);
            this.btnLock.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnLock, "Edit Lock/Unlock");
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ImageIndex = 1;
            this.btnStart.ImageList = this.imageList2;
            this.btnStart.Location = new System.Drawing.Point(12, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = " Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnStart, "Start/Resume Timer");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "control-pause.png");
            this.imageList2.Images.SetKeyName(1, "control.png");
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(12, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = " Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Timer");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboTasks
            // 
            this.cboTasks.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTasks.FormattingEnabled = true;
            this.cboTasks.Location = new System.Drawing.Point(60, 79);
            this.cboTasks.Name = "cboTasks";
            this.cboTasks.Size = new System.Drawing.Size(150, 21);
            this.cboTasks.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboTasks, "Select Task");
            // 
            // cboProject
            // 
            this.cboProject.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(60, 52);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(150, 21);
            this.cboProject.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboProject, "Select Project");
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // cboClient
            // 
            this.cboClient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(60, 25);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(150, 21);
            this.cboClient.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cboClient, "Sort Projects by Client");
            this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(122, 178);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 28);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh Project List");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(15, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 28);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = " Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSubmit, "Submit Time Entry");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlTimer);
            this.groupBox1.Controls.Add(this.txtFraction);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnLock);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 175);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // pnlTimer
            // 
            this.pnlTimer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTimer.Controls.Add(this.txtSecond);
            this.pnlTimer.Controls.Add(this.txtMinute);
            this.pnlTimer.Controls.Add(this.lblColon2);
            this.pnlTimer.Controls.Add(this.txtHour);
            this.pnlTimer.Controls.Add(this.lblColon);
            this.pnlTimer.Location = new System.Drawing.Point(10, 25);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(104, 29);
            this.pnlTimer.TabIndex = 12;
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColon2.Location = new System.Drawing.Point(71, 4);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(14, 21);
            this.lblColon2.TabIndex = 13;
            this.lblColon2.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboTasks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboProject);
            this.groupBox2.Controls.Add(this.cboClient);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(150, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Project";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(61, 106);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(149, 56);
            this.txtNotes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnAddMinutes,
            this.cboSelectMinutes,
            this.btnSubtractMinutes,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btnRoundUp,
            this.cboRound,
            this.btnRoundDown,
            this.toolStripSeparator2,
            this.btnPrefs});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(389, 27);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 20);
            this.toolStripLabel1.Text = "Add:";
            // 
            // btnAddMinutes
            // 
            this.btnAddMinutes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddMinutes.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMinutes.Image")));
            this.btnAddMinutes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMinutes.Name = "btnAddMinutes";
            this.btnAddMinutes.Size = new System.Drawing.Size(23, 20);
            this.btnAddMinutes.Text = "toolStripButton2";
            this.btnAddMinutes.ToolTipText = "Add Minutes";
            this.btnAddMinutes.Click += new System.EventHandler(this.btnAddMinutes_Click);
            // 
            // cboSelectMinutes
            // 
            this.cboSelectMinutes.AutoSize = false;
            this.cboSelectMinutes.DropDownWidth = 20;
            this.cboSelectMinutes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectMinutes.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "30",
            "60"});
            this.cboSelectMinutes.Name = "cboSelectMinutes";
            this.cboSelectMinutes.Size = new System.Drawing.Size(35, 21);
            this.cboSelectMinutes.Text = "5";
            this.cboSelectMinutes.TextChanged += new System.EventHandler(this.cboSelectMinutes_TextChanged);
            // 
            // btnSubtractMinutes
            // 
            this.btnSubtractMinutes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSubtractMinutes.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtractMinutes.Image")));
            this.btnSubtractMinutes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSubtractMinutes.Name = "btnSubtractMinutes";
            this.btnSubtractMinutes.Size = new System.Drawing.Size(23, 20);
            this.btnSubtractMinutes.Text = "toolStripButton3";
            this.btnSubtractMinutes.ToolTipText = "Subtract Minutes";
            this.btnSubtractMinutes.Click += new System.EventHandler(this.btnSubtractMinutes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(45, 20);
            this.toolStripLabel2.Text = "Round:";
            // 
            // btnRoundUp
            // 
            this.btnRoundUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRoundUp.Image = ((System.Drawing.Image)(resources.GetObject("btnRoundUp.Image")));
            this.btnRoundUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRoundUp.Name = "btnRoundUp";
            this.btnRoundUp.Size = new System.Drawing.Size(23, 20);
            this.btnRoundUp.Text = "Round Up";
            this.btnRoundUp.Click += new System.EventHandler(this.btnRoundUp_Click);
            // 
            // cboRound
            // 
            this.cboRound.AutoSize = false;
            this.cboRound.DropDownWidth = 20;
            this.cboRound.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "60"});
            this.cboRound.Name = "cboRound";
            this.cboRound.Size = new System.Drawing.Size(35, 23);
            this.cboRound.Text = "5";
            // 
            // btnRoundDown
            // 
            this.btnRoundDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRoundDown.Image = ((System.Drawing.Image)(resources.GetObject("btnRoundDown.Image")));
            this.btnRoundDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRoundDown.Name = "btnRoundDown";
            this.btnRoundDown.Size = new System.Drawing.Size(23, 20);
            this.btnRoundDown.Text = "Round Down";
            this.btnRoundDown.Click += new System.EventHandler(this.btnRoundDown_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btnPrefs
            // 
            this.btnPrefs.Image = ((System.Drawing.Image)(resources.GetObject("btnPrefs.Image")));
            this.btnPrefs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrefs.Name = "btnPrefs";
            this.btnPrefs.Size = new System.Drawing.Size(91, 20);
            this.btnPrefs.Text = "Preferences:";
            this.btnPrefs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrefs.Click += new System.EventHandler(this.btnPrefs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 274);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(389, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(39, 13);
            this.statusLbl.Text = "Status";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Break Time!";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuMax});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(133, 22);
            this.menuStart.Text = "Start Timer";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menuMax
            // 
            this.menuMax.Name = "menuMax";
            this.menuMax.Size = new System.Drawing.Size(133, 22);
            this.menuMax.Text = "Show/Hide";
            this.menuMax.Click += new System.EventHandler(this.menuMax_Click);
            // 
            // imgLog
            // 
            this.imgLog.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLog.ImageStream")));
            this.imgLog.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLog.Images.SetKeyName(0, "user-green.png");
            this.imgLog.Images.SetKeyName(1, "user-silhouette.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 297);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Break Time! - Project Task Timer for Freshbooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.ImageList imgLock;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtMinute;
        private System.Windows.Forms.MaskedTextBox txtHour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.MaskedTextBox txtFraction;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrefs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox txtSecond;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.ToolStripButton btnAddMinutes;
        private System.Windows.Forms.ToolStripButton btnSubtractMinutes;
        private System.Windows.Forms.ToolStripComboBox cboSelectMinutes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnRoundUp;
        private System.Windows.Forms.ToolStripComboBox cboRound;
        private System.Windows.Forms.ToolStripButton btnRoundDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTasks;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imgLog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuMax;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSubmit;
    }
}

