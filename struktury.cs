using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public struct Punkt
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt();

            punkt1.x = 5;
            punkt1.y = 15;

            Punkt punkt2;
            //Punkt punkt2 = new Punkt();

            punkt2.x = 1;
            punkt2.y = 2;

            Console.WriteLine("Punkt 1: x = {0}, y= {1}",punkt1.x, punkt1.y);
            
            Console.WriteLine("Punkt 2: x = {0}, y= {1}",punkt2.x, punkt2.y);

            Console.ReadKey();
        }
    }
}
