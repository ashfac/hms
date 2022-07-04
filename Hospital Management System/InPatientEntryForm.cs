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
    public partial class InPatientEntryForm : Form
    {
        private Boolean shouldEnter;

        public InPatientEntryForm(String PMRN, String Name)
        {
            InitializeComponent();
            txtPMRN.Text = PMRN;
            txtName.Text = Name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAppointmentID.Text.Length == 0 ||
               txtDate.Text.Length == 0 ||
               txtDescription.Text.Length == 0 ||
               txtDoctorName.Text.Length == 0 ||
               txtName.Text.Length == 0 ||
               txtPMRN.Text.Length == 0 ||
               txtServiceCharges.Text.Length == 0 ||
               txtTime.Text.Length == 0)
            {
                MessageBox.Show("Please fill in all the fields.", "Hospital Management System");
            }
            else
            {
                shouldEnter = true;
                this.Close();
            }
        }

        private void InPatientEntryForm_Shown(object sender, EventArgs e)
        {
            shouldEnter = false;
        }

        public Boolean ShouldEnter()
        {
            return shouldEnter;
        }

        public String GetDate()
        {
            return txtDate.Text;
        }

        public String GetTime()
        {
            return txtTime.Text;
        }

        public String GetAppointmentID()
        {
            return txtAppointmentID.Text;
        }

        public String GetDescription()
        {
            return txtDescription.Text;
        }

        public String GetDoctorName()
        {
            return txtDoctorName.Text;
        }

        public String GetServiceCharges()
        {
            return txtServiceCharges.Text;
        }
    }
}
