
using SuperVoters.DAL;
using SuperVoters.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters
{
    public partial class CandidateForm : Form
    {

        string ImgLocation = "";
        CandidateDAL cd = new CandidateDAL();
        Candidate c = new Candidate();
        

        public CandidateForm()
        {

            InitializeComponent();
        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {
            //  setData();
            //  load_data();
            // SELECT[CandidateId]
            //,[Name]
            //,[Party]
            //,[Description]
            //,[Address]
            //,[Phone]
            //,[MyImage]
            //      FROM[dbo].[Candidate]

            DataTable loadcandidatesdt = cd.Select();
            if (loadcandidatesdt != null)
            {
                if (loadcandidatesdt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = loadcandidatesdt;
                    dataGridView1.Rows[0].ReadOnly = true;
                    dataGridView1.ClearSelection();
                }
            }


        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (nameTextBox.Text != "" && partyTextBox.Text != "" &&
                    numberTextBox.Text != "" && addressTextBox.Text != "" && descriptionTextBox.Text != "" && pictureBox1.Image != null)
                {
                    c.candidateName = nameTextBox.Text;
                    c.party = partyTextBox.Text;
                    c.candidatePhone = numberTextBox.Text;
                    c.candidateAddress = addressTextBox.Text;
                    c.description = descriptionTextBox.Text;
                    byte[] imageData = File.ReadAllBytes(@ImgLocation);
                    c.imageData = imageData;
                    //Create Boolean variable to check if the candidate is added successfully or not
                    bool success = cd.Insert(c);
                    //if the candidate is added successfully then the value of success will be true else it will be false
                    if (success == true)
                    {
                        //Candidate Inserted Successfully
                        MessageBox.Show("Candidate Added Successfully");
                        //Calling the Clear Method
                        Clear();
                        //Refreshing DAta Grid View
                        DataTable dt = cd.Select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Add New Candidate
                        MessageBox.Show("Failed to Add New Candidate");
                    }
                }
                else
                {
                    MessageBox.Show("Data must be required in ( * ) Field's");

                }
            }
            catch (Exception ex)
            {
                string retValue = "Error occurred while adding a Candidate";
                LogFactory.WriteLog(LogFactory.Level.Error,retValue + ": " + ex.Message);
                MessageBox.Show(retValue);

            }
        }


        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImgLocation = Dialog.FileName;
                pictureBox1.Image = new Bitmap(Dialog.FileName);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (nameTextBox.Text != "" && partyTextBox.Text != "" &&
                   numberTextBox.Text != "" && addressTextBox.Text != "" && descriptionTextBox.Text != "")
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    c.candidateId = id;

                    //Create Bool VAriable to Check if the candidate is deleted or not
                    bool success = cd.Delete(c);

                    //If candidate is deleted successfully then the value of success will true else it will be false
                    if (success == true)
                    {
                        //Candidate Successfuly Deleted
                        MessageBox.Show("Candidate successfully deleted.");
                        Clear();
                        //Refresh DAta Grid View
                        DataTable dt = cd.Select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Delete Candidate
                        MessageBox.Show("Failed to Delete Candidate.");
                    }
                }
                else
                {
                    MessageBox.Show("Kindly select any row from Grid");

                }
            }
            else
            {
                MessageBox.Show("Kindly select any row from Grid");
            }

        }

        public void Clear()
        {
            pictureBox1.Image = null;
            uploadButton.Visible = true;
            nameTextBox.Text = "";
            partyTextBox.Text = "";
            numberTextBox.Text = "";
            addressTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                uploadButton.Visible = false;
                nameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                partyTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                numberTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                addressTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                descriptionTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            VoteResults results = new VoteResults("-1", "CandidateForm");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }
    }
}

//private void addButton_Click(object sender, EventArgs e)
//        {

//            if (idTextBox.Text != "" && nameTextBox.Text != "" && partyTextBox.Text != "" && descriptionTextBox.Text != "" &&
//                votersTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "")
//            {
//                if (!isPresent(Convert.ToInt32(idTextBox.Text)))
//                {
//                    Candidate temp = new Candidate();

//                    temp.candidateId = Convert.ToInt32(idTextBox.Text);
//                    temp.candidateName = nameTextBox.Text;
//                    temp.party = partyTextBox.Text;
//                    temp.description = descriptionTextBox.Text;
//                    temp.candidateAddress = addressTextBox.Text;
//                    temp.candidatePhone = numberTextBox.Text;
//                    temp.numberOfVotes = Convert.ToInt32(votersTextBox.Text);

//                    list.Add(temp);
//                    load_data();
//                    clearFields();
//                }
//                else
//                {
//                    MessageBox.Show("This Candidate ID is already Present");
//                }
//            }
//            else
//            {
//                MessageBox.Show("Data must be required in ( * ) Field's");
//            }
//        }

//        private void removeButton_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
//                for (int i = 0; i < list.Count; i++)
//                {
//                    if (id == list[i].candidateId)
//                    {
//                        list.RemoveAt(i);
//                        break;
//                    }
//                }
//                load_data();
//                clearFields();
//            }
//            else
//            {
//                MessageBox.Show("Kindly select any row from Grid");
//            }
//        }

//        private void updateButton_Click(object sender, EventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0 && idTextBox.Text != "" && nameTextBox.Text != "" && partyTextBox.Text != ""
//                && descriptionTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "" && votersTextBox.Text != "")
//            {
//                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
//                for (int i = 0; i < list.Count; i++)
//                {
//                    if (id == list[i].candidateId)
//                    {
//                        list[i].candidateName = nameTextBox.Text;
//                        list[i].party = partyTextBox.Text;
//                        list[i].description = descriptionTextBox.Text;
//                        list[i].candidateAddress = addressTextBox.Text;
//                        list[i].candidatePhone = numberTextBox.Text;
//                        list[i].numberOfVotes = Convert.ToInt32(votersTextBox.Text);
//                        break;
//                    }
//                }
//                load_data();
//                clearFields();
//            }
//            else
//            {
//                MessageBox.Show("Kindly select any row from Grid");
//            }
//        }
//        private void clearFields()
//        {
//            idTextBox.Text = string.Empty;
//            nameTextBox.Text = string.Empty;
//            partyTextBox.Text = string.Empty;
//            numberTextBox.Text = string.Empty;
//            addressTextBox.Text = string.Empty;
//            descriptionTextBox.Text = string.Empty;
//            votersTextBox.Text = string.Empty;
//        }

//        private void load_data()
//        {
//            DataTable table = new DataTable();
//            table.Columns.Add("ID", typeof(int));
//            table.Columns.Add("Name", typeof(string));
//            table.Columns.Add("Party", typeof(string));
//            table.Columns.Add("Number", typeof(string));
//            table.Columns.Add("Voters", typeof(int));

//            for (int i = 0; i < list.Count; i++)
//            {
//                table.Rows.Add(list[i].candidateId, list[i].candidateName, list[i].party, list[i].candidatePhone, list[i].numberOfVotes);
//            }

//            dataGridView1.DataSource = table;
//            dataGridView1.Rows[0].ReadOnly = true;
//            dataGridView1.ClearSelection();
//        }

//        private void setData()
//        {
//            Candidate v1 = new Candidate();
//            Candidate v2 = new Candidate();
//            v1.candidateId = 1;
//            v1.candidateName = "ABC";
//            v1.party = "Part A";
//            v1.description = "Part A have Vision.";
//            v1.candidateAddress = "abc";
//            v1.candidatePhone = "1234567";
//            v1.numberOfVotes = 300;

//            v2.candidateId = 2;
//            v2.candidateName = "XYZ";
//            v2.party = "Part X";
//            v2.description = "Part X have Dream.";
//            v2.candidateAddress = "xyz";
//            v2.candidatePhone = "1234567";
//            v2.numberOfVotes = 600;

//            list.Add(v1);
//            list.Add(v2);
//        }

//        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
//                for (int i = 0; i < list.Count; i++)
//                {
//                    if (id == list[i].candidateId)
//                    {
//                        idTextBox.Text = list[i].candidateId.ToString();
//                        nameTextBox.Text = list[i].candidateName;
//                        partyTextBox.Text = list[i].party;
//                        descriptionTextBox.Text = list[i].description;
//                        addressTextBox.Text = list[i].candidateAddress;
//                        numberTextBox.Text = list[i].candidatePhone;
//                        votersTextBox.Text = list[i].numberOfVotes.ToString();
//                        break;
//                    }
//                }
//            }
//        }
//        private bool isPresent(int id)
//        {
//            for (int i = 0; i < list.Count; i++)
//            {
//                if (id == list[i].candidateId)
//                    return true;
//            }
//            return false;
//        }



