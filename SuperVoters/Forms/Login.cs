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
using System.Diagnostics;

namespace SuperVoters.Forms
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Utilities.IsAdmin = false;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            UserNameError.Visible = false;
            var settings = new Properties.Settings();
            var connString = settings.SuperVotersConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            String username, password;

            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                String querry = "SELECT * FROM Login WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    Utilities.LogTime(ts, "Login Authentication");

                    LogFactory.WriteLog(LogFactory.Level.Info, "Login successful");

                    username = txt_username.Text;
                    password = txt_password.Text;

                    //Get the voterId
                    string retValue = "";
                    int voterId = DataAccessLayer.GetVoterIdByUserName(username, ref retValue);

                    // load the next form
                    this.Hide();
                    if (username == "Admin")
                    {
                        Utilities.IsAdmin = true;
                        NewElectionPage1 newElection = new NewElectionPage1();
                        newElection.Show();
                    }
                    else
                    {
                        PendingElection pendingElection = new PendingElection(voterId);
                        pendingElection.Show();
                    }
                    //this.Close();
                    
                }
                else
                {
                    UserNameError.Visible = true;
                    LogFactory.WriteLog(LogFactory.Level.Warn, UserNameError.Text);

                    //MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txt_username.Clear();
                    //txt_password.Clear();

                    //This caused conflicts - dk
                    //txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Login does not exist. Try again.");
            }
            finally
            {
                conn.Close();
            }
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration someform = new Registration();
            someform.Show();
            //this.Close();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Utilities.IsAdmin = false;
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilities.OpenHelpFile(Utilities.IsAdmin);
        }

        //private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        button_login.PerformClick();
        //    }
        //}
    }
}
