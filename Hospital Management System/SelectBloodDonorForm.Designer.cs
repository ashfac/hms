namespace HospitalManagementSystem
{
    partial class SelectBloodDonorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtgridBloodDonorRecord = new System.Windows.Forms.DataGridView();
            this.donorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodDonorsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.bloodDonorsTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.BloodDonorsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridBloodDonorRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonorsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(297, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(157, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtgridBloodDonorRecord
            // 
            this.dtgridBloodDonorRecord.AllowUserToAddRows = false;
            this.dtgridBloodDonorRecord.AllowUserToDeleteRows = false;
            this.dtgridBloodDonorRecord.AllowUserToResizeColumns = false;
            this.dtgridBloodDonorRecord.AllowUserToResizeRows = false;
            this.dtgridBloodDonorRecord.AutoGenerateColumns = false;
            this.dtgridBloodDonorRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridBloodDonorRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridBloodDonorRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridBloodDonorRecord.ColumnHeadersHeight = 35;
            this.dtgridBloodDonorRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridBloodDonorRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donorIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dtgridBloodDonorRecord.DataSource = this.bloodDonorsTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridBloodDonorRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridBloodDonorRecord.EnableHeadersVisualStyles = false;
            this.dtgridBloodDonorRecord.Location = new System.Drawing.Point(10, 10);
            this.dtgridBloodDonorRecord.MultiSelect = false;
            this.dtgridBloodDonorRecord.Name = "dtgridBloodDonorRecord";
            this.dtgridBloodDonorRecord.ReadOnly = true;
            this.dtgridBloodDonorRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridBloodDonorRecord.RowHeadersVisible = false;
            this.dtgridBloodDonorRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgridBloodDonorRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridBloodDonorRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridBloodDonorRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridBloodDonorRecord.Size = new System.Drawing.Size(554, 370);
            this.dtgridBloodDonorRecord.TabIndex = 3;
            this.dtgridBloodDonorRecord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgridBloodDonorRecord_MouseDoubleClick);
            this.dtgridBloodDonorRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgridBloodDonorRecord_KeyDown);
            // 
            // donorIDDataGridViewTextBoxColumn
            // 
            this.donorIDDataGridViewTextBoxColumn.DataPropertyName = "DonorID";
            this.donorIDDataGridViewTextBoxColumn.HeaderText = "Donor\'s ID";
            this.donorIDDataGridViewTextBoxColumn.Name = "donorIDDataGridViewTextBoxColumn";
            this.donorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.donorIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGroupDataGridViewTextBoxColumn.Width = 102;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 220;
            // 
            // bloodDonorsTableBindingSource
            // 
            this.bloodDonorsTableBindingSource.DataMember = "BloodDonorsTable";
            this.bloodDonorsTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodDonorsTableTableAdapter
            // 
            this.bloodDonorsTableTableAdapter.ClearBeforeFill = true;
            // 
            // SelectBloodDonorForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtgridBloodDonorRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(582, 480);
            this.Name = "SelectBloodDonorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Select Blood Donor Record";
            this.Load += new System.EventHandler(this.SelectBloodDonorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridBloodDonorRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodDonorsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dtgridBloodDonorRecord;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource bloodDonorsTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.BloodDonorsTableTableAdapter bloodDonorsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}