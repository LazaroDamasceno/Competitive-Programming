using System;
using System.Linq;
using System.Collections.Generic;

namespace CompetitiveProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split();
            int quantity = int.Parse(token[0]);
            int length = int.Parse(token[1]);
            Console.WriteLine(IrohaLovesStrings(quantity, length));
        }

        static string IrohaLovesStrings(int quantity, int length)
        {
            string[] words = new string[quantity];
            for (int i = 0; i < quantity; i++) { words[i] = Console.ReadLine(); }
            Array.Sort(words);
            string output = "";
            for (int i = 0; i < quantity; i++) { output += words[i]; }
            return output;
        }
    }
}
