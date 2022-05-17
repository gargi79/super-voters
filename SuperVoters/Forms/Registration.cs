
using SuperVoters.Forms;
using System;
using System.Windows.Forms;

namespace SuperVoters
{
    public partial class Registration : Form
    {
        

        public Registration()
        {
            InitializeComponent();
            LoadReg();
        }

        private void Registration_Load(object sender, EventArgs e)
        { 
        }

        public void LoadReg()
        {
            // RoleList.Text = "Please select a role";
            RoleList.Items.Add("Voter");
            // RoleList.Items.Add("Candidate");
            RoleList.SelectedIndex = 0;

            Party.Items.Add("None");
            Party.Items.Add("Democrat");
            Party.Items.Add("Republican");

            Party.SelectedIndex = 0;

            SaveResponse.Visible = false;
        }

        private void SaveRegistration_Click(object sender, EventArgs e)
        {
            string party = GetParty(Party);
            SaveData(UserName.Text, Password.Text, RoleList.SelectedItem.ToString(), FirstName.Text, MiddleInitial.Text, LastName.Text, DateOfBirth.Text, Email.Text, Address.Text, Phone.Text, party);
        }

        public int SaveData(string userName, string passWord, string role, string fName, string mName, string lName, string dob, string email, string address, string phone, string party)
        {
            UserNameError.Visible = false;
            PasswordError.Visible = false;

            SaveResponse.Text = "";
            SaveResponse.Visible = true;
            string retValue = "";
            int voterId = 0;
            bool hasError = false;

            try
            {
                if (passWord.Trim().Length < 8)
                {
                    PasswordError.Visible = true;
                }
                else
                {
                    //Save userName and Password into login table
                    retValue = DataAccessLayer.SaveLogin(userName, passWord);
                    SaveResponse.Text += retValue;

                    if (retValue.Contains("duplicate"))
                    {
                        UserNameError.Visible = true;
                    }
                    else
                    {
                        retValue = DataAccessLayer.SaveRegistration(role, fName, mName, lName, dob, email, address, party);
                        SaveResponse.Text = retValue;

                        voterId = SaveVoter(userName, passWord, mName, lName, dob, email, address, phone, out retValue, out voterId);

                        //Direct user to correct page

                        switch (RoleList.SelectedItem.ToString())
                        {
                            case "Admin":
                                NewElectionPage1 election = new NewElectionPage1();
                                election.Visible = true;
                                break;
                            case "Candidate":
                                CandidateForm candidate = new CandidateForm();
                                candidate.Visible = true;
                                break;
                            default:
                                PendingElection pendingElection = new PendingElection(voterId);
                                pendingElection.Visible = true;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                hasError = true;
            }

           if (!hasError)
               LogFactory.WriteLog(LogFactory.Level.Info, "A new voter was created: " + voterId);

            return voterId;
        }

        private int SaveVoter(string userName, string passWord, string mName, string lName, string dob, string email, string address, string phone, out string retValue, out int voterId)
        {
            voterId = 0;
            retValue = DataAccessLayer.SaveVoter(userName, passWord, mName, lName, dob, email, address, phone, ref voterId);
            SaveResponse.Text = retValue;
            return voterId;
        }

        public string GetParty(ComboBox party)
        {
            return (party.SelectedItem == null || party.SelectedItem.ToString() == "None") ? "" : party.SelectedItem.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitReg();
        }

        private void ExitReg()
        {
            Login start = new Login();
            start.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}

