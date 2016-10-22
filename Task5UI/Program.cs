using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5;

namespace Task5UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array of integers, and then click <Enter>:");
            string stringArray = Console.ReadLine();
            string[] valuesArray = stringArray.Split(new char[] { ' ' });

            int[] array = new int[1000];
            int index = 0;
            foreach(string value in valuesArray)
            {
                if (value != String.Empty)
                {
                    array[index] = int.Parse(value);
                    index++;
                }
            }

            int returnedIndex = ArrayLogic.GetIndex(array);
            Console.WriteLine(returnedIndex);
            Console.ReadKey();
        }
    }
}
