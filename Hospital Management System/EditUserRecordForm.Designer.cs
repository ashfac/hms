namespace HospitalManagementSystem
{
    partial class EditUserRecordForm
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
            this.gbUserParticulars = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.gbUserParticulars.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditUserFormUserParticulars
            // 
            this.gbUserParticulars.Controls.Add(this.txtCity);
            this.gbUserParticulars.Controls.Add(this.txtAddress);
            this.gbUserParticulars.Controls.Add(this.txtPhone);
            this.gbUserParticulars.Controls.Add(this.lblCity);
            this.gbUserParticulars.Controls.Add(this.lblAddress);
            this.gbUserParticulars.Controls.Add(this.lblPhone);
            this.gbUserParticulars.Controls.Add(this.lblPassword);
            this.gbUserParticulars.Controls.Add(this.txtPassword);
            this.gbUserParticulars.Controls.Add(this.txtFullName);
            this.gbUserParticulars.Controls.Add(this.lblGroup);
            this.gbUserParticulars.Controls.Add(this.cmbGroup);
            this.gbUserParticulars.Controls.Add(this.txtRetypePassword);
            this.gbUserParticulars.Controls.Add(this.txtDesignation);
            this.gbUserParticulars.Controls.Add(this.txtUsername);
            this.gbUserParticulars.Controls.Add(this.lblFullName);
            this.gbUserParticulars.Controls.Add(this.lblRetypePassword);
            this.gbUserParticulars.Controls.Add(this.lblDesignation);
            this.gbUserParticulars.Controls.Add(this.lblUsername);
            this.gbUserParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbUserParticulars.Location = new System.Drawing.Point(20, 20);
            this.gbUserParticulars.Name = "gbEditUserFormUserParticulars";
            this.gbUserParticulars.Size = new System.Drawing.Size(505, 350);
            this.gbUserParticulars.TabIndex = 0;
            this.gbUserParticulars.TabStop = false;
            this.gbUserParticulars.Text = "Edit User\'s Particulars";
            // 
            // lblEditUserFormPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(20, 77);
            this.lblPassword.Name = "lblEditUserFormPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtEditUserFormPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(170, 74);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtEditUserFormPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(300, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEditUserFormPassword_KeyDown);
            this.txtPassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtEditUserFormPassword_MouseDoubleClick);
            // 
            // txtEditUserFormFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(170, 171);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtEditUserFormFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 26);
            this.txtFullName.TabIndex = 4;
            // 
            // lblEditUserFormGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(20, 141);
            this.lblGroup.Name = "lblEditUserFormGroup";
            this.lblGroup.Size = new System.Drawing.Size(102, 20);
            this.lblGroup.TabIndex = 12;
            this.lblGroup.Text = "User Group";
            // 
            // cmbEditUserFormGroup
            // 
            this.cmbGroup.DisplayMember = "0";
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Items.AddRange(new object[] {
            "Administrator",
            "Doctor",
            "Receptionist"});
            this.cmbGroup.Location = new System.Drawing.Point(170, 137);
            this.cmbGroup.Name = "cmbEditUserFormGroup";
            this.cmbGroup.Size = new System.Drawing.Size(300, 28);
            this.cmbGroup.TabIndex = 3;
            // 
            // txtEditUserFormRetypePassword
            // 
            this.txtRetypePassword.Location = new System.Drawing.Point(170, 105);
            this.txtRetypePassword.MaxLength = 50;
            this.txtRetypePassword.Name = "txtEditUserFormRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.ReadOnly = true;
            this.txtRetypePassword.Size = new System.Drawing.Size(300, 26);
            this.txtRetypePassword.TabIndex = 2;
            this.txtRetypePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEditUserFormPassword_KeyDown);
            this.txtRetypePassword.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtEditUserFormPassword_MouseDoubleClick);
            // 
            // txtEditUserFormDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(170, 203);
            this.txtDesignation.MaxLength = 50;
            this.txtDesignation.Name = "txtEditUserFormDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(300, 26);
            this.txtDesignation.TabIndex = 5;
            // 
            // txtEditUserFormUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 42);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtEditUserFormUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(300, 26);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TabStop = false;
            // 
            // lblEditUserFormFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 173);
            this.lblFullName.Name = "lblEditUserFormFullName";
            this.lblFullName.Size = new System.Drawing.Size(89, 20);
            this.lblFullName.TabIndex = 13;
            this.lblFullName.Text = "Full Name";
            // 
            // lblEditUserFormRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(20, 109);
            this.lblRetypePassword.Name = "lblEditUserFormRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(148, 20);
            this.lblRetypePassword.TabIndex = 11;
            this.lblRetypePassword.Text = "Retype Password";
            // 
            // lblEditUserFormDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(20, 205);
            this.lblDesignation.Name = "lblEditUserFormDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(105, 20);
            this.lblDesignation.TabIndex = 14;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEditUserFormUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 45);
            this.lblUsername.Name = "lblEditUserFormUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // btnEditUserFormCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(290, 390);
            this.btnCancel.Name = "btnEditUserFormCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditUserFormUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(110, 390);
            this.btnUpdate.Name = "btnEditUserFormUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnEditUserFormUpdate_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 237);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 269);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 301);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(170, 235);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(170, 267);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(170, 299);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 26);
            this.txtCity.TabIndex = 8;
            // 
            // EditUserRecordForm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(544, 446);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbUserParticulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "EditUserRecordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Edit User Record";
            this.Shown += new System.EventHandler(this.EditUserRecordForm_Shown);
            this.gbUserParticulars.ResumeLayout(false);
            this.gbUserParticulars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserParticulars;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
    }
}
