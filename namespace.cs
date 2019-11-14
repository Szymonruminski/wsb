using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_name;
using Outer.Middle.Inner;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();

            First_name.name_1 ob1 = new First_name.name_1();
            ob1.Show();

            name_1 ob2 = new name_1();
            ob2.Show();
            Console.ReadKey();
        
        
         Prog ob = new Prog();
            ob.Add(2, 3);
            Console.WriteLine(ob.Add(2,5));
        }



    }
}

namespace First_name
{

    class name_1
    {

        public void Show()
        {

            Console.WriteLine("Pierwza przestań nazw");

        }

    }

}

namespace Second_name
{

    class name_1
    {

        public void Show()
        {

            Console.WriteLine("Druga przestań nazw");

        }

    }
}



namespace Outer
{

  
    namespace Middle
    {

        namespace Inner
        {

            class Prog
            {
                public int x, y;

                public int Add(int x, int y)
                {
                    return x + y;
                }
            }

        }


    }
    

}
