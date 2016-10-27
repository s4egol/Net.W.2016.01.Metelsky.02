using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task7.Tests
{
    [TestClass]
    public class BitArrayLogicTests
    {
        [TestMethod]
        public void Insertion_15InsertIn8InBits0To0_Returned9()
        {
            int number1 = 8;
            int number2 = 15;
            int i = 0;
            int j = 0;

            int newNumber = Task7.BitArrayLogic.Insertion(number1, number2, i, j);

            Assert.AreEqual(9, newNumber);
        }

        [TestMethod]
        public void Insertion_15InsertIn0InBits30To30_Returned1073741824()
        {
            int number1 = 0;
            int number2 = 15;
            int i = 30;
            int j = 30;

            int newNumber = Task7.BitArrayLogic.Insertion(number1, number2, i, j);

            Assert.AreEqual(1073741824, newNumber);
        }

        [TestMethod]
        public void Insertion_15InsertIn0InBits0To30_Returned15()
        {
            int number1 = 0;
            int number2 = 15;
            int i = 0;
            int j = 30;

            int newNumber = Task7.BitArrayLogic.Insertion(number1, number2, i, j);

            Assert.AreEqual(15, newNumber);
        }

        [TestMethod]
        public void Insertion_Minus15InsertIn15InBits0To4_Returned17()
        {
            int number1 = 15;
            int number2 = -15;
            int i = 0;
            int j = 4;

            int newNumber = Task7.BitArrayLogic.Insertion(number1, number2, i, j);

            Assert.AreEqual(17, newNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Insertion_IntMaxValueInsertIn15InBits5To3_Returned63()
        {
            int number1 = 15;
            int number2 = int.MaxValue;
            int i = 5;
            int j = 3;

            int newNumber = Task7.BitArrayLogic.Insertion(number1, number2, i, j);
        }
    }
}
