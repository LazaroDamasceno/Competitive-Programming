using System;
using System.Linq;
using System.Collections.Generic;

namespace CC
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Trapezoids(A, B, H));

        }

        static int Trapezoids(int A, int B, int H) 
        {
            return ((A + B) * H) / 2;
        }
    }

}
