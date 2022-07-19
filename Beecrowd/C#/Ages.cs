using System;
using System.Collections.Generic;
using System.Linq;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ages = new List<int>();
            int input = int.Parse(Console.ReadLine());
            ages.Add(input);
            while (input >= 1)
            {
                input = int.Parse(Console.ReadLine());
                if (input >=1 )ages.Add(input);
            }
            Console.WriteLine($"{ages.Average():.00}");
        }
    }
}
