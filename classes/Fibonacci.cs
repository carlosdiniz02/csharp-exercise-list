using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos.classes
{
    internal class Fibonacci
    {
        public void FibonacciSequence()
        {
            Console.Clear();
            Console.WriteLine("\n| Fibonacci Sequence");
            Console.Write("| Enter a number: ");
            int numInt = int.Parse(Console.ReadLine());

            double a = 0, b = 1, c = 0;

            Console.Write($"Sequence: neutro {a} | {b} ");
            Fib(a, b, c, numInt);
            Console.WriteLine("\n\n Press Enter to Continue...");
            Console.ReadKey();
        }

        public string Fib(double a, double b, double c, int numInt)
        {

            if (numInt < 2)
            {
                return "";
            }
            else
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
                return Fib(a, b, c, numInt - 1);
            }
        }
    }
}
