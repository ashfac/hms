using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;


namespace HospitalManagementSystem
{
    public partial class SelectUserRecordForm : Form
    {
        private String SelectedUsername;
        private Boolean shouldChangeRecord;

        public SelectUserRecordForm()
        {
            InitializeComponent();
        }

        public Boolean ShouldChangeRecord()
        {
            return shouldChangeRecord;
        }

        public String GetSelectedUsername()
        {
            return SelectedUsername;
        }

        private void SelectUserRecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.userRecordTableTableAdapter.Fill(this.hMSDatabaseDataSet.UserRecordTable);
                shouldChangeRecord = false;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
                this.Close();
            }
        }

        private void AcceptChangesAndClose()
        {
            if (dtgridUserRecord.SelectedRows.Count > 0)
            {
                SelectedUsername = (String)dtgridUserRecord.SelectedRows[0].Cells["usernameDataGridViewTextBoxColumn"].Value;
                shouldChangeRecord = true;
            }
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AcceptChangesAndClose();
        }

        private void dtgridUserRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptChangesAndClose();
                e.Handled = true;
            }
        }

        private void dtgridUserRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AcceptChangesAndClose();
        }
    }
}
