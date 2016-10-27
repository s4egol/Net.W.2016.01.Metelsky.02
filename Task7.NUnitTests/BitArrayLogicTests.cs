using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task7.NUnitTests
{
    [TestFixture]
    public class BitArrayLogicTests
    {
        [TestCase(8, 15, 0, 0, Result = 9)]
        [TestCase(0, 15, 30, 30, Result = 1073741824)]
        [TestCase(0, 15, 0, 30, Result = 15)]
        [TestCase(15, -15, 0, 4, Result = 17)]
        [TestCase(15, int.MaxValue, 3, 5, Result = 63)]
        public int Insertion_GetValue(int number1, int number2, int i, int j)
        {
            return Task7.BitArrayLogic.Insertion(number1, number2, i, j);
        }

        [TestCase(8, 15, 3, 1)]
        [TestCase(0, 15, 5, 2)]
        public void Insertion_GetValueException(int number1, int number2, int i, int j)
        {
            Assert.Throws(typeof (ArgumentException), () => Task7.BitArrayLogic.Insertion(number1, number2, i, j));
        }
    }
}
