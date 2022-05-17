
using SuperVoters.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    public partial class VoteResults : Form
    {
        string _passInElectionId = "";
        string _returnPage = "";
        

        public VoteResults(string electionId, string returnPage)
        {
            InitializeComponent();
            _passInElectionId = electionId;
            _returnPage = returnPage;
        }

        private void VoteResults_Load(object sender, EventArgs e)
        {
            GetElectionNames(_passInElectionId);
        }  

        private void GetElectionNames(string electionId)
        {           
            List<ElectionData> electionNames = new List<ElectionData>();
            string retValue = "";

            // Fill election dd box
            if (ElectionNames.Items.Count == 0)  
            {
                try
                {
                    electionNames = DataAccessLayer.GetElectionNames(ref retValue);

                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = electionNames;

                    ElectionNames.DataSource = bindingSource1.DataSource;
                    ElectionNames.ValueMember = "ElectionId";
                    ElectionNames.DisplayMember = "ElectionName";                   
                }
                catch (Exception ex)
                {
                    LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + retValue + ", " + ex.Message);
                }            

                if (!string.IsNullOrWhiteSpace(electionId))
                {
                    ElectionNames.SelectedValue = electionId;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {        
           GetData();
        }

        private void GetData()
        {
            string myDate = "";
            string selectedElectionNameValue = ElectionNames.SelectedValue.ToString();

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = DataAccessLayer.GetVoteResultsQuery(myDate, selectedElectionNameValue);

                    SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    dataGridVotingResults.DataSource = dataTable;
                }

                dataGridVotingResults.Columns[0].Width = 159;

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Utilities.LogTime(ts, "GetVoteResults");
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error, "An error occurred while getting voting results: " + ex.Message);
                MessageBox.Show("An error occurred getting data");
            }
            

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingElection pendingElection = new PendingElection(-1);
            pendingElection.FormClosed += (s, args) => this.Close();
            pendingElection.Show();
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = GetReturnPage();
            form.Visible = true;
        }

        public Form GetReturnPage()
        {
            Form form = null;

            if (_returnPage == "PendingElection")
            {
                form = new PendingElection(-1);
            }
            else if (_returnPage == "CandidateForm")
            {
                form = new CandidateForm();
            }
            else if (_returnPage == "NewElectionPage1")
            {
                form = new NewElectionPage1();
            }
            else if (_returnPage == "DeleteElection")
            {
                form = new DeleteElection();
            }

            LogFactory.WriteLog(LogFactory.Level.Info,"Return page from VoteResults: " + _returnPage);

            return form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}
