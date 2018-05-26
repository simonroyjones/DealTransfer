using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace DealTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadAccountIdsfromFile()
        {
            //var inputFileName = @"c:\users\simon\documents\input.csv";
            var contents = File.ReadAllText(gv.inputFileName);
            var accountIds = contents.Split('|').ToList();

            // Get data for each account and add to datagrid
            dgvInputData.Rows.Clear();
            foreach (var accountId in accountIds)
            {
                var conn = new SqlConnection(gv.LiveConnStr);
                conn.Open();
                var SQL = "SELECT a.AccountID, DealNo = a.DealID, DealName = b.DealName, " +
                           "Balance = c.OutstandingBalance, CurrentStatus = e.LitigationFlowAccountStatus " +
                           "FROM dbo.Account a INNER JOIN deal b ON b.DealID = a.DealID " +
                           "INNER JOIN dbo.AccountSummary c ON c.AccountID = a.AccountID " +
                           "INNER JOIN litigation.LitigationFlowAccount d ON d.AccountID = a.AccountID " +
                           "INNER JOIN litigation.LookupLitigationFlowAccountStatus e ON e.LitigationFlowAccountStatusID = d.LitigationFlowAccountStatusID " +
                           "WHERE a.AccountID = " + accountId;
                var cmd = new SqlCommand(SQL, conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dgvInputData.Rows.Add(rdr["AccountId"].ToString(), rdr["DealNo"].ToString(), rdr["Dealname"].ToString(),
                        rdr["Balance"].ToString(), rdr["CurrentStatus"].ToString());
                }
                conn.Close();
            }
        }

        private void btnOpenInputFile_Click(object sender, EventArgs e)
        {
            var inputFile = new OpenFileDialog();
            inputFile.Filter = "*.csv|*.csv";
            inputFile.InitialDirectory = "t:\\";
            if (inputFile.ShowDialog() == DialogResult.OK)
            {
                gv.inputFileName = inputFile.FileName;
            }
            ReadAccountIdsfromFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MLL - Bulk Deal Transfer";
        }

        private void btnPasteData_Click(object sender, EventArgs e)
        {
            // Clipboard Preview //
            MessageBox.Show(Clipboard.GetText());

            // See if they want to continue //
                string co = Clipboard.GetText();
            var accountIds = Regex.Split(co,"\r\n").ToList();

            // Get data for each account and add to datagrid
            dgvInputData.Rows.Clear();
            foreach (var accountId in accountIds)
            {
                if (accountId != "")
                {
                    var conn = new SqlConnection(gv.LiveConnStr);
                    conn.Open();
                    var SQL = "SELECT a.AccountID, DealNo = a.DealID, DealName = b.DealName, " +
                               "Balance = c.OutstandingBalance, CurrentStatus = e.LitigationFlowAccountStatus " +
                               "FROM dbo.Account a INNER JOIN deal b ON b.DealID = a.DealID " +
                               "INNER JOIN dbo.AccountSummary c ON c.AccountID = a.AccountID " +
                               "INNER JOIN litigation.LitigationFlowAccount d ON d.AccountID = a.AccountID " +
                               "INNER JOIN litigation.LookupLitigationFlowAccountStatus e ON e.LitigationFlowAccountStatusID = d.LitigationFlowAccountStatusID " +
                               "WHERE a.AccountID = " + accountId;
                    var cmd = new SqlCommand(SQL, conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        dgvInputData.Rows.Add(rdr["AccountId"].ToString(), rdr["DealNo"].ToString(), rdr["Dealname"].ToString(),
                            rdr["Balance"].ToString(), rdr["CurrentStatus"].ToString());
                    }
                    conn.Close();
                }
            }
            //var clipboardData = (DataObject)Clipboard.GetDataObject();
            //if (clipboardData.GetDataPresent(DataFormats.Text))
            //{


            //    string pastedData = clipboardData.GetData(DataFormats.Text).ToString();
            //    foreach (var cat in pastedData)
            //    {
            //        MessageBox.Show(cat.ToString());
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("No data");
            //}
        }
    }
}
