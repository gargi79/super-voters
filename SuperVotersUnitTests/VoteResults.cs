using NUnit.Framework;
using SuperVoters.Forms;
using System.Windows.Forms;

namespace SuperVotersUnitTests
{
    [TestFixture]
    public class Test_VoteResults
    {
        [SetUp]  // used share variable and data for all tests
        public void SetUp()
        { }

        [Test]
        public void Test_GetReturnPage_ShouldReturnCorrectForm_ForPendingElection()
        {
            //Arrange
            VoteResults _voteResults = new VoteResults("", "PendingElection");

            //Act
            Form form = _voteResults.GetReturnPage();

            //Assert
            Assert.IsTrue(form.Name == "PendingElection");
        }
        [Test]
        public void Test_GetReturnPage_ShouldReturnCorrectForm_ForCandidateForm()
        {
            //Arrange
            VoteResults _voteResults = new VoteResults("", "CandidateForm");

            //Act
            Form form = _voteResults.GetReturnPage();

            //Assert
            Assert.IsTrue(form.Name == "CandidateForm");
        }
        [Test]
        public void Test_GetReturnPage_ShouldReturnCorrectForm_ForNewElection()
        {
            //Arrange
            VoteResults _voteResults = new VoteResults("", "NewElectionPage1");

            //Act
            Form form = _voteResults.GetReturnPage();

            //Assert
            Assert.IsTrue(form.Name == "NewElectionPage1");
        }
        [Test]
        public void Test_GetReturnPage_ShouldReturnCorrectForm_ForDeleteElection()
        {
            //Arrange
            VoteResults _voteResults = new VoteResults("", "PendingElection");

            //Act
            Form form = _voteResults.GetReturnPage();

            //Assert
            Assert.IsTrue(form.Name == "PendingElection");
        }
    }
}