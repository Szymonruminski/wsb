using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        unsafe static void Swap(int* a, int* b)
        
        {

            int pom = *a;
            *a = *b;
            *b = pom;
        
        }
        unsafe static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            Console.WriteLine("Wartości przed zamianą x= {0}, y={1}", x, y);
            Swap(&x, &y);
            Console.WriteLine("Wartości po zmianie x= {0}, y={1}", x, y);

            int a = 100;
            int b = 200;
            
            int* a1 = &a;
            int* b1 = &b;


            Console.WriteLine("\nWartości przed zamianą a = {0}, b={1}", a,  b);
                Swap(a1, b1);
            Console.WriteLine("\nWartości po zmianie a= {0}, b={1}", a, b);
            Console.ReadKey();
        }
    }
}
