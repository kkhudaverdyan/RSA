using System;

namespace FermatsFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            var n = int.Parse(Console.ReadLine());

            var s = Math.Ceiling(Math.Sqrt(n));
            int k = 0;
            double y;

            while (true)
            {
                y = Math.Pow((s + k), 2) - n;

                if (Math.Sqrt(y) % 1 == 0)
                {
                    Console.WriteLine(y);
                    break;
                }
                k++;
            }

            int p = Convert.ToInt32(s + k + Math.Sqrt(y));
            int q = Convert.ToInt32(s + k - Math.Sqrt(y));

            string pIsPrime = IsPrime(p) ? "" : "not";
            string qIsPrime = IsPrime(q) ? "" : "not";

            Console.WriteLine($"p: {p}, q: {q}");
            Console.WriteLine($"p is {pIsPrime} prime number");
            Console.WriteLine($"q is {qIsPrime} prime number");
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
