using System;
using System.Numerics;

namespace _09.Factorial_Division                // 100 / 100
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            decimal result = FactorialDivision(a, b);
            Console.WriteLine($"{result:F2}");
        }

        static decimal GetFactorial(int number)
        {
            decimal factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static decimal FactorialDivision(int a, int b)
        {
            decimal result = GetFactorial(a) / GetFactorial(b);

            return result;
        }
    }
}
