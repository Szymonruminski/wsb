﻿using System;


namespace ConsoleApp2
{
    class Program
    {
        unsafe static void Main(string[] args)
        {

            
            char* x;
            char letter = 'x';
            x = &letter;
            letter = 'a';

            Console.WriteLine("Znak: {0}", letter);
            Console.WriteLine("Znak: {0}", *x);
            Console.WriteLine("Adres w pamięci zmiennej letter: {0}", (int)x);
            Console.WriteLine("Adres w pamięci zmiennej letter hex: {0:x}", (int)x);

            int test = 123;
            Console.WriteLine(Convert.ToString(test,8));

            double number;
            double*  numberAddress;
            number = 10;
            numberAddress = &number;
           

            Console.WriteLine("Liczba wynosi: {0}", number);
            Console.WriteLine("Liczdba wynosi: {0}", numberAddress->ToString());
            Console.WriteLine("Adres zmiennej wynosi: {0}", (int)numberAddress);
         
            Console.ReadKey();
        
        }
    }
}
