using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PrintReportsForm : Form
    {
        private ReportDocument UserRecordReport;

        private String DBConnectionString;
        private String Query;
        private String TableName;
        private String ReportFile;

        
        private void ConfigureCrystalReports()
        {
            DataSet dataSet = new DataSet();
            OleDbConnection oleDbConnection = new OleDbConnection(DBConnectionString);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(Query, oleDbConnection);
            oleDbDataAdapter.Fill(dataSet, TableName);

            UserRecordReport = new ReportDocument();
            UserRecordReport.Load("ras://" + Application.StartupPath + "\\" + ReportFile);
            UserRecordReport.SetDataSource(dataSet);
            crystalReportViewer.ReportSource = UserRecordReport;
            
        }

        public PrintReportsForm(String dbConnectionString, String query, String tableName, String reportFile)
        {
            InitializeComponent();
            DBConnectionString = dbConnectionString;
            Query = query;
            TableName = tableName;
            ReportFile = reportFile;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureCrystalReports();
        }

        private void PrintReportsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.Return)
                crystalReportViewer.PrintReport();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            crystalReportViewer.PrintReport();
        }
    }
}
