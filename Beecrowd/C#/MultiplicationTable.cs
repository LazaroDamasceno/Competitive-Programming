using System;https://github.com/LazaroDamasceno/Competitive-Programming/tree/main/Beecrowd
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            while (c != 11)
            {
                Console.WriteLine($"{c} x {n} = {c * n}");
                c++;
            }
        }
    }
}
