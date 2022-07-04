using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
//using System.Security.Cryptography;
using System.Collections;

namespace HospitalManagementSystem
{
    class HMSDBManagement
    {
        private OleDbDataAdapter UserRecordDataAdapter,
                                 PatientRecordDataAdapter,
                                 BloodDonorsRecordDataAdapter,
                                 BloodBankRecordDataAdapter,
                                 InPatientRecordDataAdapter,
                                 OutPatientRecordDataAdapter,
                                 LabTestsRecordDataAdapter,
                                 PrescriptionRecordDataAdapter;

        private DataSet UserRecordDataSet, 
                        PatientRecordDataSet, 
                        BloodDonorsRecordDataSet, 
                        BloodBankRecordDataSet,
                        InPatientRecordDataSet,
                        OutPatientRecordDataSet,
                        LabTestsRecordDataSet,
                        PrescriptionRecordDataSet;

        private DataTable UserRecordDataTable, 
                          PatientRecordDataTable, 
                          BloodDonorsRecordDataTable, 
                          BloodBankRecordDataTable,
                          InPatientRecordDataTable,
                          OutPatientRecordDataTable,
                          LabTestsRecordDataTable,
                          PrescriptionRecordDataTable;

        private String DBConnectionString;
        private String LoggedInUsername;

        public HMSDBManagement(String DatabasePath)
        {
            DBConnectionString = "provider=Microsoft.JET.OLEDB.4.0; data source = " + DatabasePath;

            UserRecordDataAdapter = new OleDbDataAdapter();
            PatientRecordDataAdapter = new OleDbDataAdapter();
            BloodDonorsRecordDataAdapter = new OleDbDataAdapter();
            BloodBankRecordDataAdapter = new OleDbDataAdapter();
            InPatientRecordDataAdapter = new OleDbDataAdapter();
            OutPatientRecordDataAdapter = new OleDbDataAdapter();
            LabTestsRecordDataAdapter = new OleDbDataAdapter();
            PrescriptionRecordDataAdapter = new OleDbDataAdapter();

            // Define INSERT, UPDATE, and DELETE SQL Commands to use.
            BuildCommands(DBConnectionString);

            // Declare and fill the in-memory dataset from the database
            try
            {
                UserRecordDataSet = new DataSet();
                UserRecordDataSet.CaseSensitive = true;
                UserRecordDataAdapter.Fill(UserRecordDataSet, "UserRecordTable");
                UserRecordDataTable = UserRecordDataSet.Tables["UserRecordTable"];

                PatientRecordDataSet = new DataSet();
                PatientRecordDataSet.CaseSensitive = true;
                PatientRecordDataAdapter.Fill(PatientRecordDataSet, "PatientRecordTable");
                PatientRecordDataTable = PatientRecordDataSet.Tables["PatientRecordTable"];

                BloodDonorsRecordDataSet = new DataSet();
                BloodDonorsRecordDataSet.CaseSensitive = true;
                BloodDonorsRecordDataAdapter.Fill(BloodDonorsRecordDataSet, "BloodDonorsTable");
                BloodDonorsRecordDataTable = BloodDonorsRecordDataSet.Tables["BloodDonorsTable"];

                BloodBankRecordDataSet = new DataSet();
                BloodBankRecordDataSet.CaseSensitive = true;
                BloodBankRecordDataAdapter.Fill(BloodBankRecordDataSet, "BloodBankTable");
                BloodBankRecordDataTable = BloodBankRecordDataSet.Tables["BloodBankTable"];

                InPatientRecordDataSet = new DataSet();
                InPatientRecordDataSet.CaseSensitive = true;
                InPatientRecordDataAdapter.Fill(InPatientRecordDataSet, "InPatientTable");
                InPatientRecordDataTable = InPatientRecordDataSet.Tables["InPatientTable"];

                OutPatientRecordDataSet = new DataSet();
                OutPatientRecordDataSet.CaseSensitive = true;
                OutPatientRecordDataAdapter.Fill(OutPatientRecordDataSet, "OutPatientTable");
                OutPatientRecordDataTable = OutPatientRecordDataSet.Tables["OutPatientTable"];

                LabTestsRecordDataSet = new DataSet();
                LabTestsRecordDataSet.CaseSensitive = true;
                LabTestsRecordDataAdapter.Fill(LabTestsRecordDataSet, "LabTestsTable");
                LabTestsRecordDataTable = LabTestsRecordDataSet.Tables["LabTestsTable"];

                PrescriptionRecordDataSet = new DataSet();
                PrescriptionRecordDataSet.CaseSensitive = true;
                PrescriptionRecordDataAdapter.Fill(PrescriptionRecordDataSet, "PrescriptionTable");
                PrescriptionRecordDataTable = PrescriptionRecordDataSet.Tables["PrescriptionTable"];
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Database Initialization Error");
            }
        }

        public Boolean AddUserRecord(String FullName, String Designation, String UserName, String Password, String UserGroup, String Phone, String Address, String City)
        {
            if (IsUser(UserName))
            {
                MessageBox.Show("The username '" + UserName + "' is not available, Please choose some other unique username.",
                                "Add User Record Error");
                return false;
            }
            else
            {
                // create a new row, populate it
                DataRow newRow = UserRecordDataTable.NewRow();

                newRow["Name"] = FullName;
                newRow["Designation"] = Designation;
                newRow["Username"] = UserName;
                newRow["Password"] = EncryptPassword(Password);
                newRow["UserGroup"] = UserGroup;
                newRow["Contact"] = Phone;
                newRow["Address"] = Address;
                newRow["City"] = City;

                try
                {
                    UserRecordDataSet.Tables["UserRecordTable"].Rows.Add(newRow);
                    UserRecordDataAdapter.Update(UserRecordDataSet, "UserRecordTable");
                    UserRecordDataSet.AcceptChanges();
                    MessageBox.Show("New User '" + FullName + " (" + UserName + ")' successfully added to the system.",
                                    "Add User Record Success");
                    return true;
                }
                catch (OleDbException ex)
                {
                    UserRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Add User Record Error");
                    return false;
                }
            }
        }

        public Boolean UpdateUserRecord(String Username, String FullName, String Designation, String Password, String UserGroup, String Phone, String Address, String City)
        {
            DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];

            selectedRow.BeginEdit();
            selectedRow["Name"] = FullName.Trim();
            selectedRow["Designation"] = Designation.Trim();
            selectedRow["Password"] = EncryptPassword(Password.Trim());
            selectedRow["UserGroup"] = UserGroup.Trim();
            selectedRow["Contact"] = Phone.Trim();
            selectedRow["Address"] = Address.Trim();
            selectedRow["City"] = City.Trim();
            selectedRow.EndEdit();

            DataSet dsChanges = UserRecordDataSet.GetChanges(DataRowState.Modified);
            if (dsChanges.HasErrors)
            {
                UserRecordDataSet.RejectChanges();
                MessageBox.Show("User Record for '" + Username + "' couldn't be updated! The User's data is not correct.",
                                "Update User Record Error");
                return false;
            }
            else
            {
                try
                {
                    UserRecordDataAdapter.Update(dsChanges, "UserRecordTable");
                    UserRecordDataSet.AcceptChanges();
                    MessageBox.Show("User Record for '" + Username + "' successfully updated.",
                                    "Update User Record Success");
                    return true;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Update User Record Error");
                    return false;
                }
            }
        }

        public Boolean DeleteUserRecord(String Username)
        {
            DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
            selectedRow.Delete();

            try
            {
                UserRecordDataAdapter.Update(UserRecordDataSet, "UserRecordTable");
                UserRecordDataSet.AcceptChanges();
                MessageBox.Show("User Record for '" + Username + "' successfully deleted from the Database.",
                                "Delete User Record Success");
                return true;
            }
            catch (OleDbException ex)
            {
                UserRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Delete User Record Error");
                return false;
            }
        }

        public Boolean UserRecordExists()
        {
            return (UserRecordDataTable.Select().Length > 0);
        }

        public Boolean IsUser(String Username)
        {
            return (UserRecordDataTable.Select("Username = '" + Username + "'").Length > 0);
        }

        public String GetUserRecordFullName(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordDesignation(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["Designation"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordUserGroup(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["UserGroup"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordPhone(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["Contact"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordAddress(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["Address"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordCity(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["City"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetUserRecordPassword(String Username)
        {
            try
            {
                DataRow selectedRow = UserRecordDataTable.Select("Username = '" + Username + "'")[0];
                return selectedRow["Password"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public Boolean LoginUser(String Username, String Password)
        {
            if (Username.Length == 0 || Password.Length == 0)
                MessageBox.Show("The Username or Password fields cannot be empty.", "Username or Password not provided");

            else
            {
                if (IsUser(Username))
                {
                    if (Password.CompareTo(DecryptPassword(GetUserRecordPassword(Username))) == 0)
                    {
                        LoggedInUsername = Username;
                        return true;
                    }

                    else
                        MessageBox.Show("The Username and Password do not match", "Invalid Password");
                }
                else
                {
                    MessageBox.Show("The Username you entered is not registered in the database.", "Invalid Username");
                }
            }

            return false;
        }

        public String GetLoggedInUsername()
        {
            return LoggedInUsername;
        }

        public String EncryptPassword(String Password)
        {
            int KeySize = 384;
            String xmlKey = "<RSAKeyValue>" + 
                                "<Modulus>3pF7vcUsJZA7VOFKmAa84sWVN6DD1ST5n85BvEEtmv+3fGA9u3GJWZRP2Epz30Qj</Modulus>" + 
                                "<Exponent>AQAB</Exponent>" + 
                            "</RSAKeyValue>";

            String EncryptedString = EncryptString(Password, KeySize, xmlKey);

            return EncryptedString;
        }

        public String DecryptPassword(String EncryptedPassword)
        {
            int KeySize = 384;
            String xmlKey = "<RSAKeyValue>" +
                                "<Modulus>3pF7vcUsJZA7VOFKmAa84sWVN6DD1ST5n85BvEEtmv+3fGA9u3GJWZRP2Epz30Qj</Modulus>" +
                                "<Exponent>AQAB</Exponent>" +
                                "<P>9QlN8pZKwsE06vIVYyMpvTtP+K+Pj/m3</P>" +
                                "<Q>6IbTR4Tau7RcZGs7cxbMpINVKFsENPj1</Q>" +
                                "<DP>NW+2A/UqkJY5yBLK/zen3pCUvBLtJ+S5</DP>" +
                                "<DQ>HzVZThQKt36xl9i8lenNdZca6tusaN+x</DQ>" +
                                "<InverseQ>yCxQZZCgA9gUZGaX2YZLpLioLpbhxD4T</InverseQ>" +
                                "<D>tDuduARGhriww0CZlljGduFHv79pNl50YBDNZHeF1A6vcX3P9qK1Wgrl7vVD9iwJ</D>" +
                            "</RSAKeyValue>";

            return DecryptString(EncryptedPassword, KeySize, xmlKey);
        }

        private String EncryptString(String inputString, int dwKeySize, String xmlString)
        {
            return inputString;

            //RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            //rsaCryptoServiceProvider.FromXmlString(xmlString);
            //int keySize = dwKeySize / 8;
            //byte[] bytes = Encoding.UTF32.GetBytes(inputString);

            //// The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
            //// int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
            //int maxLength = keySize - 42;
            //int dataLength = bytes.Length;
            //int iterations = dataLength / maxLength;
            //StringBuilder stringBuilder = new StringBuilder();
            //for (int i = 0; i <= iterations; i++)
            //{
            //    byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength :dataLength - maxLength * i];
            //    Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
            //    byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);

            //    // Be aware the RSACryptoServiceProvider reverses the order of 
            //    // encrypted bytes. It does this after encryption and before 
            //    // decryption. If you do not require compatibility with Microsoft 
            //    // Cryptographic API (CAPI) and/or other vendors. Comment out the 
            //    // next line and the corresponding one in the DecryptString function.
            //    Array.Reverse(encryptedBytes);

            //    // Why convert to base 64?
            //    // Because it is the largest power-of-two base printable using only 
            //    // ASCII characters
            //    stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            //}
            //return stringBuilder.ToString();
        }

        private String DecryptString(String inputString, int dwKeySize, String xmlString)
        {
            return inputString;

            //RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            //rsaCryptoServiceProvider.FromXmlString(xmlString);
            //int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
            //int iterations = inputString.Length / base64BlockSize;
            //ArrayList arrayList = new ArrayList();
            //for (int i = 0; i < iterations; i++)
            //{
            //    byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));

            //    // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
            //    // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
            //    // Comment out the next line and the corresponding one in the EncryptString function.
            //    Array.Reverse(encryptedBytes);
            //    arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            //}
            //return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
        }

        public Boolean AddPatientRecord(String PMRN, String Name, String Gender, String Address, String City, String Phone, String RegistrationDate)
        {
            // create a new row, populate it
            DataRow newRow = PatientRecordDataTable.NewRow();

            newRow["PMRN"] = PMRN;
            newRow["Name"] = Name;
            newRow["Gender"] = Gender;
            newRow["Address"] = Address;
            newRow["City"] = City;
            newRow["Phone"] = Phone;
            newRow["RegistrationDate"] = RegistrationDate;

            try
            {
                PatientRecordDataSet.Tables["PatientRecordTable"].Rows.Add(newRow);
                PatientRecordDataAdapter.Update(PatientRecordDataSet, "PatientRecordTable");
                PatientRecordDataSet.AcceptChanges();

                MessageBox.Show("New Patient '" + Name + "' successfully added to the system.",
                                "Add Patient Record Success");
                return true;
            }
            catch (OleDbException ex)
            {
                PatientRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Add Patient Record Error");
                return false;
            }
        }

        public Boolean UpdatePatientRecord(String PMRN, String Name, String Gender, String Address, String City, String Phone)
        {
            DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];

            selectedRow.BeginEdit();
            selectedRow["Name"] = Name.Trim();
            selectedRow["Gender"] = Gender.Trim();
            selectedRow["Address"] = Address.Trim();
            selectedRow["City"] = City.Trim();
            selectedRow["Phone"] = Phone.Trim();
            selectedRow.EndEdit();

            DataSet dsChanges = PatientRecordDataSet.GetChanges(DataRowState.Modified);
            if (dsChanges.HasErrors)
            {
                PatientRecordDataSet.RejectChanges();
                MessageBox.Show("Patient Record for '" + Name + " (PMRN: " + PMRN + ")' couldn't be updated! The Patient's data is not correct.",
                                "Update Patient Record Error");
                return false;
            }
            else
            {
                try
                {
                    PatientRecordDataAdapter.Update(dsChanges, "PatientRecordTable");
                    PatientRecordDataSet.AcceptChanges();
                    MessageBox.Show("Patient Record for '" + Name + " (PMRN: " + PMRN + ")' successfully updated.",
                                    "Update Patient Record Success");
                    return true;
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Update Patient Record Error");
                    return false;
                }
            }
        }

        public Boolean DeletePatientRecord(String PMRN)
        {
            DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
            String Name = selectedRow["Name"].ToString();
            selectedRow.Delete();

            try
            {
                PatientRecordDataAdapter.Update(PatientRecordDataSet, "PatientRecordTable");
                PatientRecordDataSet.AcceptChanges();
                MessageBox.Show("Patient Record for '" + Name + " (PMRN: " + PMRN + ")' successfully deleted from the Database.",
                                "Delete Patient Record Success");
                return true;
            }
            catch (OleDbException ex)
            {
                PatientRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Delete Patient Record Error");
                return false;
            }
        }

        public Boolean PatientRecordExists()
        {
            return (PatientRecordDataTable.Select().Length > 0);
        }

        public Boolean IsPatient(String PMRN)
        {
            return (PatientRecordDataTable.Select("PMRN = '" + PMRN + "'").Length > 0);
        }

        public int PatientsOnDate(String RegistrationDate)
        {
            try
            {
                DataRow[] selectedRow = PatientRecordDataTable.Select("RegistrationDate = '" + RegistrationDate + "'");
                return selectedRow.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return 0;
        }

        public String GetPatientRecordName(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetPatientRecordGender(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["Gender"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetPatientRecordAddress(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["Address"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetPatientRecordCity(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["City"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetPatientRecordPhone(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["Phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetPatientRecordRegistrationDate(String PMRN)
        {
            try
            {
                DataRow selectedRow = PatientRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];
                return selectedRow["RegistrationDate"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public Boolean AddInPatientRecord(String AppointmentID, String PMRN, String Name, String Description, String DoctorName, String ServiceCharges, String Time, String Date)
        {
            if (InPatientRecordExists())
            {
                return UpdateInPatientRecord(AppointmentID, PMRN, Name, Description, DoctorName, ServiceCharges, Time, Date);
            }
            else
            {
                // create a new row, populate it
                DataRow newRow = InPatientRecordDataTable.NewRow();

                newRow["AppointmentID"] = AppointmentID;
                newRow["PMRN"] = PMRN;
                newRow["Name"] = Name;
                newRow["Description"] = Description;
                newRow["DoctorName"] = DoctorName;
                newRow["ServiceCharges"] = ServiceCharges;
                newRow["Time"] = Time;
                newRow["Date"] = Date;

                try
                {
                    InPatientRecordDataSet.Tables["InPatientTable"].Rows.Add(newRow);
                    InPatientRecordDataAdapter.Update(InPatientRecordDataSet, "InPatientTable");
                    InPatientRecordDataSet.AcceptChanges();

                    return true;
                }
                catch (OleDbException ex)
                {
                    InPatientRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Add In-Patient Record Error");
                    return false;
                }
            }
        }

        public Boolean UpdateInPatientRecord(String AppointmentID, String PMRN, String Name, String Description, String DoctorName, String ServiceCharges, String Time, String Date)
        {
            try
            {
                DataRow selectedRow = InPatientRecordDataTable.Select()[0];

                selectedRow.BeginEdit();
                selectedRow["AppointmentID"] = AppointmentID.Trim();
                selectedRow["PMRN"] = PMRN.Trim();
                selectedRow["Name"] = Name.Trim();
                selectedRow["Description"] = Description.Trim();
                selectedRow["DoctorName"] = DoctorName.Trim();
                selectedRow["ServiceCharges"] = ServiceCharges.Trim();
                selectedRow["Date"] = Date.Trim();
                selectedRow["Time"] = Time.Trim();
                selectedRow.EndEdit();

                DataSet dsChanges = InPatientRecordDataSet.GetChanges(DataRowState.Modified);
                if (dsChanges.HasErrors)
                {
                    InPatientRecordDataSet.RejectChanges();
                    MessageBox.Show("Patient Record for '" + Name + " (PMRN: " + PMRN + ")' couldn't be added! The Patient's data is not correct.",
                                    "In-Patient Record Error");
                    return false;
                }
                else
                {
                    try
                    {
                        InPatientRecordDataAdapter.Update(dsChanges, "InPatientTable");
                        InPatientRecordDataSet.AcceptChanges();
                        return true;
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message, "In-Patient Record Error");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return false;
        }

        public Boolean InPatientRecordExists()
        {
            return (InPatientRecordDataTable.Select().Length > 0);
        }

        public Boolean AddOutPatientRecord(String PMRN, String Name, String Code, String Description, String Date, String ServiceCharges)
        {
            // create a new row, populate it
            DataRow newRow = OutPatientRecordDataTable.NewRow();
            newRow["INDEX"] = (DateTime.Now.Ticks / 10000000).ToString();
            newRow["PMRN"] = PMRN;
            newRow["Name"] = Name;
            newRow["Code"] = Code;
            newRow["Description"] = Description;
            newRow["Date"] = Date;
            newRow["ServiceCharges"] = ServiceCharges;

            try
            {
                OutPatientRecordDataSet.Tables["OutPatientTable"].Rows.Add(newRow);
                OutPatientRecordDataAdapter.Update(OutPatientRecordDataSet, "OutPatientTable");
                OutPatientRecordDataSet.AcceptChanges();

                return true;
            }
            catch (OleDbException ex)
            {
                OutPatientRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Add Out-Patient Record Error");
                return false;
            }
        }

        public Boolean DeleteOutPatientRecord(String INDEX)
        {
            DataRow[] selectedRow = OutPatientRecordDataTable.Select("INDEX = '" + INDEX + "'");
            if (selectedRow.Length != 0)
            {

                selectedRow[0].Delete();
                try
                {
                    OutPatientRecordDataAdapter.Update(OutPatientRecordDataSet, "OutPatientTable");
                    OutPatientRecordDataSet.AcceptChanges();
                }
                catch (OleDbException ex)
                {
                    OutPatientRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Delete Out-Patient Record Error");
                    return false;
                }
            }
            return true;
        }

        public Boolean OutPatientRecordExists()
        {
            return (OutPatientRecordDataTable.Select().Length > 0);
        }

        public Boolean AddPatientPrescription(String PMRN, String Name, String Prescription)
        {
            if (PatientPrescriptionRecordExists(PMRN))
            {
                return UpdatePatientPrescription(PMRN, Name, Prescription);
            }
            else
            {
                // create a new row, populate it
                DataRow newRow = PrescriptionRecordDataTable.NewRow();
                newRow["PMRN"] = PMRN;
                newRow["Name"] = Name;
                newRow["Prescription"] = Prescription;
                try
                {
                    PrescriptionRecordDataSet.Tables["PrescriptionTable"].Rows.Add(newRow);
                    PrescriptionRecordDataAdapter.Update(PrescriptionRecordDataSet, "PrescriptionTable");
                    PrescriptionRecordDataSet.AcceptChanges();

                    return true;
                }
                catch (OleDbException ex)
                {
                    PrescriptionRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Add Patient Prescription Error");
                    return false;
                }
            }
        }
        
        public Boolean UpdatePatientPrescription(String PMRN, String Name, String Prescription)
        {
            try
            {
                DataRow selectedRow = PrescriptionRecordDataTable.Select("PMRN = '" + PMRN + "'")[0];

                selectedRow.BeginEdit();
                selectedRow["Name"] = Name.Trim();
                selectedRow["Prescription"] = Prescription.Trim();
                selectedRow.EndEdit();

                DataSet dsChanges = PrescriptionRecordDataSet.GetChanges(DataRowState.Modified);
                if (dsChanges.HasErrors)
                {
                    PrescriptionRecordDataSet.RejectChanges();
                    MessageBox.Show("Prescription Record for '" + Name + " (PMRN: " + PMRN + ")' couldn't be updated! The Prescription data is not correct.",
                                    "Update Prescription Record Error");
                    return false;
                }
                else
                {
                    try
                    {
                        PrescriptionRecordDataAdapter.Update(dsChanges, "PrescriptionTable");
                        PrescriptionRecordDataSet.AcceptChanges();
                        return true;
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message, "Update Prescription Record Error");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return false;
        }

        public String GetPatientPrescription(String PMRN)
        {
            DataRow[] selectedRow = PrescriptionRecordDataTable.Select("PMRN = '" + PMRN + "'");
            if (selectedRow.Length == 0)
                return "";
            else
                return selectedRow[0]["Prescription"].ToString();
        }

        public Boolean PatientPrescriptionRecordExists(String PMRN)
        {
            return (PrescriptionRecordDataTable.Select("PMRN = '" + PMRN + "'").Length > 0);
        }

        public Boolean AddLabTest(String PMRN, String Name, String TestID, String TestName, String ServiceCharges, String Time, String Date)
        {
            // create a new row, populate it
            DataRow newRow = LabTestsRecordDataTable.NewRow();
            newRow["ID"] = (DateTime.Now.Ticks / 10000000).ToString();
            newRow["PMRN"] = PMRN;
            newRow["Name"] = Name;
            newRow["TestID"] = TestID;
            newRow["TestName"] = TestName;
            newRow["ServiceCharges"] = ServiceCharges;
            newRow["Time"] = Time;
            newRow["Date"] = Date;

            try
            {
                LabTestsRecordDataSet.Tables["LabTestsTable"].Rows.Add(newRow);
                LabTestsRecordDataAdapter.Update(LabTestsRecordDataSet, "LabTestsTable");
                LabTestsRecordDataSet.AcceptChanges();

                return true;
            }
            catch (OleDbException ex)
            {
                LabTestsRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Delete Lab-Test Record Error");
                return false;
            }
        }

        public Boolean DeleteLabTest(String ID)
        {
            DataRow[] selectedRow = LabTestsRecordDataTable.Select("ID = '" + ID + "'");
            if (selectedRow.Length != 0)
            {

                selectedRow[0].Delete();
                try
                {
                    LabTestsRecordDataAdapter.Update(LabTestsRecordDataSet, "LabTestsTable");
                    LabTestsRecordDataSet.AcceptChanges();
                }
                catch (OleDbException ex)
                {
                    LabTestsRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Add Lab-Test Record Error");
                    return false;
                }
            }
            return true;
        }

        public Boolean LabTestsRecordExists()
        {
            return (LabTestsRecordDataTable.Select().Length > 0);
        }

        public Boolean AddBloodBankSample(String SampleID, String BloodGroup, String Quantity, String DateOfCollection, String ExpiryDate)
        {
            DataRow newRow = BloodBankRecordDataTable.NewRow();
            newRow["SampleID"] = SampleID;
            newRow["BloodGroup"] = BloodGroup;
            newRow["BloodQuantity"] = Quantity;
            newRow["DateOfCollection"] = DateOfCollection;
            newRow["ExpiryDate"] = ExpiryDate;

            try
            {
                BloodBankRecordDataSet.Tables["BloodBankTable"].Rows.Add(newRow);
                BloodBankRecordDataAdapter.Update(BloodBankRecordDataSet, "BloodBankTable");
                BloodBankRecordDataSet.AcceptChanges();
                MessageBox.Show("New Blood Sample successfully added to the Blood Bank.\n" +
                                "Sample ID for newly added sample is '" + SampleID + "'",
                                "Add Blood Sample Success");
                return true;
            }
            catch (OleDbException ex)
            {
                BloodBankRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Add Blood Sample Error");
                return false;
            }
        }

        public Boolean DeleteBloodBankSample(String SampleID)
        {
            try
            {
                DataRow selectedRow = BloodBankRecordDataTable.Select("SampleID = '" + SampleID + "'")[0];
                selectedRow.Delete();

                try
                {
                    BloodBankRecordDataAdapter.Update(BloodBankRecordDataSet, "BloodBankTable");
                    BloodBankRecordDataSet.AcceptChanges();
                    MessageBox.Show("Selected Blood Sample successfully deleted from the Blood Bank.",
                                    "Delete Blood Sample Success");
                    return true;
                }
                catch (OleDbException ex)
                {
                    BloodBankRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Delete Blood Donor Record Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return false;
        }

        public Boolean BloodBankRecordExists()
        {
            return (BloodBankRecordDataTable.Select().Length > 0);
        }

        public Boolean AddBloodDonorRecord(String Name, String BloodGroup, String Phone, String Address)
        {
            // create a new row, populate it
            DataRow newRow = BloodDonorsRecordDataTable.NewRow();
            newRow["DonorID"] = (DateTime.Now.Ticks / 10000000).ToString();
            newRow["Name"] = Name;
            newRow["BloodGroup"] = BloodGroup;
            newRow["Phone"] = Phone;
            newRow["Address"] = Address;

            try
            {
                BloodDonorsRecordDataSet.Tables["BloodDonorsTable"].Rows.Add(newRow);
                BloodDonorsRecordDataAdapter.Update(BloodDonorsRecordDataSet, "BloodDonorsTable");
                BloodDonorsRecordDataSet.AcceptChanges();
                MessageBox.Show("New Blood Donor '" + Name + "' successfully added to the system.",
                                "Add Blood Donor Success");
                return true;
            }
            catch (OleDbException ex)
            {
                BloodDonorsRecordDataSet.RejectChanges();
                MessageBox.Show(ex.Message, "Add Blood Donor Error");
                return false;
            }
        }

        public Boolean UpdateBloodDonorRecord(String DonorID, String Name, String BloodGroup, String Phone, String Address)
        {
            try
            {
                DataRow[] selectedRows = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'");
                DataRow selectedRow = selectedRows[0];

                selectedRow.BeginEdit();
                selectedRow["Name"] = Name.Trim();
                selectedRow["BloodGroup"] = BloodGroup.Trim();
                selectedRow["Phone"] = Phone.Trim();
                selectedRow["Address"] = Address.Trim();
                selectedRow.EndEdit();

                DataSet dsChanges = BloodDonorsRecordDataSet.GetChanges(DataRowState.Modified);
                if (dsChanges.HasErrors)
                {
                    BloodDonorsRecordDataSet.RejectChanges();
                    MessageBox.Show("Blood Donor Record for '" + Name + "' couldn't be updated! The Donor's data is not correct.",
                                    "Update Blood Donor Record Error");
                    return false;
                }
                else
                {
                    try
                    {
                        //BloodDonorsRecordDataAdapter.UpdateCommand.Parameters["OldName"].Value = "Ashfaq Ahmad";
                        BloodDonorsRecordDataAdapter.Update(dsChanges, "BloodDonorsTable");
                        BloodDonorsRecordDataSet.AcceptChanges();
                        MessageBox.Show("Blood Donor Record for '" + Name + "' successfully updated.",
                                        "Update Blood Donor Record Success");
                        return true;
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message, "Update Blood Donor Record Error");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return false;
        }

        public Boolean DeleteBloodDonorRecord(String DonorID)
        {
            try
            {
                DataRow selectedRow = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'")[0];
                String SelectedName = selectedRow["Name"].ToString();
                selectedRow.Delete();

                try
                {
                    BloodDonorsRecordDataAdapter.Update(BloodDonorsRecordDataSet, "BloodDonorsTable");
                    BloodDonorsRecordDataSet.AcceptChanges();
                    MessageBox.Show("Blood Donor Record for '" + SelectedName + "' successfully deleted from the Database.",
                                    "Delete Blood Donor Record Success");
                    return true;
                }
                catch (OleDbException ex)
                {
                    BloodDonorsRecordDataSet.RejectChanges();
                    MessageBox.Show(ex.Message, "Delete Blood Donor Record Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return false;
        }

        public Boolean BloodDonorRecordExists()
        {
            return (BloodDonorsRecordDataTable.Select().Length > 0);
        }

        public String GetBloodDonorName(String DonorID)
        {
            try
            {
                DataRow selectedRow = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'")[0];
                return selectedRow["Name"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetBloodDonorBloodGroup(String DonorID)
        {
            try
            {
                DataRow selectedRow = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'")[0];
                return selectedRow["BloodGroup"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetBloodDonorPhone(String DonorID)
        {
            try
            {
                DataRow selectedRow = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'")[0];
                return selectedRow["Phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetBloodDonorAddress(String DonorID)
        {
            try
            {
                DataRow selectedRow = BloodDonorsRecordDataTable.Select("DonorID = '" + DonorID + "'")[0];
                return selectedRow["Address"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error");
            }
            return "";
        }

        public String GetDBConnectionString()
        {
            return DBConnectionString;
        }

        private void BuildCommands(String connectionString)
        {
            OleDbConnection DBConnection = new OleDbConnection(connectionString);

            //
            // UserRecordTable Commands
            //
            // SELECT COMMAND
            UserRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            UserRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM UserRecordTable";

            // INSERT COMMAND
            UserRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            UserRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO UserRecordTable " +
                                                              "(Name, Designation, Username, [Password], UserGroup, Contact, Address, City )" +
                                                              "VALUES" +
                                                              "(?, ?, ?, ?, ?, ?, ?, ?)";

            UserRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("Designation", OleDbType.Char, 0, "Designation");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("Username", OleDbType.Char, 0, "Username");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("Password", OleDbType.Char, 0, "Password");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("UserGroup", OleDbType.Char, 0, "UserGroup");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("Contact", OleDbType.Char, 0, "Contact");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");
            UserRecordDataAdapter.InsertCommand.Parameters.Add("City", OleDbType.Char, 0, "City");

            // UPDATE COMMAND
            UserRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            UserRecordDataAdapter.UpdateCommand.CommandText = "UPDATE UserRecordTable " +
                                                              "SET Name = ?, " +
                                                              "Designation = ?, " +
                                                              "[Password] = ?, " +
                                                              "UserGroup = ?, " +
                                                              "Contact = ?, " +
                                                              "Address = ?, " +
                                                              "City = ? " +
                                                              "WHERE Username = ? ";

            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Designation", OleDbType.Char, 0, "Designation");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Password", OleDbType.Char, 0, "Password");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("UserGroup", OleDbType.Char, 0, "UserGroup");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Contact", OleDbType.Char, 0, "Contact");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("City", OleDbType.Char, 0, "City");
            UserRecordDataAdapter.UpdateCommand.Parameters.Add("Username", OleDbType.Char, 0, "Username");

            // DELETE COMMAND
            UserRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            UserRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM UserRecordTable WHERE Username = ?";
            UserRecordDataAdapter.DeleteCommand.Parameters.Add("Username", OleDbType.Char, 0, "Username");

            //
            // PatientRecordTable Commands
            //
            // SELECT COMMAND
            PatientRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            PatientRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM PatientRecordTable";

            // INSERT COMMAND
            PatientRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            PatientRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO PatientRecordTable " +
                                                              "(PMRN, Name, Gender, Address, City, Phone, RegistrationDate )" +
                                                              "VALUES" +
                                                              "(?, ?, ?, ?, ?, ?, ?)";

            PatientRecordDataAdapter.InsertCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("Gender", OleDbType.Char, 0, "Gender");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("City", OleDbType.Char, 0, "City");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("Phone", OleDbType.Char, 0, "Phone");
            PatientRecordDataAdapter.InsertCommand.Parameters.Add("RegistrationDate", OleDbType.Char, 0, "RegistrationDate");
            

            // UPDATE COMMAND
            PatientRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            PatientRecordDataAdapter.UpdateCommand.CommandText = "UPDATE PatientRecordTable " +
                                                              "SET Name = ? ," +
                                                              "Gender = ? ," + 
                                                              "Address = ? ," +
                                                              "City = ? ," +
                                                              "Phone = ? " +
                                                              "WHERE PMRN = ? ";

            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("Gender", OleDbType.Char, 0, "Gender");
            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");
            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("City", OleDbType.Char, 0, "City");
            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("Phone", OleDbType.Char, 0, "Phone");
            PatientRecordDataAdapter.UpdateCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");

            // DELETE COMMAND
            PatientRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            PatientRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM PatientRecordTable WHERE PMRN = ?";
            PatientRecordDataAdapter.DeleteCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");

            //
            // BloodDonorsTable Commands
            //
            // SELECT COMMAND
            BloodDonorsRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            BloodDonorsRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM BloodDonorsTable";

            // INSERT COMMAND
            BloodDonorsRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            BloodDonorsRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO BloodDonorsTable " +
                                                                     "(DonorID, Name, BloodGroup, Phone, Address)" +
                                                                     "VALUES" +
                                                                     "(?, ?, ?, ?, ?)";

            BloodDonorsRecordDataAdapter.InsertCommand.Parameters.Add("DonorID", OleDbType.Char, 0, "DonorID");
            BloodDonorsRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            BloodDonorsRecordDataAdapter.InsertCommand.Parameters.Add("BloodGroup", OleDbType.Char, 0, "BloodGroup");
            BloodDonorsRecordDataAdapter.InsertCommand.Parameters.Add("Phone", OleDbType.Char, 0, "Phone");
            BloodDonorsRecordDataAdapter.InsertCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");


            // UPDATE COMMAND
            BloodDonorsRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            BloodDonorsRecordDataAdapter.UpdateCommand.CommandText = "UPDATE BloodDonorsTable " +
                                                                     "SET Name = ?, " +
                                                                     "BloodGroup = ?, " +
                                                                     "Phone = ?, " +
                                                                     "Address = ? " +
                                                                     "WHERE " + 
                                                                     "DonorID = ? ";

            BloodDonorsRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            BloodDonorsRecordDataAdapter.UpdateCommand.Parameters.Add("BloodGroup", OleDbType.Char, 0, "BloodGroup");
            BloodDonorsRecordDataAdapter.UpdateCommand.Parameters.Add("Phone", OleDbType.Char, 0, "Phone");
            BloodDonorsRecordDataAdapter.UpdateCommand.Parameters.Add("Address", OleDbType.Char, 0, "Address");
            BloodDonorsRecordDataAdapter.UpdateCommand.Parameters.Add("DonorID", OleDbType.Char, 0, "DonorID");

            // DELETE COMMAND
            BloodDonorsRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            BloodDonorsRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM BloodDonorsTable WHERE DonorID = ?";
            BloodDonorsRecordDataAdapter.DeleteCommand.Parameters.Add("DonorID", OleDbType.Char, 0, "DonorID");

            //
            // BloodBankTable Commands
            //
            // SELECT COMMAND
            BloodBankRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            BloodBankRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM BloodBankTable";

            // INSERT COMMAND
            BloodBankRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            BloodBankRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO BloodBankTable " +
                                                                   "(SampleID, BloodGroup, BloodQuantity, DateOfCollection, ExpiryDate)" +
                                                                   "VALUES" +
                                                                   "(?, ?, ?, ?, ?)";

            BloodBankRecordDataAdapter.InsertCommand.Parameters.Add("SampleID", OleDbType.Char, 0, "SampleID");
            BloodBankRecordDataAdapter.InsertCommand.Parameters.Add("BloodGroup", OleDbType.Char, 0, "BloodGroup");
            BloodBankRecordDataAdapter.InsertCommand.Parameters.Add("BloodQuantity", OleDbType.BigInt, 0, "BloodQuantity");
            BloodBankRecordDataAdapter.InsertCommand.Parameters.Add("DateOfCollection", OleDbType.Char, 0, "DateOfCollection");
            BloodBankRecordDataAdapter.InsertCommand.Parameters.Add("ExpiryDate", OleDbType.Char, 0, "ExpiryDate");


            // DELETE COMMAND
            BloodBankRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            BloodBankRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM BloodBankTable WHERE SampleID = ?";
            BloodBankRecordDataAdapter.DeleteCommand.Parameters.Add("SampleID", OleDbType.Char, 0, "SampleID");

            
            //
            // InPatientTable Commands
            //
            // SELECT COMMAND
            InPatientRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            InPatientRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM InPatientTable";

            // INSERT COMMAND
            InPatientRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            InPatientRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO InPatientTable " +
                                                                   "(AppointmentID, PMRN, Name, Description, DoctorName, ServiceCharges, [Time], [Date])" +
                                                                   "VALUES" +
                                                                   "(?, ?, ?, ?, ?, ?, ?, ?)";

            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("AppointmentID", OleDbType.Char, 0, "AppointmentID");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("Description", OleDbType.Char, 0, "Description");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("DoctorName", OleDbType.Char, 0, "DoctorName");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("ServiceCharges", OleDbType.Char, 0, "ServiceCharges");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("Time", OleDbType.Char, 0, "Time");
            InPatientRecordDataAdapter.InsertCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");

            // UPDATE COMMAND
            InPatientRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            InPatientRecordDataAdapter.UpdateCommand.CommandText = "UPDATE InPatientTable " +
                                                                   "SET AppointmentID = ?, " +
                                                                   "PMRN = ?, " +
                                                                   "Name = ?, " +
                                                                   "Description = ?, " +
                                                                   "DoctorName = ?, " +
                                                                   "ServiceCharges = ?, " +
                                                                   "[Time] = ?, " +
                                                                   "[Date] = ? ";

            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("AppointmentID", OleDbType.Char, 0, "AppointmentID");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Description", OleDbType.Char, 0, "Description");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("DoctorName", OleDbType.Char, 0, "DoctorName");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("ServiceCharges", OleDbType.Char, 0, "ServiceCharges");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Time", OleDbType.Char, 0, "Time");
            InPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");


            //
            // OutPatientTable Commands
            //
            // SELECT COMMAND
            OutPatientRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            OutPatientRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM OutPatientTable";

            // INSERT COMMAND
            OutPatientRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            OutPatientRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO OutPatientTable " +
                                                                    "([INDEX], PMRN, Name, Code, Description, [Date], ServiceCharges) " +
                                                                    "VALUES" +
                                                                    "(?, ?, ?, ?, ?, ?, ?)";

            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("INDEX", OleDbType.Char, 0, "INDEX");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("Code", OleDbType.Char, 0, "Code");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("Description", OleDbType.Char, 0, "Description");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");
            OutPatientRecordDataAdapter.InsertCommand.Parameters.Add("ServiceCharges", OleDbType.BigInt, 0, "ServiceCharges");

            // UPDATE COMMAND
            OutPatientRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            OutPatientRecordDataAdapter.UpdateCommand.CommandText = "UPDATE OutPatientTable " +
                                                                    "SET PMRN = ?, " +
                                                                    "Name = ?, " +
                                                                    "Code = ?, " +
                                                                    "Description = ?, " +
                                                                    "[Date] = ?, " +
                                                                    "ServiceCharges = ?";

            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Code", OleDbType.Char, 0, "Code");
            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Description", OleDbType.Char, 0, "Description");
            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");
            OutPatientRecordDataAdapter.UpdateCommand.Parameters.Add("ServiceCharges", OleDbType.BigInt, 0, "ServiceCharges");

            // DELETE COMMAND
            OutPatientRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            OutPatientRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM OutPatientTable WHERE INDEX = ?";

            OutPatientRecordDataAdapter.DeleteCommand.Parameters.Add("INDEX", OleDbType.Char, 0, "INDEX");


            //
            // LabTestsTable Commands
            //
            // SELECT COMMAND
            LabTestsRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            LabTestsRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM LabTestsTable";

            // INSERT COMMAND
            LabTestsRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            LabTestsRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO LabTestsTable " +
                                                                  "(ID, PMRN, Name, TestID, TestName, ServiceCharges, [Time], [Date])" +
                                                                  "VALUES" +
                                                                  "(?, ?, ?, ?, ?, ?, ?, ?)";

            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("ID", OleDbType.Char, 0, "ID");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("TestID", OleDbType.Char, 0, "TestID");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("TestName", OleDbType.Char, 0, "TestName");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("ServiceCharges", OleDbType.BigInt, 0, "ServiceCharges");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("Time", OleDbType.Char, 0, "Time");
            LabTestsRecordDataAdapter.InsertCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");

            // UPDATE COMMAND
            LabTestsRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            LabTestsRecordDataAdapter.UpdateCommand.CommandText = "UPDATE LabTestsTable " +
                                                                  "SET PMRN = ?, " +
                                                                  "Name = ?, " +
                                                                  "TestID = ?, " +
                                                                  "TestName = ?, " +
                                                                  "ServiceCharges = ?, " +
                                                                  "[Time] = ?, " +
                                                                  "[Date] = ? ";

            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("TestID", OleDbType.Char, 0, "TestID");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("TestName", OleDbType.Char, 0, "TestName");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("ServiceCharges", OleDbType.BigInt, 0, "ServiceCharges");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("Time", OleDbType.Char, 0, "Time");
            LabTestsRecordDataAdapter.UpdateCommand.Parameters.Add("Date", OleDbType.Char, 0, "Date");

            // DELETE COMMAND
            LabTestsRecordDataAdapter.DeleteCommand = DBConnection.CreateCommand();
            LabTestsRecordDataAdapter.DeleteCommand.CommandText = "DELETE FROM LabTestsTable";


            //
            // PrescriptionTable Commands
            //
            // SELECT COMMAND
            PrescriptionRecordDataAdapter.SelectCommand = DBConnection.CreateCommand();
            PrescriptionRecordDataAdapter.SelectCommand.CommandText = "SELECT * FROM PrescriptionTable";

            // INSERT COMMAND
            PrescriptionRecordDataAdapter.InsertCommand = DBConnection.CreateCommand();
            PrescriptionRecordDataAdapter.InsertCommand.CommandText = "INSERT INTO PrescriptionTable " +
                                                                      "(PMRN, Name, Prescription)" +
                                                                      "VALUES" +
                                                                      "(?, ?, ?)";

            PrescriptionRecordDataAdapter.InsertCommand.Parameters.Add("PMRN", OleDbType.Char, 0, "PMRN");
            PrescriptionRecordDataAdapter.InsertCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            PrescriptionRecordDataAdapter.InsertCommand.Parameters.Add("Prescription", OleDbType.Char, 0, "Prescription");

            // UPDATE COMMAND
            PrescriptionRecordDataAdapter.UpdateCommand = DBConnection.CreateCommand();
            PrescriptionRecordDataAdapter.UpdateCommand.CommandText = "UPDATE PrescriptionTable " +
                                                                      "SET Name = ?, " +
                                                                      "Prescription = ? ";

            PrescriptionRecordDataAdapter.UpdateCommand.Parameters.Add("Name", OleDbType.Char, 0, "Name");
            PrescriptionRecordDataAdapter.UpdateCommand.Parameters.Add("Prescription", OleDbType.Char, 0, "Prescription");

        }
    }
}
