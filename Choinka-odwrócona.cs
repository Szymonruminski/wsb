using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            



            int wyskosc;
            Console.WriteLine("podaj zakres choinki :");
            wyskosc = int.Parse(Console.ReadLine());

            for (int i = wyskosc; i > 0; i--)
            {
               for (int j = i; j > 1; j--)
                {
                   Console.Write(" ");
                }

                for (int k = 0; k <= (wyskosc - i); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
        }
    }

