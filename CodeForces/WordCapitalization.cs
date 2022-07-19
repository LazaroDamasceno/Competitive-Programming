using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    class InCSharp
    {
        static void Main(string[] args)
        {
            List<char> characters = new List<char>();
            string input = Console.ReadLine();
            foreach (char el in input) { 
                characters.Add(el); 
            }
            characters[0] = char.ToUpper(characters[0]);
            foreach (char el in characters)
            {
                Console.Write(el);
            }
            Console.WriteLine();
        }
    }
}
