using NUnit.Framework;
using System.Windows.Forms;
using SuperVoters.Forms;
using System.Data;
using SuperVoters.Models;
using System.Collections.Generic;

namespace SuperVotersUnitTests
{
    [TestFixture]
    public class Test_NewElectionPage1
    {
        [SetUp]  // used share variable and data for all tests
        public void SetUp()
        { }

        [Test]
        public void Test_getElectionCategory_shouldReturnCorrectElectionCategory_FromComboBox()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            ComboBox elecCategoryList = new ComboBox();
            elecCategoryList.Items.Add("School Election");
            elecCategoryList.Items.Add("Community Election");
            elecCategoryList.Items.Add("Presidential Election");
            elecCategoryList.SelectedItem = "Presidential Election";

            //Act
            string electionCategory = newElectionPage.getElectionCategory(elecCategoryList);

            //Assert
            Assert.IsTrue(electionCategory == "Presidential Election");
        }

        [Test]
        public void Test_LoadElectionData_shouldReturnCorrectData()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();

            //Act
            DataTable dt = newElectionPage.LoadElectionData();

            //Assert
            Assert.IsNotNull(dt);
        }

        [Test]
        public void Test_GeElectionNames_ShouldReturnCorrectData()
        {
            //Arrange
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            List<ElectionData> electionNames = new List<ElectionData>();
            
            //Act
            electionNames = newElectionPage.GetElectionNames();

            //Assert
            Assert.IsNotNull(electionNames);
        }

        [Test]
        public void Test_validateElectionTopic_withEmptyInput_ShouldReturnFalse()
        {
            //Arrange
            bool result;
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            TextBox textBox = new TextBox();
            textBox.Text = "";

            //Act
            result = newElectionPage.validateElectionTopic(textBox);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_validateElectionCategory_withoutSelection_ShouldReturnFalse()
        {
            //Arrange
            bool result;
            NewElectionPage1 newElectionPage = new NewElectionPage1();
            ComboBox comboBox = new ComboBox();
            comboBox.Text = "Select an Election Category";

            //Act
            result = newElectionPage.validateElectionCategory(comboBox);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
