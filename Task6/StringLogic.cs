using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public static class StringLogic
    {
        /// <summary>
        /// Finding a non-repeating sequence of letters
        /// </summary>
        /// <param name="string1">First String</param>
        /// <param name="string2">Second String</param>
        /// <returns>String with all letters found</returns>
        public static String GetNotRepeatingSequence(String string1, String string2)
        {
            if ((string1 == null) || (string2 == null))
                throw new ArgumentException();

            if (string1 == String.Empty && string2 == String.Empty)
                throw new ArgumentException();

            string1 += string2;

            List<char> listOfLetters = new List<char>();
            for (int i = 0; i < string1.Length; i++)
            {
                listOfLetters.Add(string1[i]);
            }

            var result = listOfLetters.Distinct().OrderBy(t => t);

            return result.Aggregate(String.Empty, (current, val) => current + val);
        }
    }
}
