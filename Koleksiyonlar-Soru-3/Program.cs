using System;
using System.Collections.Generic;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<char> vowels = new List<char>();
            HashSet<char> vowelSet = new HashSet<char>{
                'a', 'A',
                'e', 'E',
                'i', 'I',
                'o', 'O',
                'u', 'U',
                'y', 'Y'
            };

            Console.WriteLine("Please type a sentence in English and press Enter:");
            input = Console.ReadLine();

            foreach (char symbol in input)
            {
                if (vowelSet.Contains(symbol))
                {
                    vowels.Add(symbol);
                }
            }
            vowels.Sort();
            Console.Write("\nSorted vowel array: ");
            vowels.ForEach(vowel => Console.Write($"{vowel} "));
        }
    }
}
