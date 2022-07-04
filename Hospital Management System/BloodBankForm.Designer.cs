namespace HospitalManagementSystem
{
    partial class BloodBankForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgridBloodBankRecord = new System.Windows.Forms.DataGridView();
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.bloodBankTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodBankTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.BloodBankTableTableAdapter();
            this.sampleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfCollectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridBloodBankRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridBloodBankRecord
            // 
            this.dtgridBloodBankRecord.AllowUserToAddRows = false;
            this.dtgridBloodBankRecord.AllowUserToDeleteRows = false;
            this.dtgridBloodBankRecord.AllowUserToResizeColumns = false;
            this.dtgridBloodBankRecord.AllowUserToResizeRows = false;
            this.dtgridBloodBankRecord.AutoGenerateColumns = false;
            this.dtgridBloodBankRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridBloodBankRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridBloodBankRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgridBloodBankRecord.ColumnHeadersHeight = 35;
            this.dtgridBloodBankRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridBloodBankRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sampleIDDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.bloodQuantityDataGridViewTextBoxColumn,
            this.dateOfCollectionDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn});
            this.dtgridBloodBankRecord.DataSource = this.bloodBankTableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridBloodBankRecord.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgridBloodBankRecord.EnableHeadersVisualStyles = false;
            this.dtgridBloodBankRecord.Location = new System.Drawing.Point(10, 10);
            this.dtgridBloodBankRecord.MultiSelect = false;
            this.dtgridBloodBankRecord.Name = "dtgridBloodBankRecord";
            this.dtgridBloodBankRecord.ReadOnly = true;
            this.dtgridBloodBankRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridBloodBankRecord.RowHeadersVisible = false;
            this.dtgridBloodBankRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgridBloodBankRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridBloodBankRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridBloodBankRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridBloodBankRecord.Size = new System.Drawing.Size(623, 370);
            this.dtgridBloodBankRecord.TabIndex = 4;
            this.dtgridBloodBankRecord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgridBloodBankRecord_MouseDoubleClick);
            this.dtgridBloodBankRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgridBloodBankRecord_KeyDown);
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodBankTableBindingSource
            // 
            this.bloodBankTableBindingSource.DataMember = "BloodBankTable";
            this.bloodBankTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // bloodBankTableTableAdapter
            // 
            this.bloodBankTableTableAdapter.ClearBeforeFill = true;
            // 
            // sampleIDDataGridViewTextBoxColumn
            // 
            this.sampleIDDataGridViewTextBoxColumn.DataPropertyName = "SampleID";
            this.sampleIDDataGridViewTextBoxColumn.HeaderText = "Sample ID";
            this.sampleIDDataGridViewTextBoxColumn.Name = "sampleIDDataGridViewTextBoxColumn";
            this.sampleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "Blood Group";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bloodQuantityDataGridViewTextBoxColumn
            // 
            this.bloodQuantityDataGridViewTextBoxColumn.DataPropertyName = "BloodQuantity";
            this.bloodQuantityDataGridViewTextBoxColumn.HeaderText = "Blood Quantity";
            this.bloodQuantityDataGridViewTextBoxColumn.Name = "bloodQuantityDataGridViewTextBoxColumn";
            this.bloodQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodQuantityDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateOfCollectionDataGridViewTextBoxColumn
            // 
            this.dateOfCollectionDataGridViewTextBoxColumn.DataPropertyName = "DateOfCollection";
            this.dateOfCollectionDataGridViewTextBoxColumn.HeaderText = "Date of Collection";
            this.dateOfCollectionDataGridViewTextBoxColumn.Name = "dateOfCollectionDataGridViewTextBoxColumn";
            this.dateOfCollectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfCollectionDataGridViewTextBoxColumn.Width = 150;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "Date of Expiration";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expiryDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(335, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(195, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BloodBankForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(645, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtgridBloodBankRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(651, 480);
            this.Name = "BloodBankForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blood Bank";
            this.Load += new System.EventHandler(this.BloodBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridBloodBankRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodBankTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridBloodBankRecord;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource bloodBankTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.BloodBankTableTableAdapter bloodBankTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sampleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfCollectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}