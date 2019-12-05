using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
        

            string[] customers =
            {
            "Agnieszka Nowak",
            "Anna Nowak",
            "Tomas Kowalski",
            };


            string Path = @"C:\Users\Student\C#Files";
            try
            {
                if (Directory.Exists(Path))
                {
                    Console.WriteLine("Katolog istnieje");
                }

                else
                {
                    Directory.CreateDirectory("\\Users\\Student\\C#Files");
                    string textFilePath = @"C:\Users\Student\C#Files\testFile1.txt";

                    File.WriteAllLines(textFilePath, customers);
                    Console.WriteLine("\nUtworzono katalog: {0}", Directory.GetCreationTime(Path));
                }
            }
            catch (Exception e)
            { Console.WriteLine("Error: {0}", e.ToString()); }


            DirectoryInfo myDataDir = new DirectoryInfo(@Path);
            Console.WriteLine();

            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Ilość pilików tekstowych: {0}", txtFiles.Length);
            
            foreach(FileInfo file in txtFiles)
            {
                Console.WriteLine("Nazwa {0}", file.Name);
                Console.WriteLine("Rozmiar {0}", file.Length);


            }
            
            Console.ReadKey();
        }
    }
}
