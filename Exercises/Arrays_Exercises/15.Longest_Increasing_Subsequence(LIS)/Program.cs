using System;
using System.Linq;

namespace _15.Longest_Increasing_Subsequence_LIS_
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestLen = 1;
            int[] lis = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;

                for (int k = i; k >= 0; k--)
                {
                    int[] currentLis = new int[k+1];
                    currentLis[k] = arr[k];

                    if (arr[i] > arr[k])
                    {
                        counter++;
                        currentLis[k] = arr[k];

                        if (counter > bestLen )
                        {
                            bestLen = counter;
                            lis = currentLis;
                        }
                    }
                }

            }
            Console.WriteLine(String.Join(' ', lis));
        }
    }
}
