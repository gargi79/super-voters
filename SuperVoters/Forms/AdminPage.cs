using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    public partial class AdminPage : Form
    {
        int _voterId = -1;

        public AdminPage(int voterId)
        {
            InitializeComponent();
            _voterId = voterId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoteResults voteResults = new VoteResults("");
            voteResults.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CandidateForm candidate = new CandidateForm();
            candidate.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VoterForm voter = new VoterForm();
            voter.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NewElection election = new NewElection();
            election.Visible = true;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login someform = new Login();
            someform.Visible = true;
        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

  

        private void CastVoteBtn_Click(object sender, EventArgs e)
        {
            _ = new CastAVotePage("", _voterId)
            {
                Tag = this,
                Visible = true
            };
            Hide();

        }

        private void button_pendingElection_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PendingElection someform = new PendingElection(-1);
            someform.Visible = true;
        }
    }
}
