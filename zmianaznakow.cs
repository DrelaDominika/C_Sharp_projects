using System;

namespace zmianaznakow
{
    class Program
    {
        static void Main(string[] args)
        {
            char pierwsza;
            char ostatnia;
            int liczba;
            int j = 0;

            Console.Write("Wpisz slowo: ");
            string[] tablica = Console.ReadLine().Split(' ');
            for (int i = 0; i < tablica.Length; i++)
            {
                j = 0;
                liczba = tablica[i].Length;
                pierwsza = tablica[i][0];
                ostatnia = tablica[i][liczba - 1];

                Console.Write(ostatnia);
                for (j = 1; j < tablica[i].Length - 1; j++)
                {
                    Console.Write(tablica[i][j]);
                }


                Console.WriteLine(pierwsza);
                Console.WriteLine();


            }
            Console.ReadLine();
        }
    }
}
