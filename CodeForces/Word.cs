using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    class InCSharp
    {
        static string Solution(string input)
        {
            int lowercase = 0;
            int uppercase = 0;
            foreach (char el in input)
            {
                if (el == char.ToUpper(el)) { uppercase++; } 
                else if (el == char.ToLower(el)) { lowercase++; }
            }
            if (uppercase > lowercase) { return input.ToUpper(); }
            else if (uppercase < lowercase) { return input.ToLower(); }
            else { return input.ToLower(); }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(Solution(input));
        }
    }
}
