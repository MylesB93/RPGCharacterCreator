using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPGCharacterCreator.Classes;

namespace RPGCharacterCreator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Character_CreateNewCharacter_ClassIsValid()
        {
            var classInt = 1;
            var character = new Character(classInt);
            Assert.AreEqual("Warrior", character.Class.ToString());
        }

        [TestMethod]
        public void Character_CreateNewCharacter_ClassSetToDefaultIfInputIsZeroOrLess()
        {
            var classInt = 0;
            var character = new Character(classInt);
            Assert.AreEqual("Warrior", character.Class.ToString());
        }

        [TestMethod]
        public void Character_CreateNewCharacter_ClassSetToLastValueIfInputIsGreaterThanMax()
        {
            var classInt = 1000;
            var character = new Character(classInt);
            Assert.AreEqual("Archer", character.Class.ToString());
        }
    }
}
