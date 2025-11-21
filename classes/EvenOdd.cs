using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos.classes
{
    internal class EvenOdd
    {
        public int getValue()
        { 
            Console.WriteLine("\n| Even or Odd");
            Console.Write("| Enter a number: ");
            int numInt = int.Parse(Console.ReadLine());
            return numInt;
        }

        public string verify(int value)
        {
            string result;
            if (value % 2 == 0) result = $"| The number {value} is Even.";
            else result = $"| The number {value} is Odd.";
            return result;
        }   
        public void EvenOddShow()
        {
            Console.Clear();
            int value = getValue();

            Console.WriteLine("\n\n Press Enter to Continue...");
            Console.ReadKey();
        }
    }
}
