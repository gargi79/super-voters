using NUnit.Framework;
using System.Windows.Forms;
using SuperVoters.Forms;
using System.Data;
using SuperVoters.Models;
using System.Collections.Generic;

namespace SuperVotersUnitTests
{
    [TestFixture]
    public class Test_NewElectionPage2
    {

        [SetUp]  // used share variable and data for all tests
        public void SetUp()
        { }

        [Test]
        public void Test_LoadCandidateData_shouldReturnCorrectData()
        {
            //Arrange
            NewElectionPage2 newElectionPage = new NewElectionPage2(4);

            //Act
            DataTable dt = newElectionPage.LoadCandidateData();

            //Assert
            Assert.IsNotNull(dt);
        }

        [Test]
        public void Test_LoadElectionCandidateData_shouldReturnCorrectData()
        {
            //Arrange
            NewElectionPage2 newElectionPage = new NewElectionPage2(4);

            //Act
            DataTable dt = newElectionPage.LoadElectionCandidateData();

            //Assert
            Assert.IsNotNull(dt);
        }

        [Test]
        public void Test_checkDuplicateCandidateWihtDuplidatedCandidateId_ShouldReturnFalse()
        {
            //Arrange
            NewElectionPage2 newElectionPage = new NewElectionPage2(4);
            newElectionPage.LoadCandidateData();
            bool result;

            //Act
            // the candidateID = 6 already exist in Election with Id=4
            result = newElectionPage.checkDuplicateCandidate(6);

            //Assert
            Assert.IsFalse(result);
        }

        //this test was passed and can be runned only once since the the database do not allow dupilcated
        //Candidates inserted into an election
        //[Test]
        //public void Test_SaveToElectionCandidateWithValidInputs_ShouldReturnSuccessful()
        //{
        //    //Arrange
        //    NewElectionPage2 newElectionPage = new NewElectionPage2(4);
        //    string result;

        //    //Act
        //    result = newElectionPage.SaveToElectionCandidate(4,33);

        //    //Assert
        //    Assert.IsTrue(result == "Successful");
        //}

        [Test]
        public void Test_SaveToElectionCandidateWithNotValidCandidateID_ShouldReturnFailed()
        {
            // An valid electionId
            // Candidate Id does not exist
            //Arrange
            NewElectionPage2 newElectionPage = new NewElectionPage2(4);
            string result;

            //Act
            result = newElectionPage.SaveToElectionCandidate(4, 88888);

            //Assert
            Assert.IsTrue(result == "Failed");
        }

        [Test]
        public void Test_SaveToElectionCandidateWithNotValidElectionID_ShouldReturnFailed()
        {
            //Arrange
            NewElectionPage2 newElectionPage = new NewElectionPage2(88888);
            string result;

            //Act
            result = newElectionPage.SaveToElectionCandidate(88888, 33);

            //Assert
            Assert.IsTrue(result == "Failed");
        }
    }
}
