using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SuperVoters.Forms
{
    public partial class DeleteElection : Form
    {
        private int deleteRowId;
        

        public DeleteElection()
        {
            InitializeComponent();
        }

        private void DeleteElection_Load(object sender, EventArgs e)
        {
            LoadElectionCategoryList();
            LoadElections();
        }

        public void LoadElectionCategoryList()
        {
            cboElecCat.SelectedIndex = -1;
            cboElecCat.Items.Add("School Election");
            cboElecCat.Items.Add("Community Election");
            cboElecCat.Items.Add("Presidential Election");
            cboElecCat.Items.Add("Other");
        }

        public string getElectionCategory(ComboBox electionList)
        {
            return (electionList.SelectedItem == null || electionList.SelectedItem.ToString() == "None") ? "" : electionList.SelectedItem.ToString();
        }


        public DataTable LoadElections()
        {
            DataTable dtbl = new DataTable();
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                //Load data to dataGridView1
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * From Election", connection);
                sqlData.Fill(dtbl);
                electionDataSet.DataSource = dtbl;
            }
            return dtbl;
        }
        private void electionDataSet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.deleteRowId = Convert.ToInt32(electionDataSet.Rows[e.RowIndex].Cells["ElecId"].FormattedValue.ToString());
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
            }
        }

        private void deleteAndSaveBth_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteElection(this.deleteRowId);
                LoadElections();
            }
        }

        public String deleteElection(int rowId)
        {
            string retValue = "";
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string query = "Delete Election where ElecId = '" + rowId + "'";
                    //Note the using will close the connection when done.
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        retValue = "Successful";
                        MessageBox.Show("Successfully Deleted!"); ;
                    }
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                retValue = "Failed";
             }

            return retValue;
        }

        private void viewDateBth_Click(object sender, EventArgs e)
        {
            filterByDate(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
        }

        public int filterByDate(string startDate, string endDate)
        {
            int numOfRows;
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                Console.WriteLine("========= DATE: " + dateTimePicker1.Value.ToString());
                //Load data to dataGridView1
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * From Election where StartDate between '" + startDate + "' and '" + endDate + "'", connection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                electionDataSet.DataSource = dtbl;
                numOfRows = electionDataSet.Rows.Count;
                //Console.WriteLine("numOfRows " + numOfRows);
            }
            return numOfRows;
        }

        private void clearBth2_Click(object sender, EventArgs e)
        {
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                //Load data to dataGridView1
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * From Election", connection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                electionDataSet.DataSource = dtbl;
            }
            cboElecCat.SelectedIndex = -1;
            txtElecTopic.Clear();
        }

        private void clearBth1_Click(object sender, EventArgs e)
        {
            LoadElections();
            cboElecCat.SelectedIndex = -1;
            txtElecTopic.Clear();
        }

        private void viewTopicBth_Click(object sender, EventArgs e)
        {
            filterByElectionCategory(cboElecCat);
            
            if(txtElecTopic.Text != "")
            {
                filterByElectionTopic(txtElecTopic);
            }
        }

        public int filterByElectionCategory(ComboBox comboBox)
        {
            int numOfRows;
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataAdapter sqlData;
                if (comboBox.SelectedIndex == 0)
                {
                    sqlData = new SqlDataAdapter("SELECT * FROM Election WHERE ElecCat = 'School Election'", connection);

                }
                else if (comboBox.SelectedIndex == 1)
                {
                    sqlData = new SqlDataAdapter("SELECT * FROM Election WHERE ElecCat = 'Community Election'", connection);
                }
                else if (comboBox.SelectedIndex == 2)
                {
                    sqlData = new SqlDataAdapter("SELECT * FROM Election WHERE ElecCat = 'Presidential Election'", connection);
                }
                else if (comboBox.SelectedIndex == 3)
                {
                    sqlData = new SqlDataAdapter("SELECT * FROM Election WHERE ElecCat = 'Other'", connection);
                }
                else
                {
                    sqlData = new SqlDataAdapter("SELECT * From Election", connection);
                }

                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                electionDataSet.DataSource = dtbl;
                numOfRows = electionDataSet.Rows.Count;
                //Console.WriteLine("numOfRows " + numOfRows);
            }
            return numOfRows;
        }

        public int filterByElectionTopic(TextBox textBox)
        {
            int numOfRows;
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataAdapter sqlData;
                sqlData = new SqlDataAdapter("SELECT * FROM Election WHERE ElecTopic LIKE '" + textBox.Text + "%'", connection);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                electionDataSet.DataSource = dtbl;
                numOfRows = electionDataSet.Rows.Count;
                Console.WriteLine("numOfRows " + numOfRows);
            }
            return numOfRows;
        }
                

        private void deleteElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteElection deleteElec = new DeleteElection();
            deleteElec.FormClosed += (s, args) => this.Close();
            deleteElec.Show();
        }

        private void addElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewElectionPage1 newElec = new NewElectionPage1();
            newElec.FormClosed += (s, args) => this.Close();
            newElec.Show();
        }

        private void addCandiBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.FormClosed += (s, args) => this.Close();
            candidateForm.Show();
        }

        private void viewElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoteResults results = new VoteResults("-1", "DeleteElection");
            results.FormClosed += (s, args) => this.Close();
            results.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void logOutBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}
