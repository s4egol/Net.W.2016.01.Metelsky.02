using System;
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
        public static int Insertion(int number1, int number2, int i, int j)
        {
            if ((i > j) || (i > 31) || (j>31))
                throw  new ArgumentException();

            byte[] bits1 = new byte[32];
            byte[] bits2 = new byte[32];

            bits1 = GetBits(number1);
            bits2 = GetBits(number2);

            int index = bits2.Length - 1;
            for (int k = (bits1.Length - 1 - i); k >= (bits1.Length - 1 - j); k--)
            {
                bits1[k] = bits2[index];
                index--;
            }

            return GetNumber(bits1);
        }

        private static byte[] GetBits(int number)
        {
            byte[] bits = new byte[32];
            bool flagNegative = false;

            if (number < 0)
                flagNegative = true;

            number = Math.Abs(number);
            for (int i = (bits.Length - 1); i >= 0; i--)
            {
                if (Math.Pow(2, i) <= number)
                {
                    bits[i] = 1;
                    number -= (int)Math.Pow(2, i);
                }
            }

            if (flagNegative == true)
            {
                InvertArray(bits);

                //add '1' to the inverted array
                for (int i = 0; i < bits.Length; i++)
                {
                    if (bits[i] == 0)
                    {
                        bits[i] = 1;
                        break;
                    }
                    else
                        bits[i] = 0;
                }
            }

            Array.Reverse(bits);
            return bits;
        }

        private static void InvertArray(byte[] bits)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                    bits[i] = 0;
                else
                    bits[i] = 1;
            }
        }

        private static int GetNumber(byte[] bits)
        {
            Array.Reverse(bits);

            int number = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    number += (int)Math.Pow(2, i);
                }
            }
            return number;
        }

    }
}
