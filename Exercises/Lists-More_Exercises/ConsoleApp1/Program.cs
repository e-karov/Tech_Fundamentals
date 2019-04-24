using System;
using System.Linq;

namespace ConsoleApp1           // 100 / 100
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double leftCarTime = 0;
            double rightCarTime = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                leftCarTime += nums[i];

                if (nums[i] == 0)
                {
                    leftCarTime *= 0.8;
                }

                rightCarTime += nums[nums.Length - 1 - i];

                if (nums[nums.Length-1-i] == 0)
                {
                    rightCarTime *= 0.8;
                }

            }

            string output = (leftCarTime < rightCarTime) 
                ? $"The winner is left with total time: {leftCarTime}"
                : $"The winner is right with total time: {rightCarTime}";

            Console.WriteLine(output);
        }
    }
}
