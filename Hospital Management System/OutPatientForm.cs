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
    public partial class OutPatientForm : Form
    {
        private Boolean shouldAddRecord, shouldPrintReport, shouldDeleteRecord;
        private String ID, Code, Description, Date, ServiceCharges;

        public OutPatientForm(String PMRN, String Name)
        {
            InitializeComponent();

            txtName.Text = Name;
            txtPMRN.Text = PMRN;
            this.outPatientTableBindingSource.Filter = "PMRN = '" + PMRN + "'";
        }

        private void OutPatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.outPatientTableTableAdapter.Fill(this.hMSDatabaseDataSet.OutPatientTable);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
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

        public String GetID()
        {
            return ID;
        }

        public String GetCode()
        {
            return Code;
        }

        public String GetDescription()
        {
            return Description;
        }

        public String GetServicesCharges()
        {
            return ServiceCharges;
        }

        public String GetDate()
        {
            return Date;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddOutPatientItemForm addOutPatientItemForm = new AddOutPatientItemForm();
            addOutPatientItemForm.ShowDialog();
            if (addOutPatientItemForm.ShouldAddItem())
            {
                Code = addOutPatientItemForm.GetCode();
                Description = addOutPatientItemForm.GetDescription();
                Date = addOutPatientItemForm.GetDate();
                ServiceCharges = addOutPatientItemForm.GetServiceCharges();
                shouldAddRecord = true;
                this.Close();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dtgridExpenses.Rows.Count != 0)
            {
                ID = (String)dtgridExpenses.SelectedRows[0].Cells["indexDataGridViewTextBoxColumn"].Value.ToString();
                Code = (String)dtgridExpenses.SelectedRows[0].Cells["codeDataGridViewTextBoxColumn"].Value.ToString();
                Description = (String)dtgridExpenses.SelectedRows[0].Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                Date = (String)dtgridExpenses.SelectedRows[0].Cells["dateDataGridViewTextBoxColumn"].Value.ToString();
                ServiceCharges = (String)dtgridExpenses.SelectedRows[0].Cells["serviceChargesDataGridViewTextBoxColumn"].Value.ToString();

                if (MessageBox.Show("Are you sure you want to delete item '" + Description + " (" + Code + ")' ?\n" +
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

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            shouldPrintReport = true;
            this.Close();
        }

        private void OutPatientForm_Shown(object sender, EventArgs e)
        {
            shouldAddRecord = false;
            shouldDeleteRecord = false;
            shouldPrintReport = false;
            dtgridExpenses.Focus();
        }
    }
}
