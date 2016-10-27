using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task6.NUnitTests
{
    [TestFixture]
    public class StringLogicTests
    {
        [TestCase("ab", "ab", Result = "ab")]
        [TestCase("cba", "dcba", Result = "abcd")]
        [TestCase("bza", "a", Result = "abz")]
        public string GetNotRepeatingSequence_DistinctOrderValue(string str1, string str2)
        {
            StringBuilder value1 = new StringBuilder(str1);
            StringBuilder value2 = new StringBuilder(str2);
            return Task6.StringLogic.GetNotRepeatingSequence(value1, value2).ToString();
        }

        [TestCase("ab", null)]
        [TestCase(null, "cb")]
        public void GetNotRepeatingSequence_DistinctOrderValueException(string str1, string str2)
        {
            StringBuilder value1;
            StringBuilder value2;

            if (str1 == null)
                value1 = null;
            else 
                value1 = new StringBuilder(str1);

            if (str2 == null)
                value2 = null;
            else
                value2 = new StringBuilder(str2);

            Assert.Throws(typeof (ArgumentException), () => Task6.StringLogic.GetNotRepeatingSequence(value1, value2));
        }

    }
}
