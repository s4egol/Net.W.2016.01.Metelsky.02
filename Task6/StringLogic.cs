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
        /// <param name="str1">First String</param>
        /// <param name="str2">Second String</param>
        /// <returns>String with all letters found</returns>
        public static StringBuilder GetNotRepeatingSequence(StringBuilder str1, StringBuilder str2)
        {
            StringBuilder returnString = new StringBuilder();
            str1.Append(str2);

            List<char> listOfLetters = new List<char>();
            for (int i = 0; i < str1.Length; i++)
            {
                listOfLetters.Add(str1[i]);
            }

            var result = listOfLetters.Distinct().OrderBy(t => t);

            foreach (var val in result)
                returnString.Append(val);

            return returnString;
        }
    }
}
