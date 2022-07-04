namespace HospitalManagementSystem
{
    partial class AddPatientForm
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbPatientParticulars = new System.Windows.Forms.GroupBox();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.txtPMRN = new System.Windows.Forms.TextBox();
            this.lblPMRN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbPatientParticulars.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 237);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 20);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 236);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "0";
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(120, 138);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 28);
            this.cmbGender.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 204);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 26);
            this.txtCity.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 172);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 106);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 141);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 205);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.Location = new System.Drawing.Point(86, 330);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(150, 40);
            this.btnAddPatient.TabIndex = 1;
            this.btnAddPatient.Text = "&Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatientFormAddPatient_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 173);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // gbPatientParticulars
            // 
            this.gbPatientParticulars.Controls.Add(this.txtRegistrationDate);
            this.gbPatientParticulars.Controls.Add(this.lblRegistrationDate);
            this.gbPatientParticulars.Controls.Add(this.txtPMRN);
            this.gbPatientParticulars.Controls.Add(this.lblPMRN);
            this.gbPatientParticulars.Controls.Add(this.lblPhone);
            this.gbPatientParticulars.Controls.Add(this.txtPhone);
            this.gbPatientParticulars.Controls.Add(this.cmbGender);
            this.gbPatientParticulars.Controls.Add(this.txtCity);
            this.gbPatientParticulars.Controls.Add(this.txtAddress);
            this.gbPatientParticulars.Controls.Add(this.txtName);
            this.gbPatientParticulars.Controls.Add(this.lblGender);
            this.gbPatientParticulars.Controls.Add(this.lblCity);
            this.gbPatientParticulars.Controls.Add(this.lblAddress);
            this.gbPatientParticulars.Controls.Add(this.lblName);
            this.gbPatientParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbPatientParticulars.Location = new System.Drawing.Point(20, 20);
            this.gbPatientParticulars.Name = "gbPatientParticulars";
            this.gbPatientParticulars.Size = new System.Drawing.Size(455, 290);
            this.gbPatientParticulars.TabIndex = 0;
            this.gbPatientParticulars.TabStop = false;
            this.gbPatientParticulars.Text = "Enter new patient\'s particulars";
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Location = new System.Drawing.Point(120, 42);
            this.txtRegistrationDate.MaxLength = 50;
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(300, 26);
            this.txtRegistrationDate.TabIndex = 0;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Location = new System.Drawing.Point(20, 45);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(91, 20);
            this.lblRegistrationDate.TabIndex = 7;
            this.lblRegistrationDate.Text = "Reg. Date";
            // 
            // txtPMRN
            // 
            this.txtPMRN.Location = new System.Drawing.Point(120, 74);
            this.txtPMRN.MaxLength = 50;
            this.txtPMRN.Name = "txtPMRN";
            this.txtPMRN.ReadOnly = true;
            this.txtPMRN.Size = new System.Drawing.Size(300, 26);
            this.txtPMRN.TabIndex = 1;
            // 
            // lblPMRN
            // 
            this.lblPMRN.AutoSize = true;
            this.lblPMRN.Location = new System.Drawing.Point(20, 77);
            this.lblPMRN.Name = "lblPMRN";
            this.lblPMRN.Size = new System.Drawing.Size(59, 20);
            this.lblPMRN.TabIndex = 8;
            this.lblPMRN.Text = "PMRN";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(256, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddPatientForm
            // 
            this.AcceptButton = this.btnAddPatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 386);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.gbPatientParticulars);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(500, 410);
            this.Name = "AddPatientForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Add New Patient Record";
            this.Shown += new System.EventHandler(this.AddPatientForm_Shown);
            this.gbPatientParticulars.ResumeLayout(false);
            this.gbPatientParticulars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbPatientParticulars;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPMRN;
        private System.Windows.Forms.TextBox txtPMRN;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.Label lblRegistrationDate;
    }
}