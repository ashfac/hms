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
    public partial class LabTestsForm : Form
    {
        private Boolean shouldAddRecord, shouldPrintReport, shouldDeleteRecord;
        private String ID, TestID, TestName, ServiceCharges;

        public LabTestsForm(String PMRN, String Name)
        {
            InitializeComponent();

            txtPMRN.Text = PMRN;
            txtName.Text = Name;
            this.labTestsTableBindingSource.Filter = "PMRN = '" + PMRN + "'";
        }

        private void LabTestsForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.labTestsTableTableAdapter.Fill(this.hMSDatabaseDataSet.LabTestsTable);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
                this.Close();
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            AddLabTestForm addLabTestForm = new AddLabTestForm();
            addLabTestForm.ShowDialog();
            if (addLabTestForm.ShouldAddTest())
            {
                TestID = addLabTestForm.GetTestID();
                TestName = addLabTestForm.GetTestName();
                ServiceCharges = addLabTestForm.GetServiceCharges();
                shouldAddRecord = true;
                this.Close();
            }
        }

        public Boolean ShouldPrintReport()
        {
            return shouldPrintReport;
        }

        public Boolean ShouldAddRecord()
        {
            return shouldAddRecord;
        }

        public Boolean ShouldDeleteRecord()
        {
            return shouldDeleteRecord;
        }

        private void LabTestsForm_Shown(object sender, EventArgs e)
        {
            shouldAddRecord = false;
            shouldPrintReport = false;
            shouldDeleteRecord = false;
        }

        private void btnPrintLabReport_Click(object sender, EventArgs e)
        {
            shouldPrintReport = true;
            this.Close();
        }

        public String GetID()
        {
            return ID;
        }

        public String GetTestID()
        {
            return TestID;
        }

        public String GetTestName()
        {
            return TestName;
        }

        public String GetServicesCharges()
        {
            return ServiceCharges;
        }

        public String GetTime()
        {
            return txtTime.Text;
        }

        public String GetDate()
        {
            return txtDate.Text;
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            if (dtgridLabTests.Rows.Count != 0)
            {
                ID = (String)dtgridLabTests.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
                TestID = (String)dtgridLabTests.SelectedRows[0].Cells["testIDDataGridViewTextBoxColumn"].Value.ToString();
                TestName = (String)dtgridLabTests.SelectedRows[0].Cells["testNameDataGridViewTextBoxColumn"].Value.ToString();
                ServiceCharges = (String)dtgridLabTests.SelectedRows[0].Cells["serviceChargesDataGridViewTextBoxColumn"].Value.ToString();

                if (MessageBox.Show("Are you sure you want to delete test '" + TestName + " (" + TestID + ")' ?\n" +
                                   "This operation cannot be undone!",
                                   "Delete Test Warning",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    shouldDeleteRecord = true;
                    this.Close();
                }
            }
        }
    }
}
