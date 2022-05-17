using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

using SuperVoters.Models;
using System.Collections.Generic;

namespace SuperVoters.Forms
{
    public partial class NewElectionPage1 : Form
    {
        int elecId;
        String elecTopic;
        String elecCat ;
        String startDate;
        String endDate;
        Boolean isElecTopicValid;
        Boolean isElecCategoryValid;
        Boolean isDuplicated;
        

        public NewElectionPage1()
        {
            InitializeComponent();
        }
        //load all data into the datagridviews
        private void NewElection_Load(object sender, EventArgs e)
        {
            LoadElectionCategoryList();
            LoadElectionData();
            GetElectionNames();
        }

        public void LoadElectionCategoryList()
        {
            ElecCategoryList.SelectedIndex = -1;
            ElecCategoryList.Text = "Select an Election Category";
            ElecCategoryList.Items.Add("School Election");
            ElecCategoryList.Items.Add("Community Election");
            ElecCategoryList.Items.Add("Presidential Election");
            ElecCategoryList.Items.Add("Other");
        }

        public string getElectionCategory(ComboBox electionList)
        {
            return (electionList.SelectedItem == null || electionList.SelectedItem.ToString() == "None") ? "" : electionList.SelectedItem.ToString();
        }


        public DataTable LoadElectionData()
        {
            DataTable dtbl3 = new DataTable();
            try
            {
                var settings = new Properties.Settings();
                var connString = settings.SuperVotersConnectionString;
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    //load election data
                    SqlDataAdapter sqlData3 = new SqlDataAdapter("SELECT * FROM Election", connection);
                    sqlData3.Fill(dtbl3);
                    dataGridView3.DataSource = dtbl3;
                   
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
            }
            return dtbl3;
        }

        public string saveToElection(string elecTopic, string startDate, string endDate, string elecCat)
        {
            string retValue = "";
            //validate the input of election topic and category
            validateElectionTopic(ElecTopicText);
            validateElectionCategory(ElecCategoryList);
            isDuplicated = checkDuplicate(elecTopic);
            Console.WriteLine("=====IsDuplicated " + isDuplicated);
            while(!isDuplicated && isElecTopicValid && isElecCategoryValid)
            {
                try
                {

                    var settings = new Properties.Settings();
                    var connString = settings.SuperVotersConnectionString;


                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        string query = "Insert into dbo.Election (ElecTopic, StartDate, EndDate, ElecCat) VALUES (@ElecTopic, @StartDate, @EndDate, @ElecCat) SELECT SCOPE_IDENTITY()";
                    
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@ElecTopic", elecTopic);
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@ElecCat", elecCat);

                        //store the last inserted ElecId
                        this.elecId = Convert.ToInt32(command.ExecuteScalar());
                        //Console.WriteLine("==============" + this.elecId);
                        connection.Close();

                        retValue = "Successful";
                        MessageBox.Show("Data Saved Succeffcully");
                        isDuplicated = true;
                        return retValue;
                    }
                }
                catch (Exception ex)
                {
                    LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                    retValue = "Error inserting data into Election table!";
                }
            }
            retValue = "Failed";
            return retValue;
        }

        public bool validateElectionTopic(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                errorProviderForElecTopic.SetError(textBox, "Please Enter A Election Topic!");
                isElecTopicValid = false;
            }
            else
            {
                errorProviderForElecTopic.SetError(textBox, "");
                isElecTopicValid = true;
            }
            return isElecTopicValid;
        }

        public bool validateElectionCategory(ComboBox comboBox)
        {
            if (comboBox.Text == "Select an Election Category")
            {
                errorProviderForElecCat.SetError(comboBox, "Please Select An Election Category!");
                isElecCategoryValid = false;
            }
            else
            {
                errorProviderForElecCat.SetError(comboBox, "");
                isElecCategoryValid = true;
            }
            return isElecCategoryValid;
        }

        private void addElectionBth_Click(object sender, EventArgs e)
        {
            //validate the input of election topic and category
            validateElectionTopic(ElecTopicText);
            validateElectionCategory(ElecCategoryList);

            //while the election topic is valid then insert data to the Election table 
            while (isElecTopicValid && isElecCategoryValid)
            {
                try
                {
                    this.elecTopic = ElecTopicText.Text.ToString();

                    if (ElecCategoryList.SelectedIndex != -1)
                    {
                        this.elecCat = ElecCategoryList.SelectedItem.ToString();
                    }

                    this.endDate = EndDate.Text.ToString();
                    this.startDate = StartDate.Text.ToString(); ;

                    isDuplicated = checkDuplicate(this.elecTopic);
                    if(!isDuplicated)
                    {
                        saveToElection(this.elecTopic, this.startDate, this.endDate, this.elecCat);
                        
                        isElecTopicValid = false;
                        isElecCategoryValid = false;
                    } else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                }
            }

            //load data to datagrid view after insertion is done
            LoadElectionData();
            GetElectionNames();
        }

        public Boolean checkDuplicate(String elecTopic)
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                if (elecTopic == dataGridView3.Rows[i].Cells[1].Value.ToString().Trim())
                {

                    MessageBox.Show("The Election Topic already exists, please enter a new one!");
                    return true;
                }
            }
            return false;
        }


        public List<ElectionData> GetElectionNames()
        {
            List<ElectionData> electionNames = new List<ElectionData>();
            string retValue = "";

            // Fill election dd box
            if (ElectionList.Items.Count == 0)
            {
                try
                {
                    electionNames = DataAccessLayer.GetElectionNames(ref retValue);

                    var bindingSource1 = new BindingSource();
                    bindingSource1.DataSource = electionNames;

                    ElectionList.DataSource = bindingSource1.DataSource;
                    ElectionList.ValueMember = "ElectionId";
                    ElectionList.DisplayMember = "ElectionName";
                }
                catch (Exception ex)
                {
                    LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + retValue + ", " + ex.Message);
                }
            }

            // reload the election data
            electionNames = DataAccessLayer.GetElectionNames(ref retValue);
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = electionNames;
            ElectionList.DataSource = bindingSource2.DataSource;
            ElectionList.ValueMember = "ElectionId";
            ElectionList.DisplayMember = "ElectionName";
            return electionNames;
        }

        private void confirmBth_Click(object sender, EventArgs e)
        {
            if (ElectionList.SelectedIndex > -1)
            {
                String electionId = ElectionList.SelectedValue.ToString();
                this.elecId = Int32.Parse(electionId);
                Console.WriteLine("=========elecId " + this.elecId);
                this.Hide();
                NewElectionPage2 newElectionPage2 = new NewElectionPage2(this.elecId);
                newElectionPage2.FormClosed += (s, args) => this.Close();
                newElectionPage2.Show();
            }
            else
            {
                MessageBox.Show("Item not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteElection deleteElec = new DeleteElection();
            deleteElec.FormClosed += (s, args) => this.Close();
            deleteElec.Show();
        }

        private void addCandiBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateForm candidateForm = new CandidateForm();
            candidateForm.FormClosed += (s, args) => this.Close();
            candidateForm.Show();
        }

        // new election button
        private void addElecBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewElectionPage1 newElec = new NewElectionPage1();
            newElec.FormClosed += (s, args) => this.Close();
            newElec.Show();
        }

        // View results button
        private void viewResultBth_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoteResults results = new VoteResults("-1", "NewElection");
            results.FormClosed += (s, args) => this.Close();
            results.Show();
        }

        // logout button
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