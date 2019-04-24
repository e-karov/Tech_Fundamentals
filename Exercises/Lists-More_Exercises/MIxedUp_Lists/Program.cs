using System;
using System.Collections.Generic;
using System.Linq;

namespace MIxedUp_Lists                 // 100 / 100
{
    class Program
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int rangeStart = 0;
            int rangeEnd = 0;

            if (list1.Count > list2.Count)
            {
                rangeStart = Math.Min(list1[list1.Count - 1], list1[list1.Count - 2]);
                rangeEnd = Math.Max(list1[list1.Count - 1], list1[list1.Count - 2]);
            }

            if (list1.Count < list2.Count)
            {
                rangeStart = Math.Min(list2[0], list2[1]);
                rangeEnd = Math.Max(list2[0], list2[1]);
            }

            List<int> result = new List<int>();
            list1.AddRange(list2);

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] > rangeStart && list1[i] < rangeEnd)
                {
                    result.Add(list1[i]);
                }
            }

            result = result.OrderBy(x => x).ToList();

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
