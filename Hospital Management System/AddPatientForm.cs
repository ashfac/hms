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
    public partial class AddPatientForm : Form
    {
        private Boolean shouldAddRecord;
        public AddPatientForm(String PMRN, String RegistrationDate)
        {
            InitializeComponent();
            txtPMRN.Text = PMRN;
            txtRegistrationDate.Text = RegistrationDate;
        }

        private void AddPatientForm_Shown(object sender, EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            shouldAddRecord = false;
            txtName.Focus();
        }

        private void btnAddPatientFormAddPatient_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0 ||
                txtCity.Text.Length == 0 ||
                txtName.Text.Length == 0 ||
                txtPhone.Text.Length == 0 ||
                txtPMRN.Text.Length == 0 ||
                txtRegistrationDate.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to add a new patient.", "Hospital Management System");
            }
            else
            {
                shouldAddRecord = true;
                this.Close();
            }
        }

        public String GetName()
        {
            return txtName.Text;
        }

        public String GetAddress()
        {
            return txtAddress.Text;
        }

        public String GetCity()
        {
            return txtCity.Text;
        }

        public String GetPhone()
        {
            return txtPhone.Text;
        }

        public String GetGender()
        {
            return cmbGender.SelectedItem.ToString();
        }

        public Boolean ShouldAddRecord()
        {
            return shouldAddRecord;
        }
    }
}
