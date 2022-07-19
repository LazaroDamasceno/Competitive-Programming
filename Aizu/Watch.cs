using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] token;
            // token = Console.ReadLine().Split(' ');
            int input = int.Parse(Console.ReadLine());
            int hours = input / 3600;
            int minutes = (input % 3600) / 60;
            int seconds = (input % 3600) % 60;
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
