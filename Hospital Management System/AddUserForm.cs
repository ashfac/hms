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
    public partial class AddUserForm : Form
    {
        private Boolean shouldAddRecord;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Shown(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = 0;
            shouldAddRecord = false;
        }

        private void btnAddUserFormAddUser_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Length == 0 ||
                txtCity.Text.Length == 0 ||
                txtDesignation.Text.Length == 0 ||
                txtFullName.Text.Length == 0 ||
                txtPassword.Text.Length == 0 ||
                txtPhone.Text.Length == 0 ||
                txtRetypePassword.Text.Length == 0 ||
                txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to create a new user account.", "Empty Fields");
            }
            else if (txtPassword.Text.CompareTo(txtRetypePassword.Text) != 0)
            {
                MessageBox.Show("The password pair does not match. Please enter the same password twice.", "Invalid Passwords");
                txtPassword.Clear();
                txtRetypePassword.Clear();
                txtPassword.Focus();
            }
            else
            {
                shouldAddRecord = true;
                this.Close();
            }
        }

        public String GetFullName()
        {
            return txtFullName.Text;
        }

        public String GetDesignation()
        {
            return txtDesignation.Text;
        }

        public String GetUserName()
        {
            return txtUsername.Text;
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

        public Boolean ShouldAddRecord()
        {
            return shouldAddRecord;
        }
    }
}
