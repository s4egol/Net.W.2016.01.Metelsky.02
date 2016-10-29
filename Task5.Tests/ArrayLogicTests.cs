using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task5.Tests
{
    [TestClass]
    public class ArrayLogicTests
    {
        [TestMethod]
        public void GetIndex_Array_1_2_3_2_1_ReturnedIndex2()
        {
            int[] array = {1, 2, 3, 2, 1};

            int? index = Task5.ArrayLogic.GetIndex(array);

            Assert.AreEqual(2,index);
        }

        [TestMethod]
        public void GetIndex_Array_1_2_3_4_5_ReturnedNull()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            int? index = Task5.ArrayLogic.GetIndex(array);

            Assert.AreEqual(null, index);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetIndex_Array_null_ReturnedNullReferenceException()
        {
            int[] array = null;

            int? index = Task5.ArrayLogic.GetIndex(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetIndex_ArrayWithoutValue_ReturnedArgumentException()
        {
            int[] array = {};

            int? index = Task5.ArrayLogic.GetIndex(array);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void GetIndex_Array_0_intMaxValue_1_2_ReturnedOverflowException()
        {
            int[] array = new int[] { 10, int.MaxValue, 15, 10 };

            int? index = Task5.ArrayLogic.GetIndex(array);
        }

        [TestMethod]
        public void GetIndex_Array_2_ReturnedIndexNull()
        {
            int[] array = {2};

            int? index = Task5.ArrayLogic.GetIndex(array);

            Assert.AreEqual(null, index);
        }
    }
}
