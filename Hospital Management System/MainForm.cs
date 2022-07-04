using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    delegate void LogOutCBFunction();

    public partial class MainForm : Form
    {
        private HMSMenuSystem hmsMenuSystem;
        private HMSDBManagement HMSDatabase;

        private Boolean loggedIn;

        public MainForm()
        {
            InitializeComponent();
            HMSDatabase = new HMSDBManagement(ReadDatabaseLocation());
            hmsMenuSystem = new HMSMenuSystem(this, HMSDatabase, LogOut);
            hmsMenuSystem.InitializeMenus();
        }

        public String ReadDatabaseLocation()
        {
            String DatabaseLocation = "";
            try
            {
                XmlTextReader objXmlTextReader = new XmlTextReader(Application.StartupPath + @"\Settings.xml");
                String SettingType = "";
                while (objXmlTextReader.Read())
                {
                    switch (objXmlTextReader.NodeType)
                    {
                        case XmlNodeType.Element:
                            SettingType = objXmlTextReader.Name;
                            break;

                        case XmlNodeType.Text:
                            switch (SettingType)
                            {
                                case "DatabaseLocation":
                                    DatabaseLocation = objXmlTextReader.Value;
                                    break;
                            }
                            break;
                    }
                }
                objXmlTextReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            
            if (DatabaseLocation.Length == 0)
                return Application.StartupPath + @"\HMSDatabase.mdb";
            else
                return DatabaseLocation;
        }

        public void WriteDatabaseLocation(String DatabaseLocation)
        {
            try
            {
                XmlTextWriter objXmlTextWriter = new XmlTextWriter(Application.StartupPath + @"\Settings.xml", null);
                objXmlTextWriter.Formatting = Formatting.Indented;
                objXmlTextWriter.WriteStartDocument();
                objXmlTextWriter.WriteStartElement("HMS");
                
                objXmlTextWriter.WriteStartElement("DatabaseLocation");
                objXmlTextWriter.WriteString(DatabaseLocation);
                objXmlTextWriter.WriteEndElement();

                objXmlTextWriter.WriteEndElement();
                objXmlTextWriter.WriteEndDocument();

                objXmlTextWriter.Flush();
                objXmlTextWriter.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            if (gbLogin.Visible)
            {
                if (txtLoginUserName.Focused)
                    txtLoginPassword.Focus();

                else if (HMSDatabase.LoginUser(txtLoginUserName.Text, txtLoginPassword.Text))
                {
                    String UserFullName = HMSDatabase.GetUserRecordFullName(txtLoginUserName.Text);
                    String UserGroup = HMSDatabase.GetUserRecordUserGroup(txtLoginUserName.Text);

                    this.AcceptButton = null;
                    txtLoginUserName.Clear();
                    txtLoginPassword.Clear();
                    gbLogin.Hide();

                    hmsMenuSystem.ShowMainMenu(UserGroup);
                    lblMessageBar.Text = "Welcome " + UserFullName + "     User Group [" + UserGroup + "]";
                    loggedIn = true;
                }
                else
                {
                    txtLoginUserName.Clear();
                    txtLoginPassword.Clear();
                    txtLoginUserName.Focus();
                }
            }
        }

        private void LogOut()
        {
            loggedIn = false;
            hmsMenuSystem.HideMainMenu();
            gbLogin.Show();
            lblMessageBar.Text = "Welcome to Hospital Management System";
            this.AcceptButton = btnLogin;
            txtLoginUserName.Focus();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (loggedIn)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                    case Keys.Up:
                    case Keys.Return:
                    case Keys.Escape:

                        if (hmsMenuSystem != null)
                            hmsMenuSystem.ProcessKeyboardInput(e);
                        e.Handled = true;
                        break;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit Hospital Management System?", "Hospital Management System", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime thisTime = DateTime.Now;
            lblSystemTime.Text = thisTime.ToLongDateString() + "  " + thisTime.ToLongTimeString();
            ClockTimer.Interval = 1000;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Boolean exiting = false;
            if (!HMSDatabase.UserRecordExists())
                {
                MessageBox.Show("There are currently no employees registered in the database. " + 
                                "Please register at least one employee to the System to start working.");
                AddUserForm addUserForm = new AddUserForm();
                addUserForm.ShowDialog();

                if (addUserForm.ShouldAddRecord())
                {
                    String UserGroup = addUserForm.GetUserGroup();

                    if (UserGroup.CompareTo("Administrator") != 0)
                    {
                        if (MessageBox.Show("The first user account created should belong to Administrators User Group. " +
                                            "Click OK to select the Administrator Group for this user account, or Cancel to exit the program.",
                                            "Select User Group",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            UserGroup = "Administrator";
                        }
                        else
                        {
                            exiting = true;
                        }
                    }

                    if (!exiting)
                    {
                        while (!HMSDatabase.AddUserRecord(addUserForm.GetFullName(),
                                                          addUserForm.GetDesignation(),
                                                          addUserForm.GetUserName(),
                                                          addUserForm.GetPassword(),
                                                          UserGroup,
                                                          addUserForm.GetPhone(),
                                                          addUserForm.GetAddress(),
                                                          addUserForm.GetCity()))
                        {
                            addUserForm.ShowDialog();
                            if (!addUserForm.ShouldAddRecord())
                            {
                                exiting = true;
                                break;
                            }
                        }
                    }

                    if (!exiting)
                    {
                        this.AcceptButton = null;
                        txtLoginUserName.Clear();
                        txtLoginPassword.Clear();
                        gbLogin.Hide();

                        hmsMenuSystem.ShowMainMenu(UserGroup);
                        lblMessageBar.Text = "Welcome " + HMSDatabase.GetUserRecordFullName(txtLoginUserName.Text) +
                                             "     User Group [" + UserGroup + "]";
                        loggedIn = true;
                    }
                }
                else
                {
                    exiting = true;
                }

                if(exiting)
                {
                    Application.Exit();
                }
            }
        }

        private void btnChangeDatabase_Click(object sender, EventArgs e)
        {
            DatabaseLocationForm databaseLocationForm = new DatabaseLocationForm(ReadDatabaseLocation());
            databaseLocationForm.ShowDialog();

            if (databaseLocationForm.DatabaseLocationChanged())
            {
                WriteDatabaseLocation(databaseLocationForm.GetDatabaseLocation());
                try
                {
                    HMSDatabase = new HMSDBManagement(databaseLocationForm.GetDatabaseLocation());
                    hmsMenuSystem = new HMSMenuSystem(this, HMSDatabase, LogOut);
                    hmsMenuSystem.InitializeMenus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
