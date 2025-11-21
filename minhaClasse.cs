using exemplos.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exemplos
{
    internal class minhaClasse
    {

        public void ShowMenu()
        {
            bool myOp = true;
            do
            {
                Console.Clear();
                Console.WriteLine("|  -> Menu de (ex) exemplos");
                Console.WriteLine("|-----------------------");
                Console.WriteLine("|  01 - (ex) Fibonacci");
                Console.WriteLine("|  02 - (ex) Bhaskara");
                Console.WriteLine("|  03 - (ex) Par/Impar");
                Console.WriteLine("|  04 - (ex) Bigger/Smaller");
                Console.WriteLine("|-----------------------");
                Console.WriteLine("|  00 - Sair");
                Console.WriteLine("|-----------------------");
                Console.Write("|  -> Escolha uma atividade: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        myOp = false;
                        break;
                    case 1:
                        Fibonacci myF = new Fibonacci();
                        myF.FibonacciSequence();
                        break;
                    case 2:
                        Bhaskara myB = new Bhaskara();
                        myB.BhaskaraCalculator();
                        break;
                    case 3:
                        EvenOdd myParImp = new EvenOdd();
                        myParImp.EvenOddShow();
                        break;
                    case 4:
                        BignSmal myBnS = new BignSmal();
                        myBnS.getValues();
                        break;
                    default:    
                        Console.WriteLine("\n| Enter a valid option! \n");
                        break;
                }
            } while (myOp);

            Timer();
        }

        public void Timer()
        {
            Console.Clear();
            for (int i = 3; i > 0; i--)
            {
                Console.Write($"\r| Exiting in {i} seconds...");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("\n| Byeee! ^-^)/");
            Environment.Exit(0);
        }
    }
}
