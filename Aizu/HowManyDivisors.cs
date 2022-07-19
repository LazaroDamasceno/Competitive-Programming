using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int a = int.Parse(token[0]);
            int b = int.Parse(token[1]);
            int c = int.Parse(token[2]);
            int counter = 0;
            for (int num = a; num <= b; num++)
            {
                if (c % num == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
