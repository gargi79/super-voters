
using SuperVoters.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    public partial class PendingElection : Form
    {
        int _voterId = 0;
        

        public PendingElection(int voterId)
        {
            InitializeComponent();
            _voterId = voterId;
        }

        private void PendingElection_Load(object sender, EventArgs e)
        {
            string retValue = "";
            List<ElectionData> electionNames = DataAccessLayer.GetElectionNames(ref retValue);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = electionNames;

            cb_electionID.DataSource = bindingSource1.DataSource;
            cb_electionID.ValueMember = "ElectionId";
            cb_electionID.DisplayMember = "ElectionName";
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            if(cb_electionID.SelectedIndex > -1)
            { 
                String electionId = cb_electionID.SelectedValue.ToString();
                electionLabel.Text = electionId;
                CastAVotePage castAVotePage = new CastAVotePage(electionId, _voterId);
                castAVotePage.Show();
                castAVotePage.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Item not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                electionLabel.Text = "?";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            String electionId = cb_electionID.SelectedValue.ToString();
            VoteResults results = new VoteResults(electionId, "PendingElection");
            results.FormClosed += (s, args) => this.Close();
            results.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }

        private void cb_electionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_enter.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}
