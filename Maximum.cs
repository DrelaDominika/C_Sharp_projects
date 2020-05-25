using System;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Podaj pierwsza wartosc:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga wartosc:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia wartosc:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj czwarta wartosc:");
            d = int.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d))
            {

                Console.WriteLine("Maximum to " + a);
            }
            else if ((b >= a) && (b >= c) && (b >= d))
            {
                Console.WriteLine("Maximum to " + b);

            }
            else if ((c >= a) && (c >= b) && (c >= d))
            {
                Console.WriteLine("Maximum to " + c);

            }
            else if ((d >= a) && (d >= c) && (d >= b))
            {
                Console.WriteLine("Maximum to " + d);

            }

            
            Console.ReadKey();


        }
    }
}
