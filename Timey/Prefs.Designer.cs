namespace WindowsFormsApplication1
{
    partial class Prefs
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkStartWindows = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPauseMin = new System.Windows.Forms.TextBox();
            this.chkInactivity = new System.Windows.Forms.CheckBox();
            this.chkReminder = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemindMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkOK = new System.Windows.Forms.Button();
            this.chkCancel = new System.Windows.Forms.Button();
            this.txtFreshAcct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkStartWindows);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPauseMin);
            this.groupBox2.Controls.Add(this.chkInactivity);
            this.groupBox2.Controls.Add(this.chkReminder);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRemindMin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(280, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 143);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taskbar and Reminders";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkStartWindows
            // 
            this.chkStartWindows.AutoSize = true;
            this.chkStartWindows.Location = new System.Drawing.Point(15, 105);
            this.chkStartWindows.Name = "chkStartWindows";
            this.chkStartWindows.Size = new System.Drawing.Size(186, 17);
            this.chkStartWindows.TabIndex = 2;
            this.chkStartWindows.Text = "Start program on Windows startup";
            this.chkStartWindows.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "minutes of inactivity";
            // 
            // txtPauseMin
            // 
            this.txtPauseMin.Location = new System.Drawing.Point(117, 68);
            this.txtPauseMin.Name = "txtPauseMin";
            this.txtPauseMin.Size = new System.Drawing.Size(20, 20);
            this.txtPauseMin.TabIndex = 5;
            this.txtPauseMin.TabStop = false;
            this.txtPauseMin.Text = "5";
            // 
            // chkInactivity
            // 
            this.chkInactivity.AutoSize = true;
            this.chkInactivity.Checked = true;
            this.chkInactivity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInactivity.Location = new System.Drawing.Point(15, 70);
            this.chkInactivity.Name = "chkInactivity";
            this.chkInactivity.Size = new System.Drawing.Size(105, 17);
            this.chkInactivity.TabIndex = 1;
            this.chkInactivity.Text = "Pause timer after";
            this.chkInactivity.UseVisualStyleBackColor = true;
            // 
            // chkReminder
            // 
            this.chkReminder.AutoSize = true;
            this.chkReminder.Checked = true;
            this.chkReminder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReminder.Location = new System.Drawing.Point(15, 35);
            this.chkReminder.Name = "chkReminder";
            this.chkReminder.Size = new System.Drawing.Size(166, 17);
            this.chkReminder.TabIndex = 0;
            this.chkReminder.Text = "Show an update popup every";
            this.chkReminder.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "minutes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRemindMin
            // 
            this.txtRemindMin.Location = new System.Drawing.Point(179, 33);
            this.txtRemindMin.Name = "txtRemindMin";
            this.txtRemindMin.Size = new System.Drawing.Size(20, 20);
            this.txtRemindMin.TabIndex = 1;
            this.txtRemindMin.TabStop = false;
            this.txtRemindMin.Text = "5";
            this.txtRemindMin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // chkOK
            // 
            this.chkOK.Location = new System.Drawing.Point(314, 175);
            this.chkOK.Name = "chkOK";
            this.chkOK.Size = new System.Drawing.Size(75, 25);
            this.chkOK.TabIndex = 3;
            this.chkOK.Text = "OK";
            this.chkOK.UseVisualStyleBackColor = true;
            this.chkOK.Click += new System.EventHandler(this.chkOK_Click);
            // 
            // chkCancel
            // 
            this.chkCancel.Location = new System.Drawing.Point(433, 175);
            this.chkCancel.Name = "chkCancel";
            this.chkCancel.Size = new System.Drawing.Size(75, 25);
            this.chkCancel.TabIndex = 4;
            this.chkCancel.Text = "Cancel";
            this.chkCancel.UseVisualStyleBackColor = true;
            this.chkCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFreshAcct
            // 
            this.txtFreshAcct.Location = new System.Drawing.Point(15, 30);
            this.txtFreshAcct.Name = "txtFreshAcct";
            this.txtFreshAcct.Size = new System.Drawing.Size(130, 20);
            this.txtFreshAcct.TabIndex = 0;
            this.txtFreshAcct.TabStop = false;
            this.txtFreshAcct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFreshAcct.TextChanged += new System.EventHandler(this.txtFreshAcct_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFreshAcct);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Freshbook Account Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = ".freshbooks.com";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtToken);
            this.groupBox3.Location = new System.Drawing.Point(10, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 120);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Authentication Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Get token from My Account -> Freshbooks API";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keep your Authentication Token secure!\r\n";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(15, 30);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(230, 20);
            this.txtToken.TabIndex = 0;
            this.txtToken.TabStop = false;
            this.txtToken.UseSystemPasswordChar = true;
            // 
            // Prefs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 220);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chkCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prefs";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Prefs_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemindMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPauseMin;
        private System.Windows.Forms.CheckBox chkInactivity;
        private System.Windows.Forms.CheckBox chkReminder;
        private System.Windows.Forms.Button chkOK;
        private System.Windows.Forms.Button chkCancel;
        private System.Windows.Forms.CheckBox chkStartWindows;
        private System.Windows.Forms.TextBox txtFreshAcct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label3;
    }
}