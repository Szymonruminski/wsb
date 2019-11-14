using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 10;


            Console.WriteLine("Wartości funkcji przed wywołaniem funkcji: {0} i {1}", tab[0], tab[1]);
            tab1(tab);
            Console.WriteLine("Wartości funkcji po wywołaniem funkcji: {0} i {1}", tab[0], tab[1]);
            ShowTab(tab);
            Console.ReadKey();
        }

        static void tab1(int[] tab)
        {
     
            tab[0] = 50;
            tab[1] = 100;

            Console.WriteLine("Wartości funkcji wewnątrz funkcji: {0} i {1}", tab[0], tab[1]);
        }
     
static void ShowTab(int[] tab)
        {
            Console.Write("Wartości w tablicy: ");
            foreach (int item in tab)
            {

                Console.Write("{0} ", item); ;

            }

        }  
    
    }



}
