namespace HospitalManagementSystem
{
    partial class AddOutPatientItemForm
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
            this.gbItemParticulars = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtServiceCharges = new System.Windows.Forms.TextBox();
            this.lblServiceCharges = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbItemParticulars.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbItemParticulars
            // 
            this.gbItemParticulars.Controls.Add(this.txtDate);
            this.gbItemParticulars.Controls.Add(this.lblDate);
            this.gbItemParticulars.Controls.Add(this.txtDescription);
            this.gbItemParticulars.Controls.Add(this.txtCode);
            this.gbItemParticulars.Controls.Add(this.lblDescription);
            this.gbItemParticulars.Controls.Add(this.lblCode);
            this.gbItemParticulars.Controls.Add(this.txtServiceCharges);
            this.gbItemParticulars.Controls.Add(this.lblServiceCharges);
            this.gbItemParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbItemParticulars.Location = new System.Drawing.Point(20, 20);
            this.gbItemParticulars.Name = "gbItemParticulars";
            this.gbItemParticulars.Size = new System.Drawing.Size(455, 186);
            this.gbItemParticulars.TabIndex = 0;
            this.gbItemParticulars.TabStop = false;
            this.gbItemParticulars.Text = "Enter Expense Item\'s particulars";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(161, 106);
            this.txtDate.MaxLength = 50;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(259, 26);
            this.txtDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 109);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(161, 74);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(259, 26);
            this.txtDescription.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(161, 42);
            this.txtCode.MaxLength = 50;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(259, 26);
            this.txtCode.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 77);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(21, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(92, 20);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Item Code";
            // 
            // txtServiceCharges
            // 
            this.txtServiceCharges.Location = new System.Drawing.Point(161, 138);
            this.txtServiceCharges.MaxLength = 50;
            this.txtServiceCharges.Name = "txtServiceCharges";
            this.txtServiceCharges.Size = new System.Drawing.Size(259, 26);
            this.txtServiceCharges.TabIndex = 3;
            // 
            // lblServiceCharges
            // 
            this.lblServiceCharges.AutoSize = true;
            this.lblServiceCharges.Location = new System.Drawing.Point(20, 141);
            this.lblServiceCharges.Name = "lblServiceCharges";
            this.lblServiceCharges.Size = new System.Drawing.Size(140, 20);
            this.lblServiceCharges.TabIndex = 7;
            this.lblServiceCharges.Text = "Service Charges";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(114, 220);
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
            this.btnCancel.Location = new System.Drawing.Point(254, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddOutPatientItemForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(488, 274);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbItemParticulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOutPatientItemForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Add New Item";
            this.Shown += new System.EventHandler(this.AddOutPatientItemForm_Shown);
            this.gbItemParticulars.ResumeLayout(false);
            this.gbItemParticulars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItemParticulars;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtServiceCharges;
        private System.Windows.Forms.Label lblServiceCharges;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}