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
    public partial class AddOutPatientItemForm : Form
    {
        private Boolean shouldAddItem;

        public AddOutPatientItemForm()
        {
            InitializeComponent();
        }

        private void AddOutPatientItemForm_Shown(object sender, EventArgs e)
        {
            shouldAddItem = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length == 0 ||
                txtDate.Text.Length == 0 ||
                txtDescription.Text.Length == 0 ||
                txtServiceCharges.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to add a new item.", "Hospital Management System");
            }
            else
            {
                shouldAddItem = true;
                this.Close();
            }
        }

        public String GetCode()
        {
            return txtCode.Text;
        }

        public String GetDescription()
        {
            return txtDescription.Text;
        }

        public String GetDate()
        {
            return txtDate.Text;
        }

        public String GetServiceCharges()
        {
            if (txtServiceCharges.Text.Length == 0)
                return "0";
            else
                return txtServiceCharges.Text;
        }

        public Boolean ShouldAddItem()
        {
            return shouldAddItem;
        }
    }
}
