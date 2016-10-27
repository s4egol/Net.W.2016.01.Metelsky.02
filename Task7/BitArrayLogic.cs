using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class BitArrayLogic
    {
        /// <summary>
        /// Insert the second number of the first on the set bits
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <param name="i">Starting position of the bit to insert</param>
        /// <param name="j">Final position of the bit to insert</param>
        /// <returns>The resulting number</returns>
        public static int Insertion(int number1, int number2, int j, int i)
        {
            if ((i < 0) || (j < 0) || (j > i) || (i > 31) || (j > 31))
                throw new ArgumentOutOfRangeException();

            BitArray bitArray1 = new BitArray(new int[] { number1 });
            BitArray bitArray2 = new BitArray(new int[] { number2 });

            int index = 0;
            for (int k = j; k <= i; k++)
            {
                bitArray1[k] = bitArray2[index];
                index++;
            }

            int[] returnValue = new int[1];
            bitArray1.CopyTo(returnValue, 0);
            return returnValue[0];
        }

    }
}
