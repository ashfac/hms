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
    public partial class BloodDonorsForm : Form
    {
        private Boolean shouldChangeRecord;

        public BloodDonorsForm()
        {
            InitializeComponent();
        }

        public BloodDonorsForm(String Name, String BloodGroup, String Phone, String Address)
        {
            InitializeComponent();
            txtName.Text = Name;
            txtBloodGroup.Text = BloodGroup;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
        }

        private void BloodDonorsForm_Shown(object sender, EventArgs e)
        {
            shouldChangeRecord = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0 ||
                txtBloodGroup.Text.Length == 0 ||
                txtName.Text.Length == 0 ||
                txtPhone.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to add/edit a donor's record.", "Hospital Management System");
            }
            else
            {
                shouldChangeRecord = true;
                this.Close();
            }
        }

        public String GetName()
        {
            return txtName.Text;
        }

        public String GetBloodGroup()
        {
            return txtBloodGroup.Text;
        }

        public String GetPhone()
        {
            return txtPhone.Text;
        }

        public String GetAddress()
        {
            return txtAddress.Text;
        }

        public Boolean ShouldChangeRecord()
        {
            return shouldChangeRecord;
        }
             
    }
}
