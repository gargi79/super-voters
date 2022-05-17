using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuperVoters.Forms
{
    public partial class NewElectionPage2 : Form
    {
        int elecId;
        int canId;
        Boolean isDuplicated;
        

        public NewElectionPage2(int elecId)
        {
            InitializeComponent();
            this.elecId = elecId;
        }

        private void NewElectionPage2_Load(object sender, EventArgs e)
        {
            LoadCandidateData();
            LoadElectionCandidateData();
        }

        public DataTable LoadCandidateData()
        {
            DataTable dtbl = new DataTable();
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    //Load candidate data
                    SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * From Candidate", connection);
                    sqlData.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
            }
            return dtbl;
        }

        public DataTable LoadElectionCandidateData()
        {
            DataTable dtbl2 = new DataTable();
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //Load election-candidate data
                    String query = "SELECT Election.ElecId, Election.ElecTopic, Election.StartDate, Election.EndDate, " +
                        "Candidate.CandidateId, Candidate.Name, Candidate.Party, Candidate.Phone, Candidate.Description,Candidate.MyImage FROM Election " +
                        "JOIN ElectionCandidate ON (Election.ElecId = ElectionCandidate.ElecId) AND Election.elecId = " + elecId + 
                        "JOIN Candidate ON (ElectionCandidate.CanId = Candidate.CandidateId)";
                    SqlDataAdapter sqlData2 = new SqlDataAdapter(query, connection);
                    sqlData2.Fill(dtbl2);
                    dataGridView2.DataSource = dtbl2;
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
            }
            return dtbl2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            this.canId = (int)selectedRow.Cells[0].Value;
            Console.WriteLine("CanId " + canId);
        }

        private void saveCanToElecBth_Click(object sender, EventArgs e)
        {
            try
            {
                isDuplicated = checkDuplicateCandidate(this.canId);

                if (!isDuplicated)
                {
                    SaveToElectionCandidate(this.elecId, this.canId);
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
            }

            LoadElectionCandidateData();
        }

        public Boolean checkDuplicateCandidate(int canId)
        {
            String canIdString = canId.ToString();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (canIdString == dataGridView2.Rows[i].Cells[4].Value.ToString().Trim())
                {

                    MessageBox.Show("The candidate already exists, please select another candidate!");
                    return true;
                }
            }
            return false;

        }

        public string SaveToElectionCandidate(int elecId, int canId)
        {
            string retValue = "";
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "Insert into dbo.ElectionCandidate (ElecId, CanId)";
                    query += " VALUES (@ElecId, @CanId)";

                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ElecId", elecId);
                        command.Parameters.AddWithValue("@CanId", canId);

                        connection.Open();
                        command.ExecuteNonQuery();
                        retValue = "Successful";
                        MessageBox.Show("Data Saved Succeffcully");
                        return retValue;
                    }
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                retValue = "Failed";
                return retValue;
                //MessageBox.Show("Error " + ex);
            }
        }

        private void addCandiBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.FormClosed += (s, args) => this.Close();
            candidateForm.Show();
        }

        private void addElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewElectionPage1 newElec = new NewElectionPage1();
            newElec.FormClosed += (s, args) => this.Close();
            newElec.Show();
        }

        private void deleteElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteElection deleteElec = new DeleteElection();
            deleteElec.FormClosed += (s, args) => this.Close();
            deleteElec.Show();
        }

        private void viewResultBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoteResults results = new VoteResults("-1", "NewElection");
            results.FormClosed += (s, args) => this.Close();
            results.Show();
        }

        private void logOutBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }

}

