using System;

namespace TABLICE
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int n = 10, i;
                        // deklaracja tablicy o nazwie tab typu całkowitego o rmziarze n = 10

                        int[] tab = new int[n];

                        for(i=0;i<tab.Length;i++)
                        {
                            tab[i] = i;

                        }

                        //wyświetlenie zawartości
                        for (i = 0; i < tab.Length; i++)
                        {
                            Console.Write("{0}", tab[i]);

                        }

                        //Napisz program, który w 5-elementowej tablicy jednowymiarowej o nazwie colors umieszcza
                        //nazwy kolorów podane z klawiatury przez użytkownika(for) wyświetli kolory w formacie(while):
                        //kolor1:red , kolor2:blue ... kolor5:yellow
                        */


            string[] colors = new string[5];

            for (x = 0; x < colors.Length; x++)
            {

                colors[x] = x;

            } 

            while(x<colors.Length)
            {

                Console.Write("{0}", colors[] );
            }
            Console.ReadKey();
        }
    }
}
