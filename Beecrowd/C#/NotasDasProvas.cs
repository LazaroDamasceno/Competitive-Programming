using System;
using System.Linq;
using System.Collections.Generic;

namespace Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(input == 0 ? "E" :
                input >= 1 && input <= 35 ? "D" :
                input >= 36 && input <= 60 ? "C" :
                input >= 61 && input <= 85 ? "B" : "A");
        }
    }
}
