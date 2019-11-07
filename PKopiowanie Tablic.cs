using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 10;
            int b = a;

            a--;
            b++;

            Console.WriteLine("Zmienna a: {0}", a); //9
            Console.WriteLine("Zmienna a: {0}", b); //11

            //typ referencyjny
            int[] tabA = { 2, 2, 2 };
            int[] tabB = tabA;
           
            
            tabA[2] = 10;
            tabB[0] = 8;

           Console.WriteLine("Wyświetlenie tablicy A:");
            Console.WriteLine();
            foreach (int item in tabA)
            {

                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("Wyświetlenie tablicy B:");
            Console.WriteLine();
            foreach (int item in tabB)
            {

                Console.Write(" {0} ", item);
            }

            Console.WriteLine();
            //kopiowanie tablic
            Console.WriteLine("tablica pusta");
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[5];

            foreach(int item in tabCopy)
            {
                Console.Write("{0} ", item);

            }
            Console.WriteLine();

            Console.WriteLine("1 sposób");

            tab.CopyTo(tabCopy, 0);
            // tab.CopyTo(tabCopy, 0);
            
            foreach (int item in tabCopy)
            
            {
                Console.Write("{0} ", item);

            }

            //2 sposób kopiowania tablicy
            Console.WriteLine();
            Console.WriteLine("2 sposób");

            Array.Copy(tab, tabCopy, tab.Length);
            foreach (int item in tabCopy)

            {
                Console.Write("{0} ", item);

            }
            Console.ReadKey();




        }
    }
}
