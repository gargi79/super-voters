using NUnit.Framework;
using SuperVoters;
using SuperVoters.Forms;
using System;

namespace SuperVotersIntegrationTests
{
    [TestFixture]
    public class Test_NewElection_IntegrationTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_NewElection_CreateAnDuplicatedElection_ShouldBeFailed()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            newElectionPage.LoadElectionData();

            //Act
            string result = newElectionPage.saveToElection("Test Election2", "3/27/2022", "4/5/2022", "School Election");
           
            //Assert
            Assert.IsTrue(result == "Failed");

        }

        [Test]
        public void Test_NewElection_CreateAnElectionWithNullElectionTopic_ShouldBeFailed()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            newElectionPage.LoadElectionData();

            //Act
            string result = newElectionPage.saveToElection("aaaaaaa", "3/27/2022", "4/5/2022", "Please Select An Election Category!");

            //Assert
            Assert.IsTrue(result == "Failed");
        }

        [Test]
        public void Test_NewElection_CreateAnElectionWithoutSelectingElectionCategory_ShouleBeFailed()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            newElectionPage.LoadElectionData();

            //Act
            string result = newElectionPage.saveToElection("", "3/27/2022", "4/5/2022", "School Election");

            //Assert
            Assert.IsTrue(result == "Failed");
        }

        //[Test]
        //public void Test_NewElection_CreateAnValidElection_ShouldRetunSuccessful()
        //{
        //    // this test was passed but can only be runned once since the database does not allow
        //    // duplicated data.
        //    //Arrange
        //    NewElectionPage1 newElectionPage = new NewElectionPage1();
        //    newElectionPage.LoadElectionData();

        //    //Act
        //    string result = newElectionPage.saveToElection("An Valid Election", "3/27/2022", "4/5/2022", "School Election");

        //    //Assert
        //    Assert.IsTrue(result == "Successful");
        //}

        //this test was passed and can be runned only once since the the database do not allow dupilcated
        //Candidates inserted into an election
        //[Test]
        //public void Test_SaveToElectionCandidateWithValidInputs_ShouldReturnSuccessful()
        //{
        //    //Arrange
        //    NewElectionPage2 newElectionPage = new NewElectionPage2(4);
        //    string result;

        //    //Act
        //    result = newElectionPage.SaveToElectionCandidate(4, 33);

        //    //Assert
        //    Assert.IsTrue(result == "Successful");
        //}
    }
}
