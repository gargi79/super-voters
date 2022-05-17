using NUnit.Framework;
using System.Windows.Forms;
using SuperVoters.Forms;
using System.Data;
using SuperVoters.Models;
using System.Collections.Generic;

namespace SuperVotersUnitTests
{
    [TestFixture]
    public class Test_DeleteElection
    {
        [SetUp]  // used share variable and data for all tests
        public void SetUp()
        { }

        [Test]
        public void Test_getElectionCategory_shouldReturnCorrectElectionCategory_FromComboBox()
        {
            //Arrange
            DeleteElection deleteElection = new DeleteElection();
            ComboBox cboElecCat = new ComboBox();
            cboElecCat.Items.Add("School Election");
            cboElecCat.Items.Add("Community Election");
            cboElecCat.Items.Add("Presidential Election");
            cboElecCat.Items.Add("Other");
            cboElecCat.SelectedItem = "School Election";

            //Act
            string electionCategory = deleteElection.getElectionCategory(cboElecCat);

            //Assert
            Assert.IsTrue(electionCategory == "School Election");
        }

        [Test]
        public void Test_LoadElections_shouldReturnCorrectData()
        {
            //Arrange
            DeleteElection deleteElection = new DeleteElection();

            //Act
            DataTable dt = deleteElection.LoadElections();

            //Assert
            Assert.IsNotNull(dt);
        }

        // this test was passed, but can be runned only once since the eletion
        // with Id = 66 has been removed from the database.
        //[Test]
        //public void Test_deleteElection_WithValidElectionId_ShouldReturnSuccessful()
        //{
        //    //Arrange
        //    DeleteElection deleteElection = new DeleteElection();
        //    string result;
        //    //Act
        //    result = deleteElection.deleteElection(66);

        //    //Assert
        //    Assert.IsTrue(result == "Successful");
        //}

        [Test]
        public void Test_filterByDateWithValidDate_ShouldReturnElectionsFilteredByDate()
        {
            //Arrange
            DeleteElection deleteElection = new DeleteElection();
            int numOfRows;

            //Act
            numOfRows = deleteElection.filterByDate("3/9/2022", "3/18/2022");

            //there should be 7 rows
            //Assert
            Assert.IsTrue(numOfRows > 0);
        }

        [Test]
        public void Test_filterByElectionCategory_ShouldRetunElectionsFilteredByTheSelectedElectionCategory()
        {
            //Arrange
            DeleteElection deleteElection = new DeleteElection();
            int numOfRows;
            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("School Election");
            comboBox.Items.Add("Community Election");
            comboBox.Items.Add("Presidential Election");
            comboBox.Items.Add("Other");
            comboBox.SelectedItem = "School Election";

            //Act
            numOfRows = deleteElection.filterByElectionCategory(comboBox);

            //there should be 5 rows
            //Assert
            Assert.IsTrue(numOfRows > 0);
        }

        [Test]
        public void Test_filterByElectionTopic_ShouldRetunElectionsFilteredByTypedElectionTopic()
        {
            //Arrange
            DeleteElection deleteElection = new DeleteElection();
            int numOfRows;
            TextBox textBox = new TextBox();
            textBox.Text = "test";

            //Act
            numOfRows = deleteElection.filterByElectionTopic(textBox);

            //there should be 4 rows
            //Assert
            Assert.IsTrue(numOfRows > 0);
        }
    }
}
