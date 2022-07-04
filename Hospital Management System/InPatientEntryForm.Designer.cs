namespace HospitalManagementSystem
{
    partial class InPatientEntryForm
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
            this.gbPatientParticulars = new System.Windows.Forms.GroupBox();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.txtPMRN = new System.Windows.Forms.TextBox();
            this.lblPMRN = new System.Windows.Forms.Label();
            this.lblServiceCharges = new System.Windows.Forms.Label();
            this.txtServiceCharges = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbPatientParticulars.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPatientParticulars
            // 
            this.gbPatientParticulars.Controls.Add(this.txtTime);
            this.gbPatientParticulars.Controls.Add(this.txtDate);
            this.gbPatientParticulars.Controls.Add(this.lblTime);
            this.gbPatientParticulars.Controls.Add(this.lblDate);
            this.gbPatientParticulars.Controls.Add(this.txtAppointmentID);
            this.gbPatientParticulars.Controls.Add(this.lblAppointmentID);
            this.gbPatientParticulars.Controls.Add(this.txtPMRN);
            this.gbPatientParticulars.Controls.Add(this.lblPMRN);
            this.gbPatientParticulars.Controls.Add(this.lblServiceCharges);
            this.gbPatientParticulars.Controls.Add(this.txtServiceCharges);
            this.gbPatientParticulars.Controls.Add(this.txtDoctorName);
            this.gbPatientParticulars.Controls.Add(this.txtDescription);
            this.gbPatientParticulars.Controls.Add(this.txtName);
            this.gbPatientParticulars.Controls.Add(this.lblDoctorName);
            this.gbPatientParticulars.Controls.Add(this.lblDescription);
            this.gbPatientParticulars.Controls.Add(this.lblName);
            this.gbPatientParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbPatientParticulars.Location = new System.Drawing.Point(20, 20);
            this.gbPatientParticulars.Name = "gbPatientParticulars";
            this.gbPatientParticulars.Size = new System.Drawing.Size(455, 314);
            this.gbPatientParticulars.TabIndex = 0;
            this.gbPatientParticulars.TabStop = false;
            this.gbPatientParticulars.Text = "Enter patient\'s particulars";
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(161, 106);
            this.txtAppointmentID.MaxLength = 50;
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(259, 26);
            this.txtAppointmentID.TabIndex = 2;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Location = new System.Drawing.Point(20, 109);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(135, 20);
            this.lblAppointmentID.TabIndex = 10;
            this.lblAppointmentID.Text = "Appointment ID";
            // 
            // txtPMRN
            // 
            this.txtPMRN.Location = new System.Drawing.Point(161, 138);
            this.txtPMRN.MaxLength = 50;
            this.txtPMRN.Name = "txtPMRN";
            this.txtPMRN.ReadOnly = true;
            this.txtPMRN.Size = new System.Drawing.Size(259, 26);
            this.txtPMRN.TabIndex = 3;
            // 
            // lblPMRN
            // 
            this.lblPMRN.AutoSize = true;
            this.lblPMRN.Location = new System.Drawing.Point(20, 141);
            this.lblPMRN.Name = "lblPMRN";
            this.lblPMRN.Size = new System.Drawing.Size(59, 20);
            this.lblPMRN.TabIndex = 11;
            this.lblPMRN.Text = "PMRN";
            // 
            // lblServiceCharges
            // 
            this.lblServiceCharges.AutoSize = true;
            this.lblServiceCharges.Location = new System.Drawing.Point(20, 269);
            this.lblServiceCharges.Name = "lblServiceCharges";
            this.lblServiceCharges.Size = new System.Drawing.Size(140, 20);
            this.lblServiceCharges.TabIndex = 15;
            this.lblServiceCharges.Text = "Service Charges";
            // 
            // txtServiceCharges
            // 
            this.txtServiceCharges.Location = new System.Drawing.Point(161, 266);
            this.txtServiceCharges.MaxLength = 50;
            this.txtServiceCharges.Name = "txtServiceCharges";
            this.txtServiceCharges.Size = new System.Drawing.Size(259, 26);
            this.txtServiceCharges.TabIndex = 7;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(161, 234);
            this.txtDoctorName.MaxLength = 50;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(259, 26);
            this.txtDoctorName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(161, 202);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 26);
            this.txtDescription.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 170);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(259, 26);
            this.txtName.TabIndex = 4;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(20, 237);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(127, 20);
            this.lblDoctorName.TabIndex = 14;
            this.lblDoctorName.Text = "Doctor\'s Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 173);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(114, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(254, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(161, 74);
            this.txtTime.MaxLength = 50;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(259, 26);
            this.txtTime.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(161, 42);
            this.txtDate.MaxLength = 50;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(259, 26);
            this.txtDate.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 77);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 20);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // InPatientEntryForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(490, 412);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbPatientParticulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InPatientEntryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - In-Patient Entry";
            this.Shown += new System.EventHandler(this.InPatientEntryForm_Shown);
            this.gbPatientParticulars.ResumeLayout(false);
            this.gbPatientParticulars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPatientParticulars;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.TextBox txtPMRN;
        private System.Windows.Forms.Label lblPMRN;
        private System.Windows.Forms.Label lblServiceCharges;
        private System.Windows.Forms.TextBox txtServiceCharges;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
    }
}