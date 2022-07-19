using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split();
            int quantity = int.Parse(Console.ReadLine());
            List<string> words = new List<string>();
            List<string> selectedWords = new List<string>();
            for (int i = 0; i < quantity; i++) 
                words.Add(Console.ReadLine());
            for (int i = 0; i < quantity; i++)
                if (i % 2 == 0)
                    selectedWords.Add(words[i]);
            foreach (var item in selectedWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
