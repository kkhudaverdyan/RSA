using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FermatTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fermat's Little Theorem");
            do
            {
                Console.Write("Please enter a number:  ");
                try
                {
                    bool isPrime = true;
                    int.TryParse(Console.ReadLine(), out int p);
                    for (int a = 1; a < p; a++)
                    {
                        if (Gcd(a, p) == 1)
                        {
                            if (!FermatCondition(a, p))
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"The {p} is prime");
                    }
                    else
                    {
                        Console.WriteLine($"The {p} is not prime");
                    }
                    Console.WriteLine("Press Enter to try again");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Something went worng");
                    Console.ReadLine();
                    break;
                }
            }
            while(Console.ReadKey().Key == ConsoleKey.Enter);
           
            Console.ReadLine();
        }
        public static int Gcd(int a, int p)
        {
            int remainder;

            while (p != 0)
            {
                remainder = a % p;
                a = p;
                p = remainder;
            }
            return a;
        }
        public static bool FermatCondition(int a, int p)
        {
            return Math.Pow(a, p - 1) % p == 1;
        }
    }
}
