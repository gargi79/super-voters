using NUnit.Framework;
using NUnit.Framework.Internal;
using SuperVoters;
using SuperVoters.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SuperVotersUnitTests
{
    [TestFixture]
    internal class CandidateTest
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void TestCandidateListLoad()
        {
            // Tests if the data load is working.
            var cad = new CandidateDAL();
            DataTable dt = cad.Select();
            Assert.IsNotNull(dt);
        }

        [Test]
        public void TestCandidateDelete()
        {
            // Tests candidate deletation
            var cad = new CandidateDAL();
            bool delRes = cad.Delete(new Candidate());
            Assert.AreEqual(delRes, false);
        }
        [Test]
        public void TestCandidateCreationTrueAndDeleteFalse()
        {
            var cad = new CandidateDAL();
            var candidate = new Candidate()
            {
                candidateName = "Jon Doe",
                candidateAddress = "Oak Park",
                candidatePhone = "+123",
                description = "This is a test candidate.",
                party = "Demo",
                imageData = Array.Empty<byte>()
            };
            bool creRes = cad.Insert(candidate);
            Assert.AreEqual(creRes, true);
            bool delRes = cad.Delete(candidate);
            Assert.AreEqual(delRes, false);
            // Run TestCandidateCreationTrueAndDeleteTrue at least for once
            // to delete this entity for real.

        }
        [Test]
        public void TestCandidateCreationTrueAndDeleteTrue()
        {
            var cad = new CandidateDAL();
            var candidate = new Candidate()
            {
                candidateName = "Jon Doe",
                candidateAddress = "Oak Park",
                candidatePhone = "+123",
                description = "This is a test candidate.",
                party = "Demo",
                imageData = Array.Empty<byte>()
            };
            bool creRes = cad.Insert(candidate);
            Assert.AreEqual(creRes, true);

            DataTable dt = cad.Select();

            List<Candidate> candidates = (from DataRow dr in dt.Rows
                                          select new Candidate
                                          {
                                              candidateId = Convert.ToInt32(dr["CandidateId"]),
                                              candidateName = dr["Name"].ToString(),
                                              candidateAddress = dr["Address"].ToString(),
                                              candidatePhone = dr["Phone"].ToString(),
                                              description = dr["Description"].ToString(),
                                          }).ToList();


            // Here enumerating through all matched value since 
            // in the previous test we may created a record 
            // with the same data as this method but failed to 
            // delete that.
            List<Candidate> cans = candidates.Where(c =>
            {
                if (c.candidateName != candidate.candidateName) return false;
                return c.candidatePhone == candidate.candidatePhone
                       && c.candidateAddress == candidate.candidateAddress
                       && c.description == candidate.description;
            }).ToList();



            foreach (bool delRes in cans.Select(can => cad.Delete(can)))
            {
                Assert.AreEqual(delRes, true);
            }
        }
    }
}
