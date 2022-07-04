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
    public partial class AddBloodSampleForm : Form
    {
        private Boolean shouldAddRecord;

        public AddBloodSampleForm(String SampleID)
        {
            InitializeComponent();
            txtSampleID.Text = SampleID;
        }

        private void AddBloodSampleForm_Shown(object sender, EventArgs e)
        {
            cmbBloodGroup.SelectedIndex = 0;
            shouldAddRecord = false;
        }

        private void btnAddSample_Click(object sender, EventArgs e)
        {
            if (txtBloodQuantity.Text.Length == 0 ||
                txtCollectionDate.Text.Length == 0 ||
                txtExpiryDate.Text.Length == 0 ||
                txtSampleID.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields to add a new blood sample.", "Hospital Management System");
            }
            else
            {
                shouldAddRecord = true;
                this.Close();
            }
        }

        public String GetBloodGroup()
        {
            return cmbBloodGroup.SelectedItem.ToString();
        }

        public String GetBloodQuantity()
        {
            return txtBloodQuantity.Text;
        }

        public String GetCollectionDate()
        {
            return txtCollectionDate.Text;
        }

        public String GetExpiryDate()
        {
            return txtExpiryDate.Text;
        }

        public Boolean ShouldAddRecord()
        {
            return shouldAddRecord;
        }

    }
}
