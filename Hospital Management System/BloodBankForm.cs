using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class BloodBankForm : Form
    {
        private Boolean recordSelected;
        private String SampleID;

        public BloodBankForm()
        {
            InitializeComponent();
        }

        private void BloodBankForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.bloodBankTableTableAdapter.Fill(this.hMSDatabaseDataSet.BloodBankTable);
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

        private void AcceptChangesAndClose()
        {
            if (dtgridBloodBankRecord.SelectedRows.Count > 0)
            {
                SampleID = (String)dtgridBloodBankRecord.SelectedRows[0].Cells["sampleIDDataGridViewTextBoxColumn"].Value.ToString();
                recordSelected = true;
            }
            this.Close();
        }

        public Boolean RecordSelected()
        {
            return recordSelected;
        }

        public String GetSelectedSampleID()
        {
            return SampleID;
        }

        private void dtgridBloodBankRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AcceptChangesAndClose();
        }

        private void dtgridBloodBankRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptChangesAndClose();
                e.Handled = true;
            }
        }
    }
}
