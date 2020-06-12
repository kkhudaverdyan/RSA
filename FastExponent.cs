using System;
using System.Linq;

namespace FastExponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fast Exponent Algorith");
            Console.Write("Enter base:");
            var baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter power:");
            var power = int.Parse(Console.ReadLine());
            Console.Write("Enter n:");
            var n = int.Parse(Console.ReadLine());

            var powerBinary = Convert.ToString(power, 2);
            var result = new string[powerBinary.Length];
            result[0] = Convert.ToString(baseNum);

            for (int i = 0; i < powerBinary.Length - 1; i++)
            {
                if (powerBinary[i + 1] == '0')
                {
                    var a = Math.Pow(int.Parse(result[i]), 2) % n;
                    result[i + 1] = Convert.ToString(a);
                }
                else
                { 
                    result[i + 1] = Convert.ToString(Math.Pow(int.Parse(result[i]), 2) * baseNum % n);
                }
            }
            Console.WriteLine("Result: " + result.Last());
        }
    }
}
//#Khudaverdyan, correct
