using System;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    enum HMSInputSource : int
    {
        Keyboard,
        Mouse
    }

    delegate void ItemCBFunction();

    class HMSMenuSystem
    {
        private Color ItemColor;
        private Color FontColor;
        private Color SelectedItemColor;
        private Color SelectedFontColor;
        private Font  ItemFont;
        private int   ItemWidth;
        private int   ItemHeight;

        private Form ParentForm;
        private HMSDBManagement HMSDatabase;

        private HMSMenu MainMenu;
        private HMSMenu CurrentMenu;

        private HMSMenu MainMenuAdministrator;
        private HMSMenu MainMenuDoctor;
        private HMSMenu MainMenuReceptionist;

        private HMSInputSource InputSource;

        private LogOutCBFunction logOutCBFunction;

        public HMSMenuSystem(Form parent, HMSDBManagement hmsDatabase, LogOutCBFunction logOutCBFunc)
        {
            ParentForm = parent; // Save a reference to Main Form
            HMSDatabase = hmsDatabase; // Save a reference to the DB Management Class
            logOutCBFunction = logOutCBFunc; // Save a reference to the Log Out Function

            ItemColor = Color.WhiteSmoke;
            FontColor = Color.Black;
            SelectedItemColor = Color.LightSteelBlue;
            SelectedFontColor = Color.Black;
            ItemFont = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            ItemWidth  = 300;
            ItemHeight = 40;
            InputSource = HMSInputSource.Keyboard;
        }

        public void InitializeMenus()
        {
            HMSMenu tempMenu;

            //
            // Now Creating Administrator Group Menu
            //
            MainMenuAdministrator = new HMSMenu(8, this, null);
            MainMenuAdministrator.AddMenuItem("Employee Registration", null);
                tempMenu = new HMSMenu(5, this, MainMenuAdministrator);
                tempMenu.AddMenuItem("Create Employee Profile", onUserRecordAddUserClick);
                tempMenu.AddMenuItem("Edit Employee Profile", onUserRecordEditUserClick);
                tempMenu.AddMenuItem("Delete Employee Profile", onUserRecordDeleteUserClick);
                tempMenu.AddMenuItem("Print Employee Profile", onUserRecordPrintUserClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuAdministrator.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());
                
            MainMenuAdministrator.AddMenuItem("Patient Registration", null);
                tempMenu = new HMSMenu(5, this, MainMenuAdministrator);
                tempMenu.AddMenuItem("Create Patient Profile", onPatientRegistrationCreatePatientProfileClick);
                tempMenu.AddMenuItem("Update Patient Profile", onPatientRegistrationUpdatePatientProfileClick);
                tempMenu.AddMenuItem("Delete Patient Profile", onPatientRegistrationDeletePatientProfileClick);
                tempMenu.AddMenuItem("Print Patient Profile", onPatientRegistrationPrintPatientProfileClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuAdministrator.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuAdministrator.AddMenuItem("In-Patient Record", onInPatientRecordClick);
            MainMenuAdministrator.AddMenuItem("Out-Patient Report", onOutPatientRecordClick);

            MainMenuAdministrator.AddMenuItem("Examine Patient", null);
                tempMenu = new HMSMenu(3, this, MainMenuAdministrator);
                tempMenu.AddMenuItem("Write Prescription", onExaminePatientWritePrescriptionClick);
                tempMenu.AddMenuItem("Prescribe Tests", onExaminePatientPrescribeTestsClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuAdministrator.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuAdministrator.AddMenuItem("Blood Bank", null);
                tempMenu = new HMSMenu(5, this, MainMenuAdministrator);
                tempMenu.AddMenuItem("Check Blood Bank", onBloodBankCheckBankClick);
                tempMenu.AddMenuItem("Add Blood Sample", onBloodBankAddSampleClick);
                tempMenu.AddMenuItem("Delete Blood Sample", onBloodBankDeleteSampleClick);
                tempMenu.AddMenuItem("Print Blood Summary", onBloodBankPrintSummaryClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuAdministrator.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuAdministrator.AddMenuItem("Blood Donors Record", null);
                tempMenu = new HMSMenu(5, this, MainMenuAdministrator);
                tempMenu.AddMenuItem("Add Blood Donor", onBloodDonorsAddDonorClick);
                tempMenu.AddMenuItem("Edit Blood Donor", onBloodDonorsEditDonorClick);
                tempMenu.AddMenuItem("Delete Blood Donor", onBloodDonorsDeleteDonorClick);
                tempMenu.AddMenuItem("Print Donor's Record", onBloodDonorsPrintDonorClick); 
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuAdministrator.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuAdministrator.AddMenuItem("Log Out", onLogOut);
                        
            ParentForm.Controls.Add(MainMenuAdministrator.GetHMSMenu());

            //
            // Now Creating Doctor Group Menu
            //
            MainMenuDoctor = new HMSMenu(3, this, null);

            MainMenuDoctor.AddMenuItem("Patient Registration", null);
                tempMenu = new HMSMenu(5, this, MainMenuDoctor);
                tempMenu.AddMenuItem("Create Patient Profile", onPatientRegistrationCreatePatientProfileClick);
                tempMenu.AddMenuItem("Update Patient Profile", onPatientRegistrationUpdatePatientProfileClick);
                tempMenu.AddMenuItem("Delete Patient Profile", onPatientRegistrationDeletePatientProfileClick);
                tempMenu.AddMenuItem("Print Patient Profile", onPatientRegistrationPrintPatientProfileClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuDoctor.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuDoctor.AddMenuItem("Examine Patient", null);
                tempMenu = new HMSMenu(3, this, MainMenuDoctor);
                tempMenu.AddMenuItem("Write Prescription", onExaminePatientWritePrescriptionClick);
                tempMenu.AddMenuItem("Prescribe Tests", onExaminePatientPrescribeTestsClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuDoctor.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuDoctor.AddMenuItem("Log Out", onLogOut);

            ParentForm.Controls.Add(MainMenuDoctor.GetHMSMenu());

            //
            // Now Creating Receptionist Group Menu
            //
            MainMenuReceptionist = new HMSMenu(7, this, null);

            MainMenuReceptionist.AddMenuItem("Patient Registration", null);
                tempMenu = new HMSMenu(5, this, MainMenuReceptionist);
                tempMenu.AddMenuItem("Create Patient Profile", onPatientRegistrationCreatePatientProfileClick);
                tempMenu.AddMenuItem("Update Patient Profile", onPatientRegistrationUpdatePatientProfileClick);
                tempMenu.AddMenuItem("Delete Patient Profile", onPatientRegistrationDeletePatientProfileClick);
                tempMenu.AddMenuItem("Print Patient Profile", onPatientRegistrationPrintPatientProfileClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuReceptionist.GetLastItem().SetSubMenu(tempMenu);    
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuReceptionist.AddMenuItem("In-Patient Record", onInPatientRecordClick);
            MainMenuReceptionist.AddMenuItem("Out-Patient Report", onOutPatientRecordClick);

            MainMenuReceptionist.AddMenuItem("Examine Patient", null);
                tempMenu = new HMSMenu(3, this, MainMenuReceptionist);
                tempMenu.AddMenuItem("Write Prescription", onExaminePatientWritePrescriptionClick);
                tempMenu.AddMenuItem("Prescribe Tests", onExaminePatientPrescribeTestsClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuReceptionist.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuReceptionist.AddMenuItem("Blood Bank", null);
                tempMenu = new HMSMenu(5, this, MainMenuReceptionist);
                tempMenu.AddMenuItem("Check Blood Bank", onBloodBankCheckBankClick);
                tempMenu.AddMenuItem("Add Blood Sample", onBloodBankAddSampleClick);
                tempMenu.AddMenuItem("Delete Blood Sample", onBloodBankDeleteSampleClick);
                tempMenu.AddMenuItem("Print Blood Summary", onBloodBankPrintSummaryClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuReceptionist.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuReceptionist.AddMenuItem("Blood Donors Record", null);
                tempMenu = new HMSMenu(5, this, MainMenuReceptionist);
                tempMenu.AddMenuItem("Add Blood Donor", onBloodDonorsAddDonorClick);
                tempMenu.AddMenuItem("Edit Blood Donor", onBloodDonorsEditDonorClick);
                tempMenu.AddMenuItem("Delete Blood Donor", onBloodDonorsDeleteDonorClick);
                tempMenu.AddMenuItem("Print Donor's Record", onBloodDonorsPrintDonorClick);
                tempMenu.AddMenuItem("Back to Main Menu", onExitMenu);
                MainMenuReceptionist.GetLastItem().SetSubMenu(tempMenu);
                ParentForm.Controls.Add(tempMenu.GetHMSMenu());

            MainMenuReceptionist.AddMenuItem("Log Out", onLogOut);

            ParentForm.Controls.Add(MainMenuReceptionist.GetHMSMenu());

        }

        public void ShowMainMenu(String userGroup)
        {
            if (userGroup.CompareTo("Administrator") == 0)
                MainMenu = MainMenuAdministrator;

            else if (userGroup.CompareTo("Doctor") == 0)
                MainMenu = MainMenuDoctor;

            else if (userGroup.CompareTo("Receptionist") == 0)
                MainMenu = MainMenuReceptionist;

            else
                MainMenu = null;

            CurrentMenu = MainMenu;
            CurrentMenu.ShowMenu();
            CurrentMenu.SelectFirstItem();
        }

        public void HideMainMenu()
        {
            CurrentMenu.HideMenu();
        }

        public Color GetItemColor()
        {
            return ItemColor;
        }

        public Color GetFontColor()
        {
            return FontColor;
        }

        public Color GetSelectedItemColor()
        {
            return SelectedItemColor;
        }

        public Color GetSelectedFontColor()
        {
            return SelectedFontColor;
        }

        public Font GetFont()
        {
            return ItemFont;
        }

        public int GetItemWidth()
        {
            return ItemWidth;
        }

        public int GetItemHeight()
        {
            return ItemHeight;
        }

        public Form GetParentForm()
        {
            return ParentForm;
        }

        public void SetInputSource(HMSInputSource inputSource)
        {
            InputSource = inputSource;
        }

        public HMSInputSource GetInputSource()
        {
            return InputSource;
        }

        public void ProcessKeyboardInput(KeyEventArgs e)
        {
            if(InputSource != HMSInputSource.Keyboard)
                SetInputSource(HMSInputSource.Keyboard);

            if (CurrentMenu != null)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        CurrentMenu.SelectNextItem();
                        break;

                    case Keys.Up:
                        CurrentMenu.SelectPreviousItem();
                        break;

                    case Keys.Return:
                        if (CurrentMenu.GetSelectedItem().GetCBFunction() != null)
                        {
                            CurrentMenu.GetSelectedItem().GetCBFunction()();
                        }
                        else if (CurrentMenu.GetSelectedItem().GetSubMenu() != null)
                        {
                            this.OpenSubMenu();
                        }

                        break;

                    case Keys.Escape:
                        if (CurrentMenu.GetParentMenu() != null)
                        {
                            CloseSubMenu();
                        }
                        break;
                }
            }
        }

        public void OpenSubMenu()
        {
            CurrentMenu.HideMenu();
            CurrentMenu = CurrentMenu.GetSelectedItem().GetSubMenu();
            CurrentMenu.ShowMenu();
        }

        public void CloseSubMenu()
        {
            CurrentMenu.HideMenu();
            CurrentMenu = CurrentMenu.GetParentMenu();
            CurrentMenu.ShowMenu();
        }

        //
        // Delegates for Menu Items
        //
        private void onExitMenu()
        {
            if (CurrentMenu.GetParentMenu() != null)
            {
                CloseSubMenu();
            }
        }

        private void onLogOut()
        {
            logOutCBFunction();
        }

        private void onUserRecordAddUserClick()
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();

            if (addUserForm.ShouldAddRecord())
            {
                while (!HMSDatabase.AddUserRecord(addUserForm.GetFullName(),
                                                  addUserForm.GetDesignation(),
                                                  addUserForm.GetUserName(),
                                                  addUserForm.GetPassword(),
                                                  addUserForm.GetUserGroup(),
                                                  addUserForm.GetPhone(),
                                                  addUserForm.GetAddress(),
                                                  addUserForm.GetCity()))
                {
                    addUserForm.ShowDialog();
                    if (!addUserForm.ShouldAddRecord())
                        break;
                }
            }
        }

        private void onUserRecordEditUserClick()
        {
            if (HMSDatabase.UserRecordExists())
            {
                SelectUserRecordForm userRecordForm = new SelectUserRecordForm();
                userRecordForm.ShowDialog();
                if (userRecordForm.ShouldChangeRecord())
                {
                    String Username = userRecordForm.GetSelectedUsername();

                    EditUserRecordForm editUserRecordForm = new
                          EditUserRecordForm(Username,
                                             HMSDatabase.GetUserRecordFullName(Username),
                                             HMSDatabase.GetUserRecordDesignation(Username),
                                             HMSDatabase.GetUserRecordUserGroup(Username),
                                             HMSDatabase.GetUserRecordPhone(Username),
                                             HMSDatabase.GetUserRecordAddress(Username),
                                             HMSDatabase.GetUserRecordCity(Username));

                    editUserRecordForm.ShowDialog();

                    if (editUserRecordForm.ShouldChangeRecord())
                    {
                        String tempPassword;

                        if (editUserRecordForm.GetPassword().Length == 0)
                            tempPassword = HMSDatabase.DecryptPassword(HMSDatabase.GetUserRecordPassword(Username));
                        else
                            tempPassword = editUserRecordForm.GetPassword();

                        while (!HMSDatabase.UpdateUserRecord(Username,
                                                            editUserRecordForm.GetFullName(),
                                                            editUserRecordForm.GetDesignation(),
                                                            tempPassword,
                                                            editUserRecordForm.GetUserGroup(),
                                                            editUserRecordForm.GetPhone(),
                                                            editUserRecordForm.GetAddress(),
                                                            editUserRecordForm.GetCity()))
                        {
                            editUserRecordForm.ShowDialog();
                            if (!editUserRecordForm.ShouldChangeRecord())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no users registered in the system. Please Add Users to the Database, then print their record.",
                                "User Record Database Empty");
            }
        }

        private void onUserRecordDeleteUserClick()
        {
            if (HMSDatabase.UserRecordExists())
            {
                SelectUserRecordForm userRecordForm = new SelectUserRecordForm();
                userRecordForm.ShowDialog();
                if (userRecordForm.ShouldChangeRecord())
                {
                    if (HMSDatabase.GetLoggedInUsername().CompareTo(userRecordForm.GetSelectedUsername()) == 0)
                    {
                        MessageBox.Show("You cannot delete your own User Account, " +
                                        "Please Log-in through some other Administrator Account to delete this Account.",
                                        "Invalid Delete Account Operation");
                    }
                    else if (MessageBox.Show("Are you sure you want to delete '" + userRecordForm.GetSelectedUsername() + "' from the System. " +
                                       "This operation cannot be undone!",
                                       "Delete User Record Warning",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        while (!HMSDatabase.DeleteUserRecord(userRecordForm.GetSelectedUsername()))
                        {
                            userRecordForm.ShowDialog();
                            if (!userRecordForm.ShouldChangeRecord())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no users registered in the system. Please Add Users to the Database, then print their record.",
                                "User Record Database Empty");
            }
        }

        private void onUserRecordPrintUserClick()
        {
            if (HMSDatabase.UserRecordExists())
            {
                PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                         "SELECT * FROM UserRecordTable ORDER BY Name",
                                                                         "UserRecordTable",
                                                                         "UserRecordReport.rpt");
                printReportsForm.Text = "Print Employee Profile";
                printReportsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are currently no users registered in the system. Please Add Users to the Database, then print their record.",
                                "User Record Database Empty");
            }
        }
      
        private void onPatientRegistrationCreatePatientProfileClick()
        {
            DateTime thisTime = DateTime.Now;
            String RegistrationDate = thisTime.Day.ToString() + "-" + thisTime.Month.ToString() + "-" + thisTime.Year.ToString();
            String NextPMRN = thisTime.Year.ToString() + thisTime.Month.ToString() + thisTime.Day.ToString() +
                              "-" + (HMSDatabase.PatientsOnDate(RegistrationDate) + 1).ToString();

            AddPatientForm addPatientForm = new AddPatientForm(NextPMRN, RegistrationDate);
            addPatientForm.ShowDialog();

            if (addPatientForm.ShouldAddRecord())
            {
                while (!HMSDatabase.AddPatientRecord(NextPMRN,
                                                     addPatientForm.GetName(),
                                                     addPatientForm.GetGender(),
                                                     addPatientForm.GetAddress(),
                                                     addPatientForm.GetCity(),
                                                     addPatientForm.GetPhone(),
                                                     RegistrationDate))
                {
                    addPatientForm.ShowDialog();
                    if (!addPatientForm.ShouldAddRecord())
                        break;
                }
            }
        }

        private void onPatientRegistrationUpdatePatientProfileClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();
                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    String PMRN = selectPatientRecordForm.GetSelectedPatientPMRN();

                    EditPatientRecordForm editPatientRecordForm = new
                       EditPatientRecordForm(PMRN,
                                             HMSDatabase.GetPatientRecordName(PMRN),
                                             HMSDatabase.GetPatientRecordGender(PMRN),
                                             HMSDatabase.GetPatientRecordAddress(PMRN),
                                             HMSDatabase.GetPatientRecordCity(PMRN),
                                             HMSDatabase.GetPatientRecordPhone(PMRN),
                                             HMSDatabase.GetPatientRecordRegistrationDate(PMRN));

                    editPatientRecordForm.ShowDialog();

                    if (editPatientRecordForm.ShouldChangeRecord())
                    {
                        while (!HMSDatabase.UpdatePatientRecord(PMRN,
                                                                editPatientRecordForm.GetName(),
                                                                editPatientRecordForm.GetGender(),
                                                                editPatientRecordForm.GetAddress(),
                                                                editPatientRecordForm.GetCity(),
                                                                editPatientRecordForm.GetPhone()))
                        {
                            editPatientRecordForm.ShowDialog();
                            if (!editPatientRecordForm.ShouldChangeRecord())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }

        private void onPatientRegistrationDeletePatientProfileClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();
                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    if (MessageBox.Show("Are you sure you want to delete '" +
                                        HMSDatabase.GetPatientRecordName(selectPatientRecordForm.GetSelectedPatientPMRN()) + " (PMRN: " +
                                        selectPatientRecordForm.GetSelectedPatientPMRN() + ")' from the System. " +
                                        "This operation cannot be undone!",
                                        "Delete Patient Record Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        while (!HMSDatabase.DeletePatientRecord(selectPatientRecordForm.GetSelectedPatientPMRN()))
                        {
                            selectPatientRecordForm.ShowDialog();
                            if (!selectPatientRecordForm.ShouldChangeRecord())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }

        private void onPatientRegistrationPrintPatientProfileClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();
                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                             "SELECT * FROM PatientRecordTable WHERE PMRN = '" + selectPatientRecordForm.GetSelectedPatientPMRN() + "'",
                                                                             "PatientRecordTable",
                                                                             "PatientProfileReport.rpt");
                    printReportsForm.Text = "Print Patient Profile";
                    printReportsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }

        private void onInPatientRecordClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();
                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    InPatientEntryForm inPatientForm = new InPatientEntryForm(selectPatientRecordForm.GetSelectedPatientPMRN(),
                                                                              HMSDatabase.GetPatientRecordName(selectPatientRecordForm.GetSelectedPatientPMRN()));
                    inPatientForm.ShowDialog();

                    if (inPatientForm.ShouldEnter())
                    {
                        Boolean printReport = true;
                        while(!HMSDatabase.AddInPatientRecord(inPatientForm.GetAppointmentID(),
                                                              selectPatientRecordForm.GetSelectedPatientPMRN(),
                                                              HMSDatabase.GetPatientRecordName(selectPatientRecordForm.GetSelectedPatientPMRN()),
                                                              inPatientForm.GetDescription(),
                                                              inPatientForm.GetDoctorName(),
                                                              inPatientForm.GetServiceCharges(),
                                                              inPatientForm.GetTime(),
                                                              inPatientForm.GetDate()))
                        {
                            inPatientForm.ShowDialog();
                            if (!inPatientForm.ShouldEnter())
                            {
                                printReport = false;
                                break;
                            }
                        }

                        if (printReport)
                        {
                            PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                                     "SELECT * FROM InPatientTable WHERE AppointmentID = '" + 
                                                                                     inPatientForm.GetAppointmentID() + "'",
                                                                                     "InPatientTable",
                                                                                     "InPatientReport.rpt");
                            printReportsForm.Text = "Print Patient Appointment Card";
                            printReportsForm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }

        private void onOutPatientRecordClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();

                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    String PMRN = selectPatientRecordForm.GetSelectedPatientPMRN();
                    String Name = HMSDatabase.GetPatientRecordName(PMRN);

                    OutPatientForm outPatientForm = new OutPatientForm(PMRN, Name);
                    outPatientForm.ShowDialog();

                    while (outPatientForm.ShouldAddRecord() || outPatientForm.ShouldDeleteRecord() || outPatientForm.ShouldPrintReport())
                    {
                        if (outPatientForm.ShouldAddRecord())
                        {
                            while (!HMSDatabase.AddOutPatientRecord(PMRN,
                                                                    Name,
                                                                    outPatientForm.GetCode(),
                                                                    outPatientForm.GetDescription(),
                                                                    outPatientForm.GetDate(),
                                                                    outPatientForm.GetServicesCharges()))
                            {
                                outPatientForm.ShowDialog();

                                if (!outPatientForm.ShouldAddRecord())
                                    break;
                            }
                        }

                        else if (outPatientForm.ShouldDeleteRecord())
                        {
                            while (!HMSDatabase.DeleteOutPatientRecord(outPatientForm.GetID()))
                            {
                                outPatientForm.ShowDialog();

                                if (!outPatientForm.ShouldDeleteRecord())
                                    break;
                            }
                        }

                        else if (outPatientForm.ShouldPrintReport())
                        {
                            if (HMSDatabase.OutPatientRecordExists())
                            {
                                PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                     "SELECT * FROM OutPatientTable WHERE PMRN = '" + PMRN + "'",
                                                                     "OutPatientTable",
                                                                     "OutPatientReport.rpt");

                                printReportsForm.Text = "Print Patient Expenses Sheet";
                                printReportsForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("There must be at least one item before  printing the report.",
                                                "Empty Report");
                            }
                        }

                        outPatientForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }
  
        private void onExaminePatientWritePrescriptionClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();

                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    String PMRN = selectPatientRecordForm.GetSelectedPatientPMRN();
                    String Name = HMSDatabase.GetPatientRecordName(PMRN);
                    String Prescription = HMSDatabase.GetPatientPrescription(PMRN);

                    PrescriptionForm prescriptionForm = new PrescriptionForm(PMRN, Name, Prescription);
                    prescriptionForm.ShowDialog();

                    if (prescriptionForm.ShouldPrintReport())
                    {
                        Boolean shouldPrint = true;
                        while (!HMSDatabase.AddPatientPrescription(PMRN, Name, prescriptionForm.GetPrescription()))
                        {
                            prescriptionForm.ShowDialog();

                            if (!prescriptionForm.ShouldPrintReport())
                            {
                                shouldPrint = false;
                                break;
                            }
                        }

                        if (shouldPrint)
                        {
                            PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                                     "SELECT * FROM PrescriptionTable WHERE PMRN = '" + PMRN + "'",
                                                                                     "PrescriptionTable",
                                                                                     "PrescriptionReport.rpt");
                            printReportsForm.Text = "Print Prescription Report";
                            printReportsForm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }

        private void onExaminePatientPrescribeTestsClick()
        {
            if (HMSDatabase.PatientRecordExists())
            {
                SelectPatientRecordForm selectPatientRecordForm = new SelectPatientRecordForm();
                selectPatientRecordForm.ShowDialog();

                if (selectPatientRecordForm.ShouldChangeRecord())
                {
                    String PMRN = selectPatientRecordForm.GetSelectedPatientPMRN();
                    String Name = HMSDatabase.GetPatientRecordName(selectPatientRecordForm.GetSelectedPatientPMRN());

                    LabTestsForm labTestForm = new LabTestsForm(PMRN, Name);
                    labTestForm.ShowDialog();

                    while (labTestForm.ShouldAddRecord() || labTestForm.ShouldDeleteRecord() || labTestForm.ShouldPrintReport())
                    {
                        if (labTestForm.ShouldAddRecord())
                        {
                            while (!HMSDatabase.AddLabTest(PMRN,
                                                           Name,
                                                           labTestForm.GetTestID(),
                                                           labTestForm.GetTestName(),
                                                           labTestForm.GetServicesCharges(),
                                                           labTestForm.GetTime(),
                                                           labTestForm.GetDate()))
                            {
                                labTestForm.ShowDialog();

                                if (!labTestForm.ShouldAddRecord())
                                    break;
                            }
                        }
                        else if (labTestForm.ShouldDeleteRecord())
                        {
                            while (!HMSDatabase.DeleteLabTest(labTestForm.GetID()))
                            {
                                labTestForm.ShowDialog();

                                if (!labTestForm.ShouldDeleteRecord())
                                    break;
                            }
                        }
                        else if (labTestForm.ShouldPrintReport())
                        {
                            if (HMSDatabase.LabTestsRecordExists())
                            {
                                PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                                         "SELECT * FROM LabTestsTable WHERE PMRN = '" + PMRN + "'",
                                                                                         "LabTestsTable",
                                                                                         "LabTestsReport.rpt");
                                printReportsForm.Text = "Print Lab Test Report";
                                printReportsForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("There must be at least one test before  printing the report.",
                                                "Empty Report");
                            }
                        }

                        labTestForm.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Patient Profiles in the system. Please create Patient Profile first.",
                                "Patient Profile Database Empty");
            }
        }
        
        private void onBloodBankCheckBankClick()
        {
            if (HMSDatabase.BloodBankRecordExists())
            {
                BloodBankForm bloodBankForm = new BloodBankForm();
                bloodBankForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are currently no Blood Samples in Blood Bank. Please Add Blood Samples to Blood Bank first.",
                                "Blood Bank Empty");
            }
        }

        private void onBloodBankAddSampleClick()
        {
            if (HMSDatabase.BloodBankRecordExists())
            {
                String SampleID = (DateTime.Now.Ticks / 10000000).ToString();
                AddBloodSampleForm addBloodSampleForm = new AddBloodSampleForm(SampleID);
                addBloodSampleForm.ShowDialog();

                if (addBloodSampleForm.ShouldAddRecord())
                {
                    while (!HMSDatabase.AddBloodBankSample(SampleID,
                                                          addBloodSampleForm.GetBloodGroup(),
                                                          addBloodSampleForm.GetBloodQuantity(),
                                                          addBloodSampleForm.GetCollectionDate(),
                                                          addBloodSampleForm.GetExpiryDate()))
                    {
                        addBloodSampleForm.ShowDialog();

                        if (!addBloodSampleForm.ShouldAddRecord())
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Blood Samples in Blood Bank. Please Add Blood Samples to Blood Bank first.",
                                "Blood Bank Empty");
            }
        }

        private void onBloodBankDeleteSampleClick()
        {
            if (HMSDatabase.BloodBankRecordExists())
            {
                BloodBankForm bloodBankForm = new BloodBankForm();
                bloodBankForm.ShowDialog();

                if (bloodBankForm.RecordSelected())
                {
                    if (MessageBox.Show("Are you sure you want to delete Blood Sample (ID: " +
                                        bloodBankForm.GetSelectedSampleID() + " ) from database?\n" +
                                        "This operation cannot be undone!",
                                        "Delete Blood Sample Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        while (!HMSDatabase.DeleteBloodBankSample(bloodBankForm.GetSelectedSampleID()))
                        {
                            bloodBankForm.ShowDialog();
                            if (!bloodBankForm.RecordSelected())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Blood Samples in Blood Bank. Please Add Blood Samples to Blood Bank first.",
                                "Blood Bank Empty");
            }
        }

        private void onBloodBankPrintSummaryClick()
        {
            if (HMSDatabase.BloodBankRecordExists())
            {
                PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                         "SELECT * FROM BloodBankTable",
                                                                         "BloodBankTable",
                                                                         "BloodBankSummaryReport.rpt");
                printReportsForm.Text = "Print Blood Bank Summary";
                printReportsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are currently no Blood Samples in Blood Bank. Please Add Blood Samples to Blood Bank first.",
                                "Blood Bank Empty");
            }
        }

        private void onBloodDonorsAddDonorClick()
        {
            BloodDonorsForm bloodDonorsForm = new BloodDonorsForm();
            bloodDonorsForm.ShowDialog();

            if (bloodDonorsForm.ShouldChangeRecord())
            {
                while (!HMSDatabase.AddBloodDonorRecord(bloodDonorsForm.GetName(),
                                                        bloodDonorsForm.GetBloodGroup(),
                                                        bloodDonorsForm.GetPhone(),
                                                        bloodDonorsForm.GetAddress()))
                {
                    bloodDonorsForm.ShowDialog();
                    if (!bloodDonorsForm.ShouldChangeRecord())
                        break;
                }
            }
        }

        private void onBloodDonorsEditDonorClick()
        {
            if (HMSDatabase.BloodDonorRecordExists())
            {
                SelectBloodDonorForm selectBloodDonorForm = new SelectBloodDonorForm();
                selectBloodDonorForm.ShowDialog();
                if (selectBloodDonorForm.RecordSelected())
                {
                    String SelectedID = selectBloodDonorForm.GetSelectedDonorID();
                    BloodDonorsForm bloodDonorsForm = new
                       BloodDonorsForm(HMSDatabase.GetBloodDonorName(SelectedID),
                                       HMSDatabase.GetBloodDonorBloodGroup(SelectedID),
                                       HMSDatabase.GetBloodDonorPhone(SelectedID),
                                       HMSDatabase.GetBloodDonorAddress(SelectedID));

                    bloodDonorsForm.ShowDialog();

                    if (bloodDonorsForm.ShouldChangeRecord())
                    {
                        while (!HMSDatabase.UpdateBloodDonorRecord(SelectedID,
                                                                   bloodDonorsForm.GetName(),
                                                                   bloodDonorsForm.GetBloodGroup(),
                                                                   bloodDonorsForm.GetPhone(),
                                                                   bloodDonorsForm.GetAddress()))
                        {
                            bloodDonorsForm.ShowDialog();
                            if (!bloodDonorsForm.ShouldChangeRecord())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Blood Donors registered in the system. Please Add Blood Donors to the Database, then print their record.",
                                "Blood Donors Record Database Empty");
            }
        }

        private void onBloodDonorsDeleteDonorClick()
        {
            if (HMSDatabase.BloodDonorRecordExists())
            {
                SelectBloodDonorForm selectBloodDonorForm = new SelectBloodDonorForm();
                selectBloodDonorForm.ShowDialog();
                if (selectBloodDonorForm.RecordSelected())
                {
                    if (MessageBox.Show("Are you sure you want to delete '" + HMSDatabase.GetBloodDonorName(selectBloodDonorForm.GetSelectedDonorID()) +
                                        "' from the System. " +
                                        "This operation cannot be undone!",
                                        "Delete Blood Donor Record Warning",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        while (!HMSDatabase.DeleteBloodDonorRecord(selectBloodDonorForm.GetSelectedDonorID()))
                        {
                            selectBloodDonorForm.ShowDialog();
                            if (!selectBloodDonorForm.RecordSelected())
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("There are currently no Blood Donors registered in the system. Please Add Blood Donors to the Database, then print their record.",
                                "Blood Donors Record Database Empty");
            }
        }

        private void onBloodDonorsPrintDonorClick()
        {
            if (HMSDatabase.BloodDonorRecordExists())
            {
                PrintReportsForm printReportsForm = new PrintReportsForm(HMSDatabase.GetDBConnectionString(),
                                                                         "SELECT * FROM BloodDonorsTable ORDER BY Name",
                                                                         "BloodDonorsTable",
                                                                         "BloodDonorsReport.rpt");
                printReportsForm.Text = "Print Blood Donors Record";
                printReportsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are currently no Blood Donors registered in the system. Please Add Blood Donors to the Database, then print their record.",
                                "Blood Donors Record Database Empty");
            }
        }

    }



    class HMSMenu
    {
        private HMSMenu ParentMenu;
        private HMSMenuSystem MenuSystem;

        private int Items;
        private int MaxItems;
        private HMSMenuItem FirstItem;
        private HMSMenuItem LastItem;
        private HMSMenuItem SelectedItem;

        private GroupBox gbMenu; // The container for menu items

        public HMSMenu(int maxItems, HMSMenuSystem menuSystem, HMSMenu parentMenu)
        {
            ParentMenu = parentMenu;
            MenuSystem = menuSystem;
            MaxItems = maxItems;

            Items = 0;
            gbMenu = new GroupBox();
            gbMenu.Hide();
            gbMenu.Width = MenuSystem.GetItemWidth() + 20;
            gbMenu.Height = MenuSystem.GetItemHeight() * maxItems + 35;
            gbMenu.Left = (menuSystem.GetParentForm().Width - gbMenu.Width - 8) / 2;
            gbMenu.Top = (menuSystem.GetParentForm().Height - gbMenu.Height - 38) / 2;
            gbMenu.Anchor = AnchorStyles.None;
        }

        public void AddMenuItem(String label, ItemCBFunction cbFunction)
        {
            if (Items == 0)
            {
                FirstItem = new HMSMenuItem(MenuSystem, this, cbFunction, label, 10, 20, MenuSystem.GetItemWidth(), MenuSystem.GetItemHeight());
                FirstItem.SetNextItem(FirstItem);
                FirstItem.SetPreviousItem(FirstItem);
                LastItem = FirstItem;
                SelectFirstItem();

                gbMenu.Controls.Add(LastItem.GetHMSMenuItem());
            }
            else if (Items < MaxItems)
            {
                HMSMenuItem temp = new HMSMenuItem(MenuSystem, this, cbFunction, label, 10, (this.Items * 40 + 20), MenuSystem.GetItemWidth(), MenuSystem.GetItemHeight());
                FirstItem.SetPreviousItem(temp);
                LastItem.SetNextItem(temp);
                temp.SetNextItem(FirstItem);
                temp.SetPreviousItem(LastItem);
                LastItem = temp;

                gbMenu.Controls.Add(LastItem.GetHMSMenuItem());
            }
            this.Items++;
        }

        public GroupBox GetHMSMenu()
        {
            return gbMenu;
        }

        public void ShowMenu()
        {
            gbMenu.Show();
        }

        public void HideMenu()
        {
            gbMenu.Hide();
        }

        public void SelectFirstItem()
        {
            if (SelectedItem != null)
                SelectedItem.DeSelectItem();
            FirstItem.SelectItem();
            SelectedItem = FirstItem;
        }

        public void SelectNextItem()
        {
            SelectedItem.DeSelectItem();
            SelectedItem = SelectedItem.GetNextItem();
            SelectedItem.SelectItem();
        }

        public void SelectPreviousItem()
        {
            SelectedItem.DeSelectItem();
            SelectedItem = SelectedItem.GetPreviousItem();
            SelectedItem.SelectItem();
        }

        public HMSMenuItem GetFirstItem()
        {
            return FirstItem;
        }

        public HMSMenuItem GetLastItem()
        {
            return LastItem;
        }

        public void SetSelectedItem(HMSMenuItem selectedItem)
        {
            SelectedItem = selectedItem;
        }

        public HMSMenuItem GetSelectedItem()
        {
            return SelectedItem;
        }

        public HMSMenu GetParentMenu()
        {
            return ParentMenu;
        }
    }



    class HMSMenuItem
    {
        private static HMSMenuSystem MenuSystem;
        private String Label;
        private HMSMenu ParentMenu;
        private HMSMenu SubMenu;
        private HMSMenuItem NextItem;
        private HMSMenuItem PreviousItem;
        ItemCBFunction CBFunction;

        private Label lblItem; // This is the actual Menu Item
        private static Point prvMousePos;

        public HMSMenuItem(HMSMenuSystem menuSystem, HMSMenu parentMenu, ItemCBFunction cbFunction, String label, int left, int top, int width, int height)
        {
            Label = label;
            MenuSystem = menuSystem;
            ParentMenu = parentMenu;
            NextItem = null;
            PreviousItem = null;
            SubMenu = null;

            if (cbFunction != null)
            {
                CBFunction = new ItemCBFunction(cbFunction);
            }

            lblItem = new Label();

            lblItem.ForeColor = MenuSystem.GetFontColor();
            lblItem.BackColor = MenuSystem.GetItemColor();
            lblItem.Font = MenuSystem.GetFont();

            lblItem.Left = left;
            lblItem.Top = top;
            lblItem.Width = width;
            lblItem.Height = height;
            lblItem.Text = label;

            lblItem.Anchor = AnchorStyles.None;
            lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblItem.BorderStyle = System.Windows.Forms.BorderStyle.None;

            lblItem.Click += new System.EventHandler(onItemClick);
            lblItem.MouseMove += new System.Windows.Forms.MouseEventHandler(onItemMouseMove);
        }

        public void SetNextItem(HMSMenuItem nextItem)
        {
            NextItem = nextItem;
        }

        public HMSMenuItem GetNextItem()
        {
            return NextItem;
        }

        public void SetPreviousItem(HMSMenuItem previousItem)
        {
            PreviousItem = previousItem;
        }

        public HMSMenuItem GetPreviousItem()
        {
            return PreviousItem;
        }

        public Label GetHMSMenuItem()
        {
            return lblItem;
        }

        public HMSMenu GetParentMenu()
        {
            return ParentMenu;
        }

        public void SetSubMenu(HMSMenu subMenu)
        {
            SubMenu = subMenu;
        }

        public HMSMenu GetSubMenu()
        {
            return SubMenu;
        }

        public ItemCBFunction GetCBFunction()
        {
            return CBFunction;
        }

        public String GetLabel()
        {
            return Label;
        }

        public void SelectItem()
        {
            lblItem.ForeColor = MenuSystem.GetSelectedFontColor();
            lblItem.BackColor = MenuSystem.GetSelectedItemColor();
            lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public void DeSelectItem()
        {
            lblItem.ForeColor = MenuSystem.GetFontColor();
            lblItem.BackColor = MenuSystem.GetItemColor();
            lblItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void onItemClick(object sender, EventArgs e)
        {
            if (ParentMenu.GetSelectedItem() != this)
            {
                MenuSystem.SetInputSource(HMSInputSource.Mouse);
                ParentMenu.GetSelectedItem().DeSelectItem();
                ParentMenu.SetSelectedItem(this);
                this.SelectItem();
            }

            if (CBFunction != null)
                CBFunction();
            else if (SubMenu != null)
                MenuSystem.OpenSubMenu();

        }

        private void onItemMouseMove(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - prvMousePos.X) > 2 || Math.Abs(e.Y - prvMousePos.Y) > 2)
            {
                if (MenuSystem.GetInputSource() == HMSInputSource.Keyboard)
                {
                    MenuSystem.SetInputSource(HMSInputSource.Mouse);
                }

                prvMousePos.X = e.X;
                prvMousePos.Y = e.Y;
            }

            if (MenuSystem.GetInputSource() == HMSInputSource.Mouse)
            {
                if (ParentMenu.GetSelectedItem() != this)
                {
                    ParentMenu.GetSelectedItem().DeSelectItem();
                    ParentMenu.SetSelectedItem(this);
                    this.SelectItem();
                }
            }
        }
    }
}
