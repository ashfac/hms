namespace HospitalManagementSystem
{
    partial class OutPatientForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPMRN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgridExpenses = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outPatientTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.outPatientTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.OutPatientTableTableAdapter();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPatientTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPMRN
            // 
            this.txtPMRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtPMRN.Location = new System.Drawing.Point(419, 17);
            this.txtPMRN.Name = "txtPMRN";
            this.txtPMRN.ReadOnly = true;
            this.txtPMRN.Size = new System.Drawing.Size(180, 26);
            this.txtPMRN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(354, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "PMRN";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(156, 17);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(180, 26);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patient\'s Name";
            // 
            // dtgridExpenses
            // 
            this.dtgridExpenses.AllowUserToAddRows = false;
            this.dtgridExpenses.AllowUserToDeleteRows = false;
            this.dtgridExpenses.AllowUserToResizeColumns = false;
            this.dtgridExpenses.AllowUserToResizeRows = false;
            this.dtgridExpenses.AutoGenerateColumns = false;
            this.dtgridExpenses.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgridExpenses.ColumnHeadersHeight = 35;
            this.dtgridExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.serviceChargesDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn});
            this.dtgridExpenses.DataSource = this.outPatientTableBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridExpenses.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgridExpenses.EnableHeadersVisualStyles = false;
            this.dtgridExpenses.Location = new System.Drawing.Point(20, 70);
            this.dtgridExpenses.MultiSelect = false;
            this.dtgridExpenses.Name = "dtgridExpenses";
            this.dtgridExpenses.ReadOnly = true;
            this.dtgridExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridExpenses.RowHeadersVisible = false;
            this.dtgridExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtgridExpenses.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgridExpenses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridExpenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridExpenses.Size = new System.Drawing.Size(591, 298);
            this.dtgridExpenses.TabIndex = 2;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(170, 390);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "&Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(321, 390);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(140, 40);
            this.btnPrintReport.TabIndex = 5;
            this.btnPrintReport.Text = "&Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(20, 390);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(140, 40);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "&Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "CODE";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 80;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 108;
            // 
            // serviceChargesDataGridViewTextBoxColumn
            // 
            this.serviceChargesDataGridViewTextBoxColumn.DataPropertyName = "ServiceCharges";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.serviceChargesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.serviceChargesDataGridViewTextBoxColumn.HeaderText = "Charges";
            this.serviceChargesDataGridViewTextBoxColumn.Name = "serviceChargesDataGridViewTextBoxColumn";
            this.serviceChargesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outPatientTableBindingSource
            // 
            this.outPatientTableBindingSource.DataMember = "OutPatientTable";
            this.outPatientTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outPatientTableTableAdapter
            // 
            this.outPatientTableTableAdapter.ClearBeforeFill = true;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "INDEX";
            this.indexDataGridViewTextBoxColumn.HeaderText = "ID";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Visible = false;
            // 
            // OutPatientForm
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dtgridExpenses);
            this.Controls.Add(this.txtPMRN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OutPatientForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Out-Patient Report";
            this.Load += new System.EventHandler(this.OutPatientForm_Load);
            this.Shown += new System.EventHandler(this.OutPatientForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outPatientTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPMRN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgridExpenses;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnAddItem;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource outPatientTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.OutPatientTableTableAdapter outPatientTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
    }
}