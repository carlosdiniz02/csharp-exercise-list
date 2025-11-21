using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos.classes
{
    internal class BignSmal
    {

        public int getBiggest(int[] n)
        {
            int Biggest = 0;
            bool fT = true;

            foreach (int x in n)
            {
                if (fT)
                {
                    Biggest = x;
                    fT = false;
                }
                else
                {
                    if (Biggest < x)
                    {
                        Biggest = x;
                    }
                }
            }

            return Biggest;
        }


        public int getSmallest(int[] n)
        {
            int Smallest = 0;
            bool fT = true;

            foreach (int x in n)
            {
                if (fT)
                {
                    Smallest = x;
                    fT = false;
                }
                else
                {
                    if (Smallest > x)
                    {
                        Smallest = x;
                    }
                }
            }

            return Smallest;
        }

        public void getValues()
        {
            Console.Clear();
            Console.Write("|  -> How many numbers? : ");
            int[] numbers = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("|  -> Enter the " + (i + 1) + "º number: ");
                numbers[i] = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine($"\n| The biggest number is: {getBiggest(numbers)}\n| The smallest number is: {getSmallest(numbers)}");

            Console.WriteLine("\n| Press ENTER to return to the menu...");
            Console.ReadKey();
        }
    }
}
