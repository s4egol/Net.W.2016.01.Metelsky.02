using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Class to work with integer array
    /// </summary>
    public static class ArrayLogic
    {
        /// <summary>
        /// Find in array element index, for which the sum of the elements on the left of it is the sum of the right elements.
        /// </summary>
        /// <param name="array">Array of integer values by which to search for the index</param>
        /// <returns>Found element index value or null if the element isn't found</returns>
        /// <exception cref="NullReferenceException">If the method argument is null.</exception>
        /// <exception cref="ArgumentException">If Length of the array 0</exception>
        /// <exception cref="OverflowException">In finding the sum of the elements</exception>
        public static int? GetIndex(int[] array)
        {
            if (array == null)
                throw new NullReferenceException();

            if (array.Length == 0)
                throw new ArgumentException();

            if (array.Length <= 2)
                return null;
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int sumOfTheLeft = 0;
                    int sumOfTheRight = 0;

                    for (int j = 0; j < i; j++)
                    {
                        sumOfTheLeft = checked(sumOfTheLeft + array[j]);
                    }

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sumOfTheRight = checked(sumOfTheRight + array[j]);
                    }

                    if (sumOfTheLeft == sumOfTheRight)
                        return i;
                }
            }

            return null;
        }
    }
}
