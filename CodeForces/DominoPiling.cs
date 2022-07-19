using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    class InCSharp
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int inputOne = int.Parse(line[0]);
            int inputTwo = int.Parse(line[1]);
            Console.WriteLine((inputOne * inputTwo) / 2);
        }
    }
}
