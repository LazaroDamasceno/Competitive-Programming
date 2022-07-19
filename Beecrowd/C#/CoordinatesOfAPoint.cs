using System;
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            double x = double.Parse(line[0]);
            double y = double.Parse(line[1]);
            if (x == 0 && y == 0) Console.WriteLine("Origem");
            else if (x != 0 && y == 0) Console.WriteLine("Eixo X");
            else if (x == 0 && y != 0) Console.WriteLine("Eixo Y");
            else if (x > 0 && y > 0) Console.WriteLine("Q1");
            else if (x > 0 && y < 0) Console.WriteLine("Q4");
            else if (x < 0 && y < 0) Console.WriteLine("Q3");
            else if (x < 0 && y > 0) Console.WriteLine("Q2");
        }
    }
}
