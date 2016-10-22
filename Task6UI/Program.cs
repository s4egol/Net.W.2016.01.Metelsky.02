using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6;

namespace Task6UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            StringBuilder string1 = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Enter a second string:");
            StringBuilder string2 = new StringBuilder(Console.ReadLine());

            StringBuilder returnedString = StringLogic.GetNotRepeatingSequence(string1, string2);
            Console.WriteLine("Result:");
            Console.WriteLine(returnedString);
            Console.ReadKey();
        }
    }
}
