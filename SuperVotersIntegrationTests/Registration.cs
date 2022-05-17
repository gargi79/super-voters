using NUnit.Framework;
using SuperVoters;
using System;

namespace SuperVotersIntegrationTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Registration_CreatedAVoter()
        {
            //Arrange
            int milliseconds = DateTime.Now.Millisecond;
            string userName = "Dave" + milliseconds.ToString();
            Registration registration = new Registration();

            //Act
            int voterId = registration.SaveData(userName, "11111111", "Voter", "Dave", "E", "Tester", "11/25/1988", "123@dd.com", "123 smith rd", "425-222-2222", "None");

            //Assert
            Assert.IsTrue(voterId > 0);
            Console.WriteLine("VoterId:" + voterId);
        }

        [Test]
        public void Test_Registration_DidNotCreateAVoter_withbadInput()
        {
            //Arrange
            int milliseconds = DateTime.Now.Millisecond;
            string userName = "Dave" + milliseconds.ToString();
            Registration registration = new Registration();

            //Act
            int voterId = registration.SaveData(userName, "11111111111111111111111111111111111111111111", "Voter", "Dave", "E", "Tester", "11/25/1988", "123@dd.com", "123 smith rd", "425-222-2222", "None");

            //Assert
            Assert.IsFalse(voterId > 0);
            Console.WriteLine("VoterId:" + voterId);
        }
    }
}