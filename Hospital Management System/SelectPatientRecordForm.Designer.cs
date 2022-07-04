namespace HospitalManagementSystem
{
    partial class SelectPatientRecordForm
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
            this.dtgridPatientRecord = new System.Windows.Forms.DataGridView();
            this.patientRecordTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.patientRecordTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.PatientRecordTableTableAdapter();
            this.pMRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPatientRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(341, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(201, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtgridPatientRecord
            // 
            this.dtgridPatientRecord.AllowUserToAddRows = false;
            this.dtgridPatientRecord.AllowUserToDeleteRows = false;
            this.dtgridPatientRecord.AllowUserToResizeColumns = false;
            this.dtgridPatientRecord.AllowUserToResizeRows = false;
            this.dtgridPatientRecord.AutoGenerateColumns = false;
            this.dtgridPatientRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridPatientRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridPatientRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridPatientRecord.ColumnHeadersHeight = 35;
            this.dtgridPatientRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridPatientRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pMRNDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dtgridPatientRecord.DataSource = this.patientRecordTableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridPatientRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgridPatientRecord.EnableHeadersVisualStyles = false;
            this.dtgridPatientRecord.Location = new System.Drawing.Point(10, 10);
            this.dtgridPatientRecord.MultiSelect = false;
            this.dtgridPatientRecord.Name = "dtgridPatientRecord";
            this.dtgridPatientRecord.ReadOnly = true;
            this.dtgridPatientRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridPatientRecord.RowHeadersVisible = false;
            this.dtgridPatientRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgridPatientRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridPatientRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridPatientRecord.Size = new System.Drawing.Size(643, 370);
            this.dtgridPatientRecord.TabIndex = 0;
            this.dtgridPatientRecord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgridPatientRecord_MouseDoubleClick);
            this.dtgridPatientRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgridPatientRecord_KeyDown);
            // 
            // patientRecordTableBindingSource
            // 
            this.patientRecordTableBindingSource.DataMember = "PatientRecordTable";
            this.patientRecordTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRecordTableTableAdapter
            // 
            this.patientRecordTableTableAdapter.ClearBeforeFill = true;
            // 
            // pMRNDataGridViewTextBoxColumn
            // 
            this.pMRNDataGridViewTextBoxColumn.DataPropertyName = "PMRN";
            this.pMRNDataGridViewTextBoxColumn.HeaderText = "PMRN";
            this.pMRNDataGridViewTextBoxColumn.Name = "pMRNDataGridViewTextBoxColumn";
            this.pMRNDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMRNDataGridViewTextBoxColumn.ToolTipText = "Patient Master Registration Number";
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "RegistrationDate";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "Reg Date";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            this.registrationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.registrationDateDataGridViewTextBoxColumn.ToolTipText = "Patient\'s Registration Date";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SelectPatientRecordForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(664, 456);
            this.Controls.Add(this.dtgridPatientRecord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 480);
            this.Name = "SelectPatientRecordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Select Patient Record";
            this.Load += new System.EventHandler(this.SelectPatientRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridPatientRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRecordTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dtgridPatientRecord;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientRecordTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.PatientRecordTableTableAdapter patientRecordTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}