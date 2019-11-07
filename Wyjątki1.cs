using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            while (true)

            {

                Console.Write("WProwadź liczbę całkowitą: ");
                string x = Console.ReadLine();

                try  //blok instrukcji 

                {
                     number = uint.Parse(x); //jeśli wyjąek --> catch
                    break;
                }




                catch (SystemException e)  //sprawdzanie wyjątku
                {
                    //Console.WriteLine("Error");
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Podałeś błędne dane: {0}\n", x);
                    Console.ResetColor();

                }




            }

            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prawidlowe dane: {0}", number);
                Console.ReadKey();
            Console.ResetColor();








            Console.ReadKey();
            
        }

            
       

        
        
    }
}
