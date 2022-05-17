using NUnit.Framework;
using System.Windows.Forms;
using SuperVoters;

namespace SuperVotersUnitTests
{
    [TestFixture]
    public class Test_Registration
    {
        [SetUp]  // used share variable and data for all tests
        public void SetUp()
        { }

        [Test]
        public void Test_GetParty_ShouldReturnCorrectParty_FromComboBox()
        {
            //Arrange
            Registration registration = new Registration();
            ComboBox comboBoxParty = new ComboBox();
            comboBoxParty.Items.Add("None");
            comboBoxParty.Items.Add("Democrat");
            comboBoxParty.Items.Add("Republican");
            comboBoxParty.SelectedItem = "Republican";

            //Act
            string party = registration.GetParty(comboBoxParty);

            //Assert
            Assert.IsTrue(party == "Republican");
        }

        [Test]
        public void Test_GetParty_ShouldReturnEmpty_FromComboBox()
        {
            //Arrange
            Registration registration = new Registration();
            ComboBox comboBoxParty = new ComboBox();
            comboBoxParty.Items.Add("None");
            comboBoxParty.Items.Add("Democrat");
            comboBoxParty.Items.Add("Republican");
            comboBoxParty.SelectedItem = "None";

            //Act
            string party = registration.GetParty(comboBoxParty);

            //Assert
            Assert.AreEqual("", party);
        }
    }
}