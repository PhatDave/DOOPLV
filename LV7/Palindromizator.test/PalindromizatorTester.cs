using NUnit.Framework;
using System;

namespace Palindromizator.Test {
    [TestFixture]
    class PalindromizatorTester {
        [TestCase("Anna")]
        [TestCase("oko")]
        [TestCase("Kisik")]
        [TestCase("neven")]
        [TestCase("ImaJu ArAPi I paRa u jAMi")]
        [TestCase("1331")]
        public void IsPalindrom_WhenInputIsPalindrom_ReturnsTrue(string message) {
            var palindromizatorer = new Palindromizatorer();
            bool expected = true;

            bool actual = palindromizatorer.IsPalindrom(message);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        // Ime?
        public void IsPalindrom_WhenInputHasSpecialCharacter_ReturnsIsPalindrom() {
            var palindromizatorer = new Palindromizatorer();
            var message = "Nakrao Arkan!";
            bool expected = true;

            bool actual = palindromizatorer.IsPalindrom(message);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsPalindrom_WhenInputIsLoremIpsum_ReturnsFalse() {
            var palindromizatorer = new Palindromizatorer();
            string message = "LoremIpsum";
            bool expected = false;

            bool actual = palindromizatorer.IsPalindrom(message);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsPalindrom_WhenInputIsAna_Voli_Milovana_ReturnsTrue() {
            var palindromizatorer = new Palindromizatorer();
            string message = "Ana voli Milovana";
            bool expected = true;

            bool actual = palindromizatorer.IsPalindrom(message);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsPalindrom_WhenInputIsEmpty_ThrowsArgumentException() {
            var palindromizatorer = new Palindromizatorer();
            string message = "";
            Assert.Throws<ArgumentException>(() => palindromizatorer.IsPalindrom(message));
        }
    }
}
