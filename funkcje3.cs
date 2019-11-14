using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            increment(out a);
            Console.WriteLine("Wartość zmiennej a po wywołaniem funkcji: {0}", a);


            Console.ReadKey();
        }
    static void increment(out int x)
        {
            x = 1;
            x += 10;
            Console.WriteLine("Zmienna x wewnątrz funkcji: {0}", x);


        }
    
    }
}
