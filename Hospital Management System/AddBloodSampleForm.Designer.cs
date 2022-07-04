namespace HospitalManagementSystem
{
    partial class AddBloodSampleForm
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
            this.gbBloodSampleParticulars = new System.Windows.Forms.GroupBox();
            this.txtSampleID = new System.Windows.Forms.TextBox();
            this.lblSampleID = new System.Windows.Forms.Label();
            this.txtCollectionDate = new System.Windows.Forms.TextBox();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtBloodQuantity = new System.Windows.Forms.TextBox();
            this.lblDateOfCollection = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblBloodQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.gbBloodSampleParticulars.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBloodSampleParticulars
            // 
            this.gbBloodSampleParticulars.Controls.Add(this.txtSampleID);
            this.gbBloodSampleParticulars.Controls.Add(this.lblSampleID);
            this.gbBloodSampleParticulars.Controls.Add(this.txtCollectionDate);
            this.gbBloodSampleParticulars.Controls.Add(this.lblBloodGroup);
            this.gbBloodSampleParticulars.Controls.Add(this.cmbBloodGroup);
            this.gbBloodSampleParticulars.Controls.Add(this.txtExpiryDate);
            this.gbBloodSampleParticulars.Controls.Add(this.txtBloodQuantity);
            this.gbBloodSampleParticulars.Controls.Add(this.lblDateOfCollection);
            this.gbBloodSampleParticulars.Controls.Add(this.lblExpiryDate);
            this.gbBloodSampleParticulars.Controls.Add(this.lblBloodQuantity);
            this.gbBloodSampleParticulars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbBloodSampleParticulars.Location = new System.Drawing.Point(20, 20);
            this.gbBloodSampleParticulars.Name = "gbBloodSampleParticulars";
            this.gbBloodSampleParticulars.Size = new System.Drawing.Size(505, 220);
            this.gbBloodSampleParticulars.TabIndex = 1;
            this.gbBloodSampleParticulars.TabStop = false;
            this.gbBloodSampleParticulars.Text = "Enter new blood sample\'s particulars";
            // 
            // txtSampleID
            // 
            this.txtSampleID.Location = new System.Drawing.Point(170, 42);
            this.txtSampleID.MaxLength = 50;
            this.txtSampleID.Name = "txtSampleID";
            this.txtSampleID.ReadOnly = true;
            this.txtSampleID.Size = new System.Drawing.Size(300, 26);
            this.txtSampleID.TabIndex = 8;
            // 
            // lblSampleID
            // 
            this.lblSampleID.AutoSize = true;
            this.lblSampleID.Location = new System.Drawing.Point(20, 45);
            this.lblSampleID.Name = "lblSampleID";
            this.lblSampleID.Size = new System.Drawing.Size(88, 20);
            this.lblSampleID.TabIndex = 17;
            this.lblSampleID.Text = "SampleID";
            // 
            // txtCollectionDate
            // 
            this.txtCollectionDate.Location = new System.Drawing.Point(170, 138);
            this.txtCollectionDate.MaxLength = 50;
            this.txtCollectionDate.Name = "txtCollectionDate";
            this.txtCollectionDate.Size = new System.Drawing.Size(300, 26);
            this.txtCollectionDate.TabIndex = 2;
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Location = new System.Drawing.Point(20, 77);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(110, 20);
            this.lblBloodGroup.TabIndex = 9;
            this.lblBloodGroup.Text = "Blood Group";
            // 
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.DisplayMember = "0";
            this.cmbBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Items.AddRange(new object[] {
            "A +VE",
            "A -VE",
            "B +VE",
            "B -VE",
            "AB +VE",
            "AB -VE",
            "O +VE",
            "O -VE"});
            this.cmbBloodGroup.Location = new System.Drawing.Point(170, 74);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(300, 28);
            this.cmbBloodGroup.TabIndex = 0;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(170, 170);
            this.txtExpiryDate.MaxLength = 50;
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(300, 26);
            this.txtExpiryDate.TabIndex = 3;
            // 
            // txtBloodQuantity
            // 
            this.txtBloodQuantity.Location = new System.Drawing.Point(170, 106);
            this.txtBloodQuantity.MaxLength = 50;
            this.txtBloodQuantity.Name = "txtBloodQuantity";
            this.txtBloodQuantity.Size = new System.Drawing.Size(300, 26);
            this.txtBloodQuantity.TabIndex = 1;
            // 
            // lblDateOfCollection
            // 
            this.lblDateOfCollection.AutoSize = true;
            this.lblDateOfCollection.Location = new System.Drawing.Point(20, 141);
            this.lblDateOfCollection.Name = "lblDateOfCollection";
            this.lblDateOfCollection.Size = new System.Drawing.Size(132, 20);
            this.lblDateOfCollection.TabIndex = 11;
            this.lblDateOfCollection.Text = "Collection Date";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(20, 173);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(101, 20);
            this.lblExpiryDate.TabIndex = 12;
            this.lblExpiryDate.Text = "Expiry Date";
            // 
            // lblBloodQuantity
            // 
            this.lblBloodQuantity.AutoSize = true;
            this.lblBloodQuantity.Location = new System.Drawing.Point(20, 109);
            this.lblBloodQuantity.Name = "lblBloodQuantity";
            this.lblBloodQuantity.Size = new System.Drawing.Size(127, 20);
            this.lblBloodQuantity.TabIndex = 10;
            this.lblBloodQuantity.Text = "Blood Quantity";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(290, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddSample
            // 
            this.btnAddSample.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddSample.Location = new System.Drawing.Point(110, 260);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(150, 40);
            this.btnAddSample.TabIndex = 3;
            this.btnAddSample.Text = "&Add Sample";
            this.btnAddSample.UseVisualStyleBackColor = true;
            this.btnAddSample.Click += new System.EventHandler(this.btnAddSample_Click);
            // 
            // AddBloodSampleForm
            // 
            this.AcceptButton = this.btnAddSample;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(544, 316);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSample);
            this.Controls.Add(this.gbBloodSampleParticulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 340);
            this.Name = "AddBloodSampleForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Add New Blood Sample";
            this.Shown += new System.EventHandler(this.AddBloodSampleForm_Shown);
            this.gbBloodSampleParticulars.ResumeLayout(false);
            this.gbBloodSampleParticulars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBloodSampleParticulars;
        private System.Windows.Forms.TextBox txtSampleID;
        private System.Windows.Forms.Label lblSampleID;
        private System.Windows.Forms.TextBox txtCollectionDate;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtBloodQuantity;
        private System.Windows.Forms.Label lblDateOfCollection;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblBloodQuantity;
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddSample;
    }
}