namespace HospitalManagementSystem
{
    partial class MainForm
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.lblMessageBar = new System.Windows.Forms.Label();
            this.pnlMessageBar = new System.Windows.Forms.Panel();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.btnChangeDatabase = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.pnlMessageBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLogin.Controls.Add(this.btnChangeDatabase);
            this.gbLogin.Controls.Add(this.txtLoginPassword);
            this.gbLogin.Controls.Add(this.txtLoginUserName);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.lblLoginPassword);
            this.gbLogin.Controls.Add(this.lblLoginUserName);
            this.gbLogin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(99, 103);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(450, 220);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.Location = new System.Drawing.Point(135, 98);
            this.txtLoginPassword.MaxLength = 50;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(270, 24);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.WordWrap = false;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Location = new System.Drawing.Point(135, 53);
            this.txtLoginUserName.MaxLength = 50;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(270, 24);
            this.txtLoginUserName.TabIndex = 0;
            this.txtLoginUserName.WordWrap = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(95, 155);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLoginClick);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(30, 101);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(84, 17);
            this.lblLoginPassword.TabIndex = 5;
            this.lblLoginPassword.Text = "Password";
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Location = new System.Drawing.Point(30, 56);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(91, 17);
            this.lblLoginUserName.TabIndex = 4;
            this.lblLoginUserName.Text = "User Name";
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.LightGray;
            this.pnlStatusBar.Controls.Add(this.lblSystemTime);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.ForeColor = System.Drawing.Color.Black;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 423);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(632, 30);
            this.pnlStatusBar.TabIndex = 2;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSystemTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblSystemTime.Location = new System.Drawing.Point(229, 5);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(400, 17);
            this.lblSystemTime.TabIndex = 0;
            this.lblSystemTime.Text = "Wednesday, December 09, 2009  12:23:34 AM";
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMessageBar
            // 
            this.lblMessageBar.AutoSize = true;
            this.lblMessageBar.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessageBar.ForeColor = System.Drawing.Color.Black;
            this.lblMessageBar.Location = new System.Drawing.Point(5, 5);
            this.lblMessageBar.Name = "lblMessageBar";
            this.lblMessageBar.Size = new System.Drawing.Size(331, 17);
            this.lblMessageBar.TabIndex = 0;
            this.lblMessageBar.Text = "Welcome to Hospital Management System";
            // 
            // pnlMessageBar
            // 
            this.pnlMessageBar.BackColor = System.Drawing.Color.LightGray;
            this.pnlMessageBar.Controls.Add(this.lblMessageBar);
            this.pnlMessageBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMessageBar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.pnlMessageBar.ForeColor = System.Drawing.Color.Black;
            this.pnlMessageBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMessageBar.Name = "pnlMessageBar";
            this.pnlMessageBar.Size = new System.Drawing.Size(632, 30);
            this.pnlMessageBar.TabIndex = 1;
            // 
            // ClockTimer
            // 
            this.ClockTimer.Enabled = true;
            this.ClockTimer.Interval = 10;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // btnChangeDatabase
            // 
            this.btnChangeDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeDatabase.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangeDatabase.Location = new System.Drawing.Point(235, 155);
            this.btnChangeDatabase.Name = "btnChangeDatabase";
            this.btnChangeDatabase.Size = new System.Drawing.Size(120, 40);
            this.btnChangeDatabase.TabIndex = 3;
            this.btnChangeDatabase.Text = "&Database";
            this.btnChangeDatabase.UseVisualStyleBackColor = true;
            this.btnChangeDatabase.Click += new System.EventHandler(this.btnChangeDatabase_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlMessageBar);
            this.Controls.Add(this.gbLogin);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Hospital Management System";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlMessageBar.ResumeLayout(false);
            this.pnlMessageBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblMessageBar;
        private System.Windows.Forms.Panel pnlMessageBar;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.Button btnChangeDatabase;
    }
}

