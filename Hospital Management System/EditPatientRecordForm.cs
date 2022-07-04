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
    public partial class EditPatientRecordForm : Form
    {
        private Boolean shouldChangeRecord;
        public EditPatientRecordForm(String PMRN, String Name, String Gender, String Address, String City, String Phone, String RegistrationDate)
        {
            InitializeComponent();
            txtRegistrationDate.Text = RegistrationDate;
            txtPMRN.Text = PMRN;
            txtName.Text = Name;
            txtAddress.Text = Address;
            txtCity.Text = City;
            txtPhone.Text = Phone;
            for (int i = 0; i < cmbGender.Items.Count; i++)
            {
                if (cmbGender.Items[i].ToString().CompareTo(Gender) == 0)
                {
                    cmbGender.SelectedIndex = i;
                    break;
                }
            }
        }

        public Boolean ShouldChangeRecord()
        {
            return shouldChangeRecord;
        }

        public String GetName()
        {
            return txtName.Text;
        }

        public String GetGender()
        {
            return cmbGender.SelectedItem.ToString();
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

        private void EditPatientRecordForm_Shown(object sender, EventArgs e)
        {
            shouldChangeRecord = false;
            txtName.Focus();
        }

        private void btnEditPatientFormUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0 ||
                txtCity.Text.Length == 0 ||
                txtName.Text.Length == 0 ||
                txtPhone.Text.Length == 0 ||
                txtPMRN.Text.Length == 0 ||
                txtRegistrationDate.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to update the record.", "Hospital Management System");
            }
            else
            {
                shouldChangeRecord = true;
                this.Close();
            }
        }
    }
}
