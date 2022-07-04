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
    public partial class EditUserRecordForm : Form
    {
        private Boolean shouldChangeRecord;
        public EditUserRecordForm(String Username, String FullName, String Designation, String UserGroup, String Phone, String Address, String City)
        {
            InitializeComponent();
            txtUsername.Text = Username;
            txtFullName.Text = FullName;
            txtDesignation.Text = Designation;
            txtPhone.Text = Phone;
            txtAddress.Text = Address;
            txtCity.Text = City;

            for(int i=0; i<cmbGroup.Items.Count; i++) 
            {
                if(cmbGroup.Items[i].ToString().CompareTo(UserGroup) == 0)
                {
                    cmbGroup.SelectedIndex = i;
                    break;
                }
            }
        }

        public Boolean ShouldChangeRecord()
        {
            return shouldChangeRecord;
        }

        public String GetFullName()
        {
            return txtFullName.Text;
        }

        public String GetDesignation()
        {
            return txtDesignation.Text;
        }

        public String GetPassword()
        {
            return txtPassword.Text;
        }

        public String GetUserGroup()
        {
            return cmbGroup.SelectedItem.ToString();
        }

        public String GetPhone()
        {
            return txtPhone.Text;
        }

        public String GetAddress()
        {
            return txtAddress.Text;
        }

        public String GetCity()
        {
            return txtCity.Text;
        }

        private void txtEditUserFormPassword_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.ReadOnly)
            {
                txtPassword.ReadOnly = false;
                txtRetypePassword.ReadOnly = false;
                txtPassword.Focus();
            }
        }

        private void txtEditUserFormPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2 && txtPassword.ReadOnly)
            {
                txtPassword.ReadOnly = false;
                txtRetypePassword.ReadOnly = false;
                txtPassword.Focus();
            }
        }

        private void btnEditUserFormUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0 ||
                txtCity.Text.Length == 0 ||
                txtDesignation.Text.Length == 0 ||
                txtFullName.Text.Length == 0 ||
                (!txtPassword.ReadOnly && txtPassword.Text.Length == 0) ||
                txtPhone.Text.Length == 0 ||
                (!txtRetypePassword.ReadOnly && txtRetypePassword.Text.Length == 0) ||
                txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to update user account.", "Hospital Management System");
            }
            else if (txtPassword.Text.CompareTo(txtRetypePassword.Text) != 0)
            {
                MessageBox.Show("The password pair does not match. Please enter the same password twice.", "Hospital Management System");
                txtPassword.Clear();
                txtRetypePassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                shouldChangeRecord = true;
                this.Close();
            }
        }

        private void EditUserRecordForm_Shown(object sender, EventArgs e)
        {
            shouldChangeRecord = false;
            txtFullName.Focus();
        }
    }
}
