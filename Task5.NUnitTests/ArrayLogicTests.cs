using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Task5.NUnitTests
{
    [TestFixture]
    public class ArrayLogicTests
    {
        [TestCase(new int[] {5,6,7,6,5}, Result = 2)]
        [TestCase(new int[] { 1,2,3 }, Result = null)]
        [TestCase(new int[] { 0 }, Result = null)]
        [TestCase(new int[] { -1, 2, -1 }, Result = 1)]
        public int? GetIndex_returnedValue(int[] arr)
        {
            return Task5.ArrayLogic.GetIndex(arr);
        }


        [TestCase(new int[] {}, typeof(ArgumentException))]
        [TestCase(null, typeof(NullReferenceException))]
        [TestCase(new int[] {3, int.MaxValue, 7, 10}, typeof(OverflowException))]
        public void GetIndex_returnedException(int[] arr, Type exception)
        {
            Assert.Throws(exception, () => Task5.ArrayLogic.GetIndex(arr));
        }
    }
}
