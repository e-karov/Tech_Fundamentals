using System;
using System.Linq;
using System.Text;

namespace Messesging            // 100 / 100
{
    class Program
    {
        static void Main()
        {
            string[] numStrings = Console.ReadLine().Split().ToArray();
            string text = Console.ReadLine();

            StringBuilder message = new StringBuilder();

            foreach (var element in numStrings)
            {
                int index = 0;

                for (int i = 0; i < element.Length; i++)
                {
                    index += int.Parse(element[i].ToString());
                }

                if (index >= text.Length)
                {
                    index %= text.Length;
                }

                message.Append(text[index]);
                text = text.Remove(index, 1);
            }

            Console.WriteLine(message.ToString());
        }
    }
}
