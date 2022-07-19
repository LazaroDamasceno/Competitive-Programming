using System;
using System.Collections.Generic;

namespace _443A
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> hset = new HashSet<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '{'
                    && input[i] != ','
                    && input[i] != ' '
                    && input[i] != '}')
                {
                    hset.Add(input[i]);
                }
            }
            Console.WriteLine(hset.Count);
        }
    }
}
