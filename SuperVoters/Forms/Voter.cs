using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperVoters
{
   public class Voter
    {
        public int voterId { get; set; }
        public string voterName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string dateOfBirth { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public bool isVoted { get; set; }

        public Voter()
        { }
    }
}