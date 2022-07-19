using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int participants, pens, notebooks;
            participants = int.Parse(input[0]);
            pens = int.Parse(input[1]);
            notebooks = int.Parse(input[2]);
            Console.WriteLine(pens >= participants && notebooks >= participants ? "Yes" : "No");
        }
    }
}
