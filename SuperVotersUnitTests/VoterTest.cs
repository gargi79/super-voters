using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using NUnit.Framework;
using SuperVoters;
using SuperVoters.DAL;

namespace SuperVotersUnitTests
{
    [TestFixture]
    internal class VoterTest
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void TestVoterListLoad()
        {
            var vtd = new VoterDAL();
            DataTable dt = vtd.Select();
            Assert.IsNotNull(dt);
        }
        [Test]
        public void TestVoterDelete()
        {
            var vtd = new VoterDAL();
            bool delRes = vtd.Delete(new Voter());
            Assert.AreEqual(delRes, false);
        }
        [Test]
        public void TestVoterCreationTrueAndDeleteFalse()
        {
            var vtd = new VoterDAL();
            var voter = new Voter()
            {
                firstName = "Jon",
                lastName = "Doe",
                middleName = "Mark",
                address = "Oak Park",
                phoneNumber = "+123",
                email = "test@email.com",
                dateOfBirth = (new DateTime(2000, 12, 1)).ToString(CultureInfo.InvariantCulture)
            };
            bool creRes = vtd.Insert(voter);
            Assert.AreEqual(creRes, true);
            bool delRes = vtd.Delete(voter);
            Assert.AreEqual(delRes, false);
            // Run TestVoterCreationTrueAndDeleteTrue at least for once
            // to delete this entity for real.
        }
        [Test]
        public void TestVoterCreationTrueAndDeleteTrue()
        {
            var vtd = new VoterDAL();
            var voter = new Voter()
            {
                firstName = "Jon",
                lastName = "Doe",
                middleName = "Mark",
                address = "Oak Park",
                phoneNumber = "+123",
                email = "test@email.com",
                dateOfBirth = (new DateTime(2000, 12, 1)).ToString(CultureInfo.InvariantCulture)
            };
            bool creRes = vtd.Insert(voter);
            Assert.AreEqual(creRes, true);
            DataTable dt = vtd.Select();
            List<Voter> voters = (from DataRow dr in dt.Rows
                                  select new Voter
                                  {
                                      voterId = Convert.ToInt32(dr["VoterId"]),
                                      firstName = dr["FirstName"].ToString(),
                                      lastName = dr["LastName"].ToString(),
                                      middleName = dr["MiddleName"].ToString(),
                                      address = dr["Address"].ToString(),
                                      phoneNumber = dr["Phone"].ToString(),
                                      email = dr["Email"].ToString(),
                                      dateOfBirth = dr["DateOfBirth"].ToString(),
                                  }).ToList();


            // Here enumerating through all matched value since 
            // in the previous test we may created a record 
            // with the same data as this method but failed to 
            // delete that.
            IEnumerable<Voter> vos = voters.Where(c =>
            {
                if (c.firstName != voter.firstName) return false;
                return c.lastName == voter.lastName
                       && c.middleName == voter.middleName
                       && c.dateOfBirth == voter.dateOfBirth
                       && c.email == voter.email
                       && c.address == voter.address
                       && c.phoneNumber == voter.phoneNumber;
            });
            foreach (Voter vt in vos)
            {
                bool delRes = vtd.Delete(vt);
                Assert.AreEqual(delRes, true);
            }
        }
    }
}