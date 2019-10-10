using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj wyskosc trójkąta");
            string wyskosc = Console.ReadLine();
            Console.Write("podaj podstawę trójkąta");
            string podstawa = Console.ReadLine();
            double podstawa1, wyskosc1, pole;
            if (double.TryParse(podstawa, out podstawa1)
            && double.TryParse(wyskosc, out wyskosc1))
               

            {
                pole = 0.5 * podstawa1 * wyskosc1;

                Console.WriteLine("pole wynosi:" + pole);
            }
            else {
                
            Console.WriteLine("error Błędne dane!");
            }
        

        }
    }
}