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
            return Task6.StringLogic.GetNotRepeatingSequence(str1, str2).ToString();
        }

        [TestCase("ab", null)]
        [TestCase(null, "cb")]
        [TestCase("", "")]
        public void GetNotRepeatingSequence_DistinctOrderValueException(string str1, string str2)
        {
            Assert.Throws(typeof (ArgumentException), () => Task6.StringLogic.GetNotRepeatingSequence(str1, str2));
        }

    }
}
