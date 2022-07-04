namespace HospitalManagementSystem
{
    partial class LabTestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPMRN = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnPrintLabReport = new System.Windows.Forms.Button();
            this.dtgridLabTests = new System.Windows.Forms.DataGridView();
            this.testIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceChargesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.labTestsTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.LabTestsTableTableAdapter();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLabTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Patient\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 17);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(180, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(431, 17);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(180, 26);
            this.txtTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "PMRN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // txtPMRN
            // 
            this.txtPMRN.Location = new System.Drawing.Point(160, 49);
            this.txtPMRN.Name = "txtPMRN";
            this.txtPMRN.ReadOnly = true;
            this.txtPMRN.Size = new System.Drawing.Size(180, 26);
            this.txtPMRN.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(431, 49);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(180, 26);
            this.txtDate.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(471, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(20, 404);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(140, 40);
            this.btnAddTest.TabIndex = 3;
            this.btnAddTest.Text = "&Add Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnPrintLabReport
            // 
            this.btnPrintLabReport.Location = new System.Drawing.Point(321, 404);
            this.btnPrintLabReport.Name = "btnPrintLabReport";
            this.btnPrintLabReport.Size = new System.Drawing.Size(140, 40);
            this.btnPrintLabReport.TabIndex = 5;
            this.btnPrintLabReport.Text = "&Print Report";
            this.btnPrintLabReport.UseVisualStyleBackColor = true;
            this.btnPrintLabReport.Click += new System.EventHandler(this.btnPrintLabReport_Click);
            // 
            // dtgridLabTests
            // 
            this.dtgridLabTests.AllowUserToAddRows = false;
            this.dtgridLabTests.AllowUserToDeleteRows = false;
            this.dtgridLabTests.AllowUserToResizeColumns = false;
            this.dtgridLabTests.AllowUserToResizeRows = false;
            this.dtgridLabTests.AutoGenerateColumns = false;
            this.dtgridLabTests.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridLabTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridLabTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgridLabTests.ColumnHeadersHeight = 35;
            this.dtgridLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridLabTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.testNameDataGridViewTextBoxColumn,
            this.serviceChargesDataGridViewTextBoxColumn});
            this.dtgridLabTests.DataSource = this.labTestsTableBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridLabTests.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgridLabTests.EnableHeadersVisualStyles = false;
            this.dtgridLabTests.Location = new System.Drawing.Point(20, 100);
            this.dtgridLabTests.MultiSelect = false;
            this.dtgridLabTests.Name = "dtgridLabTests";
            this.dtgridLabTests.ReadOnly = true;
            this.dtgridLabTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridLabTests.RowHeadersVisible = false;
            this.dtgridLabTests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgridLabTests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridLabTests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridLabTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridLabTests.Size = new System.Drawing.Size(591, 284);
            this.dtgridLabTests.TabIndex = 2;
            // 
            // testIDDataGridViewTextBoxColumn
            // 
            this.testIDDataGridViewTextBoxColumn.DataPropertyName = "TestID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.testIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.testIDDataGridViewTextBoxColumn.HeaderText = "Test ID";
            this.testIDDataGridViewTextBoxColumn.Name = "testIDDataGridViewTextBoxColumn";
            this.testIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.testIDDataGridViewTextBoxColumn.Width = 138;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // testNameDataGridViewTextBoxColumn
            // 
            this.testNameDataGridViewTextBoxColumn.DataPropertyName = "TestName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.testNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.testNameDataGridViewTextBoxColumn.HeaderText = "Test Name";
            this.testNameDataGridViewTextBoxColumn.Name = "testNameDataGridViewTextBoxColumn";
            this.testNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.testNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // serviceChargesDataGridViewTextBoxColumn
            // 
            this.serviceChargesDataGridViewTextBoxColumn.DataPropertyName = "ServiceCharges";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.serviceChargesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.serviceChargesDataGridViewTextBoxColumn.HeaderText = "Service Charges";
            this.serviceChargesDataGridViewTextBoxColumn.Name = "serviceChargesDataGridViewTextBoxColumn";
            this.serviceChargesDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceChargesDataGridViewTextBoxColumn.Width = 200;
            // 
            // labTestsTableBindingSource
            // 
            this.labTestsTableBindingSource.DataMember = "LabTestsTable";
            this.labTestsTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.CaseSensitive = true;
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labTestsTableTableAdapter
            // 
            this.labTestsTableTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(170, 404);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(140, 40);
            this.btnDeleteTest.TabIndex = 4;
            this.btnDeleteTest.Text = "&Delete Test";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // LabTestsForm
            // 
            this.AcceptButton = this.btnAddTest;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(634, 456);
            this.Controls.Add(this.btnDeleteTest);
            this.Controls.Add(this.dtgridLabTests);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrintLabReport);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPMRN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LabTestsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Laboratory Tests";
            this.Load += new System.EventHandler(this.LabTestsForm_Load);
            this.Shown += new System.EventHandler(this.LabTestsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridLabTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPMRN;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnPrintLabReport;
        private System.Windows.Forms.DataGridView dtgridLabTests;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource labTestsTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.LabTestsTableTableAdapter labTestsTableTableAdapter;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn testIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceChargesDataGridViewTextBoxColumn;
    }
}