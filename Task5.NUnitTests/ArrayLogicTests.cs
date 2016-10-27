using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task5.NUnitTests
{
    [TestFixture]
    public class ArrayLogicTests
    {
        [TestCase(new int[] {5,6,7,6,5}, Result = 2)]
        [TestCase(new int[] { 1,2,3 }, Result = -1)]
        [TestCase(new int[] { 0 }, Result = -1)]
        [TestCase(new int[] { -1, 2, -1 }, Result = 1)]
        public int GetIndex_returnedValue(int[] arr)
        {
            return Task5.ArrayLogic.GetIndex(arr);
        }


        [TestCase(null)]
        public void GetIndex_returnedException(int[] arr)
        {
            Assert.Throws(typeof (ArgumentException), () => Task5.ArrayLogic.GetIndex(arr));
        }
    }
}
