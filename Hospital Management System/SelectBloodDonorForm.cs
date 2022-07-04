using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HospitalManagementSystem
{
    public partial class SelectBloodDonorForm : Form
    {
        private Boolean recordSelected;
        private String SelectedID;

        public SelectBloodDonorForm()
        {
            InitializeComponent();
        }

        private void SelectBloodDonorForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.bloodDonorsTableTableAdapter.Fill(this.hMSDatabaseDataSet.BloodDonorsTable);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AcceptChangesAndClose();
        }

        private void dtgridBloodDonorRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AcceptChangesAndClose();
        }

        private void dtgridBloodDonorRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptChangesAndClose();
                e.Handled = true;
            }
        }

        private void AcceptChangesAndClose()
        {
            if (dtgridBloodDonorRecord.SelectedRows.Count > 0)
            {
                SelectedID = (String)dtgridBloodDonorRecord.SelectedRows[0].Cells["donorIDDataGridViewTextBoxColumn"].Value.ToString();
                recordSelected = true;
            }
            this.Close();
        }

        public Boolean RecordSelected()
        {
            return recordSelected;
        }

        public String GetSelectedDonorID()
        {
            return SelectedID;
        }

    }
}
