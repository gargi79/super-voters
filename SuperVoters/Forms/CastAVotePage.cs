using SuperVoters.DAL;
using SuperVoters.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SuperVoters.Models;
using System.Diagnostics;

namespace SuperVoters.Forms
{
    public partial class CastAVotePage : Form
    {
        string _electionId = "";
        int _voterId = -1;
        

        public CastAVotePage(string electionId, int voterId)
        {
            InitializeComponent();
            _electionId = electionId;
            _voterId = voterId;
        }

        private void GoBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PendingElection someform = new PendingElection(_voterId);
            someform.Visible = true;
        }

        private void CandidateListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCandidateName.Text = CandidateListView.CurrentRow?.Cells[1].Value.ToString();
            SelectedCandidatePartyName.Text = CandidateListView.CurrentRow?.Cells[2].Value.ToString();
            SelectedCandidateDesc.Text = CandidateListView.CurrentRow?.Cells[3].Value.ToString();
            try
            {
                var imgData = (byte[])CandidateListView.CurrentRow?.Cells[6].Value;
                var stream = new MemoryStream(imgData ?? Array.Empty<byte>());
                SelectedCandidatePictureBox.Image = Image.FromStream(stream);
            }
            catch (Exception ex)
            {
                SelectedCandidatePictureBox.Image = null;
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occured in CandidateListView: " + ex.Message);
            }
        }

        private readonly CandidateDAL candidateDal = new CandidateDAL();
        private void CastAVotePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superVotersDataSet.Election' table. You can move, or remove it, as needed.
            this.electionTableAdapter.Fill(this.superVotersDataSet.Election);
            // TODO: This line of code loads data into the 'electionDataSetWithIdAndName.Election' table. You can move, or remove it, as needed.
            // electionTableAdapter.Fill(electionDataSetWithIdAndName.Election);

            DataTable loadCandidatesData = candidateDal.Select(_electionId);
            if (loadCandidatesData == null || loadCandidatesData.Rows.Count <= 0) return;

            CandidateListView.DataSource = loadCandidatesData;
            CandidateListView.Columns["CandidateId"].Visible = false;
            CandidateListView.Columns["MyImage"].Visible = false;

            CandidateListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SelectedCandidatePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            CandidateListView.ClearSelection();

            string retValue = "";
            List<ElectionData> electionNames = DataAccessLayer.GetElectionNames(ref retValue);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = electionNames;

            //ElectionSelectionCombo.DataSource = bindingSource1.DataSource;
            //ElectionSelectionCombo.ValueMember = "ElectionId";
            //ElectionSelectionCombo.DisplayMember = "ElectionName";

            //if (!string.IsNullOrWhiteSpace(_electionId))
            //    ElectionSelectionCombo.SelectedValue = _electionId;

        }

        private void CastVoteBtn_Click(object sender, EventArgs e)
        {
            if (CandidateListView.CurrentRow == null)
            {
                MessageBox.Show("Please select a candidate.");
                return;
            }
           // var electionId = Convert.ToInt32(ElectionSelectionCombo.SelectedValue);
            var candidateId = (int)CandidateListView.CurrentRow?.Cells[0].Value;
            // TODO: Implement some authentication and get the current voter id.
            
            int voterId = 6;
            if (_voterId > 0)
                voterId = _voterId;

            bool isCapable = VoteService.CheckIsCapableOfVoting(Convert.ToInt32(_electionId), voterId);
            string message;
            if(isCapable)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                int res = VoteService.CastNewVote(Convert.ToInt32(_electionId), candidateId, voterId);
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Utilities.LogTime(ts, "CastNewVote");

                message = res == 0 ? "Vote casting was successful" : "Vote casting failed.  Try again later.";
                LogFactory.WriteLog(LogFactory.Level.Info,message);
                MessageBox.Show(message);
            }
            else
            {
                message = "You have already cast vote in this election.";
                LogFactory.WriteLog(LogFactory.Level.Info,message);
                MessageBox.Show(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}
