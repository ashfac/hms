namespace HospitalManagementSystem
{
    partial class SelectUserRecordForm
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
            this.dtgridUserRecord = new System.Windows.Forms.DataGridView();
            this.userRecordTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDatabaseDataSet = new HospitalManagementSystem.HMSDatabaseDataSet();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.userRecordTableTableAdapter = new HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.UserRecordTableTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usergroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUserRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgridUserRecord
            // 
            this.dtgridUserRecord.AllowUserToAddRows = false;
            this.dtgridUserRecord.AllowUserToDeleteRows = false;
            this.dtgridUserRecord.AllowUserToResizeColumns = false;
            this.dtgridUserRecord.AllowUserToResizeRows = false;
            this.dtgridUserRecord.AutoGenerateColumns = false;
            this.dtgridUserRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgridUserRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgridUserRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgridUserRecord.ColumnHeadersHeight = 35;
            this.dtgridUserRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgridUserRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usergroupDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dtgridUserRecord.DataSource = this.userRecordTableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridUserRecord.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgridUserRecord.EnableHeadersVisualStyles = false;
            this.dtgridUserRecord.Location = new System.Drawing.Point(10, 10);
            this.dtgridUserRecord.MultiSelect = false;
            this.dtgridUserRecord.Name = "dtgridUserRecord";
            this.dtgridUserRecord.ReadOnly = true;
            this.dtgridUserRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgridUserRecord.RowHeadersVisible = false;
            this.dtgridUserRecord.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgridUserRecord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgridUserRecord.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgridUserRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridUserRecord.Size = new System.Drawing.Size(733, 370);
            this.dtgridUserRecord.TabIndex = 0;
            this.dtgridUserRecord.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgridUserRecord_MouseDoubleClick);
            this.dtgridUserRecord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgridUserRecord_KeyDown);
            // 
            // userRecordTableBindingSource
            // 
            this.userRecordTableBindingSource.DataMember = "UserRecordTable";
            this.userRecordTableBindingSource.DataSource = this.hMSDatabaseDataSet;
            // 
            // hMSDatabaseDataSet
            // 
            this.hMSDatabaseDataSet.DataSetName = "HMSDatabaseDataSet";
            this.hMSDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(246, 400);
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
            this.btnCancel.Location = new System.Drawing.Point(386, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // userRecordTableTableAdapter
            // 
            this.userRecordTableTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 120;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 120;
            // 
            // usergroupDataGridViewTextBoxColumn
            // 
            this.usergroupDataGridViewTextBoxColumn.DataPropertyName = "UserGroup";
            this.usergroupDataGridViewTextBoxColumn.HeaderText = "User Group";
            this.usergroupDataGridViewTextBoxColumn.Name = "usergroupDataGridViewTextBoxColumn";
            this.usergroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.usergroupDataGridViewTextBoxColumn.Width = 120;
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
            // SelectUserRecordForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtgridUserRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(761, 480);
            this.Name = "SelectUserRecordForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Hospital Management System - Select User Record";
            this.Load += new System.EventHandler(this.SelectUserRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridUserRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgridUserRecord;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private HMSDatabaseDataSet hMSDatabaseDataSet;
        private System.Windows.Forms.BindingSource userRecordTableBindingSource;
        private HospitalManagementSystem.HMSDatabaseDataSetTableAdapters.UserRecordTableTableAdapter userRecordTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usergroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}