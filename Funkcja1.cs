using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine(args[0]);

            Show();
            //  Show1();
            Add(2, 4);
            Add(4,8,1);
            Console.WriteLine("\nWywołanie funkcji 4-elementowej");
            Console.WriteLine(Add(1, 2, 3, 4));
            Console.WriteLine(Add(d:3,a:2));
            Console.ReadKey();
        }



        static void Show()
            
            {


            Console.WriteLine("WSB");
        }

        //static int Show1()

        //{


          //  return 0;
        //}
    
    
    static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Wynik dodawania: {0}", result);


        }
    

        static void Add(int a, int b, int c)

        {

            int result = a + b + c;
            Console.WriteLine("Wynik dodawania: {0}", result);



        }
        static int Add(int a, int d, int b = 5  , int c = 5)
        {
            return a + b + c + d;

        }
    
    

    }






}
