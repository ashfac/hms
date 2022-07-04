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
    public partial class DatabaseLocationForm : Form
    {
        private Boolean databaseLocationChanged;

        public DatabaseLocationForm(String DatabaseLocation)
        {
            InitializeComponent();
            txtDatabaseLocation.Text = DatabaseLocation;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            databaseLocationChanged = true;
            this.Close();
        }

        public String GetDatabaseLocation()
        {
            return txtDatabaseLocation.Text; ;
        }

        public Boolean DatabaseLocationChanged()
        {
            return databaseLocationChanged;
        }

        private void DatabaseLocationForm_Shown(object sender, EventArgs e)
        {
            databaseLocationChanged = false;
            btnBrowse.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (browseDatabaseDialog.ShowDialog() == DialogResult.OK)
            {
                txtDatabaseLocation.Text = browseDatabaseDialog.FileName;
                btnOK.Focus();
            }
        }
    }
}
