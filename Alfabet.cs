using System;

namespace ll
{
    class Program
    {
        static void Main(string[] args)
        {



            for (char znak = 'A'; znak <= 'Z'; znak++)
            {
                if (znak != 'Z')

                    Console.Write("{0},", znak);
                else
                    Console.Write("{0}.", znak);
            }

            Console.WriteLine();

            for(char znak2 = 'Z'; znak2 >= 'A'; znak2--)
            {
                if (znak2 != 'Z')

                    Console.Write("{0},", znak2);
                else
                    Console.Write("{0}.", znak2);
            }

        }
    }
}
