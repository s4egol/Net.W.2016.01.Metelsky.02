using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task6.Tests
{
    [TestClass]
    public class StringLogicTests
    {
        [TestMethod]
        public void GetNotRepeatingSequence_StringAbcAndStringBcd_ReturnedStringAbcd()
        {
            String string1 = "abc";
            String string2 = "bcd";

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("abcd"), result);
        }

        [TestMethod]
        public void GetNotRepeatingSequence_StringBbaaAndStringBbaa_ReturnedStringAb()
        {
            String string1 = "bbaa";
            String string2 = "bbaa";

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("ab"), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNotRepeatingSequence_StringNullAndStringBbaa_ReturnedArgumentException()
        {
            String string1 = null;
            String string2 = "bbaa";

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNotRepeatingSequence_StringAbcdAndStringNull_ReturnedArgumentException()
        {
            String string1 = "abcd";
            String string2 = null;

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
        }

        [TestMethod]
        public void GetNotRepeatingSequence_StringAbcdAndStringEmpty_ReturnedStringAbcd()
        {
            String string1 = "abcd";
            String string2 = String.Empty;

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("abcd"), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNotRepeatingSequence_StringEmptyAndStringEmpty_ReturnedArgumentException()
        {
            String string1 = String.Empty;
            String string2 = String.Empty;

            String returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
        }
    }
}
