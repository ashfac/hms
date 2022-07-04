using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PrescriptionForm : Form
    {
        private Boolean shouldPrintReport;
        
        public PrescriptionForm(String PMRN, String Name, String Prescription)
        {
            InitializeComponent();

            txtName.Text = Name;
            txtPMRN.Text = PMRN;
            txtPrescription.Text = Prescription;
        }

        public Boolean ShouldPrintReport()
        {
            return shouldPrintReport;
        }

        private void btnPrintLabReport_Click(object sender, EventArgs e)
        {
            if (txtPrescription.Text.Length == 0)
            {
                MessageBox.Show("The prescription field cannot be empty.", "Hospital Management System");
            }
            else
            {
                shouldPrintReport = true;
                this.Close();
            }
        }

        public String GetPrescription()
        {
            return txtPrescription.Text;
        }

        private void PrescriptionForm_Shown(object sender, EventArgs e)
        {
            shouldPrintReport = false;
            txtPrescription.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrescription.Clear();
            txtPrescription.Focus();
        }
    }
}
