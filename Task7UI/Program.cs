using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Task7;

namespace Task7UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your starting location [i,]:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the final location [,j]:");
            int j = int.Parse(Console.ReadLine());

            int result = BitArrayLogic.Insertion(firstNumber, secondNumber, i, j);
            Console.WriteLine("Result:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
