using System;
using System.Collections.Generic;
using System.Linq;

namespace Drum_Set                      // 100 / 100
{
    class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumQuality = new List<int>();
            string line = "";

            for (int i = 0; i < drumSet.Count; i++)
            {
                drumQuality.Add(drumSet[i]);
            }

            while ((line = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(line);

                for (int i = 0; i < drumSet.Count; i++)
                {

                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                    
                        if ((savings - drumQuality[i] * 3) >= 0)
                        {
                            savings -= (drumQuality[i] * 3);
                            drumSet[i] = drumQuality[i];
                        }

                        else
                        {
                            drumSet.Remove(drumSet[i]);
                            drumQuality.Remove(drumQuality[i]);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(String.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
