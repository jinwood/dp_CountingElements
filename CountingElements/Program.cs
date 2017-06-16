using System;
using System.Collections.Generic;

namespace CountingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter element");
            var element = Console.ReadLine();

            var kvp = StringToKvp(element);

            foreach (var pair in kvp)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static Dictionary<string, string> StringToKvp(string element)
        {
            var arr = element.ToCharArray();
            var currentLetter = string.Empty;
            var currentNumber = string.Empty;

            var result = new Dictionary<string, string>();

            foreach (var ch in arr)
            {
                if (Char.IsLetter(ch) && ch.ToString() != currentLetter)
                {
                    currentLetter = string.Empty;
                    currentNumber = string.Empty;
                }
                if (Char.IsLetter(ch))
                {
                    currentLetter = ch.ToString();
                }
                else
                {
                    currentNumber = ch.ToString();
                }

                if (ch.ToString().Equals(currentNumber))
                {
                    if (currentNumber.Equals(string.Empty))
                    {
                        result.Add(currentLetter, string.Empty);
                    }
                    else
                    {
                        result.Add(currentLetter, currentNumber);
                    }
                }
            }

            return result;
        }
    }
}