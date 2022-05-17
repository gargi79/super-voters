using SuperVoters.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperVoters.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Registration());
            //Application.Run(new NewElectionPage1(-1));
            //Application.Run(new DeleteElection());
            //Application.Run(new AdminPage());
            //Application.Run(new PendingElection(2));

            try
            {
                Utilities.SendEmailToAdmin("Hello Admin, the SuperVoters application has started.");
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error, "Could not start SuperVoters: " + ex.Message);
                Utilities.SendEmailToAdmin("Hello Admin, the SuperVoters application will not start.");
            }  
 
            Application.Exit();
        }
    }
}
