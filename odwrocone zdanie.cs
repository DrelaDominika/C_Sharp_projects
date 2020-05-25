using System;

namespace odwroceniezdania
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadz zdanie: ");
            string[] tablica = Console.ReadLine().Split(' ');
            int dlugosc = tablica.Length;
            {
                Console.WriteLine("Odwrocone zdanie: ");
            }
            for (int i = dlugosc - 1; i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
