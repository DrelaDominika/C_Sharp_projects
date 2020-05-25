using System;

namespace totolotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] tab = new int[6];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = r.Next(1, 49);
                for (int j = 0; j < i; j++)
                    if (tab[i] == tab[j])
                        while (tab[i] == tab[j])
                            tab[i] = r.Next(1, 49);
            }
            Console.WriteLine("Wylosowane liczby to: ");
            {
                foreach (int i in tab)
                    Console.Write("{0}   ", i);
            }
            Console.ReadKey();
        }
    }
}
