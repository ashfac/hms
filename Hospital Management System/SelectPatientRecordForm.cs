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
    public partial class SelectPatientRecordForm : Form
    {
        private String SelectedPatientPMRN;
        private Boolean shouldChangeRecord;

        public SelectPatientRecordForm()
        {
            InitializeComponent();
        }

        public Boolean ShouldChangeRecord()
        {
            return shouldChangeRecord;
        }

        public String GetSelectedPatientPMRN()
        {
            return SelectedPatientPMRN;
        }

        private void AcceptChangesAndClose()
        {
            if (dtgridPatientRecord.SelectedRows.Count > 0)
            {
                SelectedPatientPMRN = (String)dtgridPatientRecord.SelectedRows[0].Cells["pMRNDataGridViewTextBoxColumn"].Value.ToString();
                shouldChangeRecord = true;
            }
            this.Close();
        }

        private void SelectPatientRecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.patientRecordTableTableAdapter.Fill(this.hMSDatabaseDataSet.PatientRecordTable);
                shouldChangeRecord = false;
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

        private void dtgridPatientRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AcceptChangesAndClose();
        }

        private void dtgridPatientRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptChangesAndClose();
                e.Handled = true;
            }
        }
    }
}
