using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos.classes
{
    internal class Bhaskara
    {
        public (double a, double b, double c) getValues()
        {
            Console.WriteLine("\n| Bhaskara Calculator");
            Console.Write("| Enter the value of a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("| Enter the value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("| Enter the value of c: ");
            double c = double.Parse(Console.ReadLine());

            return (a, b, c);
        }
        public double getDelta(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            return delta;
        }
        public string getResult(double a, double b,double c, double delta)
        {
            string bask;
            if (delta < 0)
            {
                bask = "| Delta equal 0, root do not exist!";
            } else if(delta == 0)
            {
                double x = -b / (2 * a);
                bask = $"| Delta equal 0, there is only one root: x = {x}";
            }
            else
            {
                double xl = (-b + Math.Sqrt(delta)) / (2 * a);
                double xll = (-b - Math.Sqrt(delta)) / (2 * a);

                bask = $"| The roots are: x1 = {xl} and x2 = {xll}";
            }

            return bask;
        }
        public void BhaskaraCalculator()
        {
            Console.Clear();

            (double a, double b, double c) = getValues();
            double delta = getDelta(a, b, c);


            Console.WriteLine(getResult(a, b, c, delta));


            Console.WriteLine("\n\n Press Enter to Continue...");
            Console.ReadKey();

        }
    }
}
