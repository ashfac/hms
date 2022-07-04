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
    public partial class AddLabTestForm : Form
    {
        private Boolean shouldAddTest;

        public AddLabTestForm()
        {
            InitializeComponent();
        }

        private void AddLabTestForm_Shown(object sender, EventArgs e)
        {
            shouldAddTest = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0 ||
                txtName.Text.Length == 0 ||
                txtServiceCharges.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to add a new test.", "Hospital Management System");
            }
            else
            {
                shouldAddTest = true;
                this.Close();
            }
        }

        public String GetTestID()
        {
            return txtID.Text;
        }

        public String GetTestName()
        {
            return txtName.Text;
        }

        public String GetServiceCharges()
        {
            if (txtServiceCharges.Text.Length == 0)
                return "0";
            else
                return txtServiceCharges.Text;
        }

        public Boolean ShouldAddTest()
        {
            return shouldAddTest;
        }
    }
}
