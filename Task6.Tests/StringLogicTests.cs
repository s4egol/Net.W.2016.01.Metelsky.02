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
            StringBuilder string1 = new StringBuilder("abc");
            StringBuilder string2 = new StringBuilder("bcd");

            StringBuilder returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("abcd"), result);
        }

        [TestMethod]
        public void GetNotRepeatingSequence_StringBbaaAndStringBbaa_ReturnedStringAb()
        {
            StringBuilder string1 = new StringBuilder("bbaa");
            StringBuilder string2 = new StringBuilder("bbaa");

            StringBuilder returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("ab"), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNotRepeatingSequence_StringNullAndStringBbaa_ReturnedArgumentException()
        {
            StringBuilder string1 = null;
            StringBuilder string2 = new StringBuilder("bbaa");

            StringBuilder returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetNotRepeatingSequence_StringAbcdAndStringNull_ReturnedArgumentException()
        {
            StringBuilder string1 = new StringBuilder("abcd");
            StringBuilder string2 = null;

            StringBuilder returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
        }

        [TestMethod]
        public void GetNotRepeatingSequence_StringAbcdAndStringEmpty_ReturnedStringAbcd()
        {
            StringBuilder string1 = new StringBuilder("abcd");
            StringBuilder string2 = new StringBuilder();

            StringBuilder returnedString = Task6.StringLogic.GetNotRepeatingSequence(string1, string2);
            string result = String.Intern(returnedString.ToString());

            Assert.AreEqual(String.Intern("abcd"), result);
        }
    }
}
