
using SuperVoters.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters
{
    public partial class VoterForm : Form
    {
        //List<Voter> list = new List<Voter>();
        VoterDAL vd = new VoterDAL();
        Voter v = new Voter();

        

        public VoterForm()
        {
            InitializeComponent();
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (votedCheckBox.Checked)
        //    {
        //        votedCheckBox.Text = "Yes";
        //    }
        //    else
        //    {
        //        votedCheckBox.Text = "No";
        //    }
        //}

        //private void load_data()
        //{
        //    DataTable table = new DataTable();
        //    table.Columns.Add("ID", typeof(int));
        //    table.Columns.Add("VName", typeof(string));
        //    table.Columns.Add("FName", typeof(string));
        //    table.Columns.Add("LName", typeof(string));
        //    table.Columns.Add("Email", typeof(string));
        //    table.Columns.Add("Voted", typeof(bool));

        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        table.Rows.Add(list[i].voterId, list[i].voterName, list[i].firstName, list[i].lastName, list[i].email, list[i].isVoted);
        //    }

        //    dataGridView1.DataSource = table;
        //    dataGridView1.Rows[0].ReadOnly = true;
        //    dataGridView1.ClearSelection();

        //    //votedCheckBox.Checked = true;
        //}

        //private void setData()
        //{
        //    Voter v1 = new Voter();
        //    Voter v2 = new Voter();
        //    v1.voterId = 1;
        //    v1.voterName = "ABC";
        //    v1.firstName = "A";
        //    v1.middleName = "B";
        //    v1.lastName = "C";
        //    v1.email = "ABC@gmail.com";
        //    v1.isVoted = true;
        //    v1.address = "abc";
        //    v1.dateOfBirth = "1/3/2022";
        //    v1.phoneNumber = "1234567";

        //    v2.voterId = 2;
        //    v2.voterName = "XYZ";
        //    v2.firstName = "X";
        //    v2.middleName = "Y";
        //    v2.lastName = "Z";
        //    v2.email = "XYZ@gmail.com";
        //    v2.isVoted = false;
        //    v2.address = "xyz";
        //    v2.dateOfBirth = "2/3/2022";
        //    v2.phoneNumber = "1234567";

        //    list.Add(v1);
        //    list.Add(v2);
        //}

        private void VoterForm_Load(object sender, EventArgs e)
        {
            DataTable loadVotersdt = vd.Select();
            if (loadVotersdt != null)
            {
                if (loadVotersdt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = loadVotersdt;
                    dataGridView1.Rows[0].ReadOnly = true;
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                fnameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                mnameTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                lnameTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dobTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                numberTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                addressTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                emailTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }
        }






        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (fnameTextBox.Text != "" && lnameTextBox.Text != "" &&
            dobTextBox.Text != "" && numberTextBox.Text != "" && mnameTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "")
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    v.voterId = id;

                    //Create Bool VAriable to Check if the voter is deleted or not
                    bool success = vd.Delete(v);

                    //If voter is deleted successfully then the value of success will true else it will be false
                    if (success == true)
                    {
                        //Voter Successfuly Deleted
                        MessageBox.Show("Voter successfully deleted.");
                        Clear();
                        //Refresh DAta Grid View
                        DataTable dt = vd.Select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Delete Voter
                        MessageBox.Show("Failed to Delete Voter.");
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

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0 && idTextBox.Text != "" && nameTextBox.Text != "" && fnameTextBox.Text != ""
        //        && lnameTextBox.Text != "" && dobTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "" && numberTextBox.Text != "")
        //    {
        //        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (id == list[i].voterId)
        //            {          
        //                list[i].voterName = nameTextBox.Text;
        //                list[i].firstName = fnameTextBox.Text;

        //                if(mnameTextBox.Text != "")
        //                    list[i].middleName = mnameTextBox.Text;
        //                else
        //                    list[i].middleName = string.Empty;

        //                list[i].lastName = lnameTextBox.Text;
        //                list[i].dateOfBirth = dobTextBox.Text;
        //                list[i].email = emailTextBox.Text;
        //                list[i].address = addressTextBox.Text;
        //                list[i].isVoted = votedCheckBox.Checked;
        //                list[i].phoneNumber = numberTextBox.Text;
        //                break;
        //            }
        //        }
        //        load_data();
        //        clearFields();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kindly select any row from Grid");
        //    }
        //}

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {


                if (fnameTextBox.Text != "" && lnameTextBox.Text != "" &&
                dobTextBox.Text != "" && numberTextBox.Text != "" && mnameTextBox.Text != "" && emailTextBox.Text != "" && addressTextBox.Text != "")
                {
                    v.firstName = fnameTextBox.Text;
                    v.lastName = lnameTextBox.Text;
                    v.dateOfBirth = dobTextBox.Text;
                    v.phoneNumber = numberTextBox.Text;
                    v.middleName = mnameTextBox.Text;
                    v.address = addressTextBox.Text;
                    v.email = emailTextBox.Text;
                    //Create Boolean variable to check if the voter is added successfully or not
                    bool success = vd.Insert(v);
                    //if the voter is added successfully then the value of success will be true else it will be false
                    if (success == true)
                    {
                        //Candidate Inserted Successfully
                        MessageBox.Show("Voter Added Successfully");
                        //Calling the Clear Method
                        Clear();
                        //Refreshing DAta Grid View
                        DataTable dt = vd.Select();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        //Failed to Add New Candidate
                        MessageBox.Show("Failed to Add New Voter");
                    }
                }
                else
                {
                    MessageBox.Show("Data must be required in ( * ) Field's");
                }
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error,"An error occurred: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        //private bool isPresent(int id)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (id == list[i].voterId)
        //            return true;
        //    }
        //    return false;
        //}

        private void fnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            fnameTextBox.Text = "";
            mnameTextBox.Text = "";
            lnameTextBox.Text = "";
            numberTextBox.Text = "";
            dobTextBox.Text = "";
            addressTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void mnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
