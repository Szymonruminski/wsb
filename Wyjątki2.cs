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


            uint number;
            while(true)
            {

                Console.WriteLine("Wprowadź liczbę całkowitą: ");
                    string x = Console.ReadLine();
                try
                {

                    number = uint.Parse(x);
                    break;

                }

                catch(FormatException)
                {

                    Console.WriteLine("Wprowadź liczbę w poprawnym formacie  np.4\n");
                
                }
                catch(OverflowException)
                {

                    Console.WriteLine("Wprowadzona liczba jet poza dopuszczalnym zakresem");
                    Console.WriteLine("Zakres liczb: <0; 4 294 697 295>\n");

                }
                catch(ArgumentNullException)
                {

                    Console.WriteLine("Wartość nie może być pusta");
                }

                Console.WriteLine("Wprowadź poprawnie wartość");


                      
                    }
            Console.ReadKey();
        }
    }
}
