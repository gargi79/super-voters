using NUnit.Framework;
using SuperVoters.Services;

namespace SuperVotersUnitTests
{
    [TestFixture]
    internal class CastVoteTest
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void TestCheckIsCapableOfVoting()
        {
            // Must run before running TestCastNewVote to pass
            // this test.
            bool res = VoteService.CheckIsCapableOfVoting(-1, -1);
            Assert.AreEqual(res, true);
        }
        [Test]
        public void TestCastNewVote()
        {
            // Creates a new record. In order to pass TestCheckIsCapableOfVoting
            // test, run TestCheckIsCapableOfVoting before running this or
            // run TestDeleteVote to delete records (if that passes).
            int res = VoteService.CastNewVote(-1, -1, -1);
            Assert.AreEqual(res, 0);
        }
        [Test]
        public void TestDeleteVote()
        {
            // Must run after running TestCastNewVote to pass
            // this test.
            int res = VoteService.DeleteVote(-1, -1, -1);
            Assert.AreEqual(res, 0);
        }
    }
}
