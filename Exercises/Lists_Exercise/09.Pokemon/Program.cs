using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon
{
    class Program
    {
        static void Main()
        {
            List<long> input = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            long sum = 0;
            int index = 0;

            while (input.Count != 0)
            {
                index = int.Parse(Console.ReadLine());
                
                if (index < 0)
                {
                    index = 0;
                    ChangElementsValue(input, index);
                    sum += input[index];
                    input[0] = input[input.Count - 1];
                }

                if (index > input.Count - 1)
                {
                    index = input.Count - 1;
                    ChangElementsValue(input, index);
                    sum += input[index];
                    input[input.Count - 1] = input[0];
                }

                else
                {
                    ChangElementsValue(input, index);
                    sum += input[index];
                    input.RemoveAt(index);
                }
            }

            Console.WriteLine(sum);
        }

        static List<long> ChangElementsValue(List<long> input, int index)
        {
            long currentValue = input[index];
            for (int j = 0; j < input.Count; j++)
            {
                if (j != index)
                {
                    if (input[j] <= currentValue)
                    {
                        input[j] += currentValue;
                    }
                    else if (input[j] > currentValue)
                    {
                        input[j] -= currentValue;
                    }
                }
            }

            return input;
        }
    }
}
