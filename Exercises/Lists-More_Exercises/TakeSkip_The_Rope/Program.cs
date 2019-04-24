using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeSkip_The_Rope         // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> text =new List<char>();

            foreach (var token in input)
            {
                if (char.IsDigit(token))
                {
                    numbers.Add(int.Parse(token.ToString()));
                }
                else
                {
                    text.Add(token);
                }
            }

            List<char> result = new List<char>();
            int skipSum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    result.AddRange(text.Skip(skipSum).Take(numbers[i]));
                }

                else
                {
                    skipSum += numbers[i] + numbers[i-1];
                }
            }

            Console.WriteLine(String.Join("", result));
        }
    }
}
