using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    class InCSharp
    {
        static void Main(string[] args)
        {
            string answer = "";
            List<char> characters = new List<char>();
            string input = Console.ReadLine();
            foreach (char element in input) 
            {
                if (element != '+')
                {
                    characters.Add(element);
                }
            }
            characters.Sort();
            answer += characters.ElementAt(0);
            for (int index = 1; index < characters.Count; index++)
            {
                answer += '+';
                answer += characters.ElementAt(index);
            }
            Console.WriteLine(answer);
        }
    }
}
