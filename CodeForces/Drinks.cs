using System;
using System.Linq;

namespace B_Drinks
{
    class Program
    {
        static void Answer()
        {
            int cases = int.Parse(Console.ReadLine());
            int[] percetanges = new int[cases];
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < cases; i++)
            {
                percetanges[i] = int.Parse(input[i]);
            }
            Console.WriteLine(((percetanges.Sum() / 100.0) / cases) * 100.0);
        }

        static void Main(string[] args)
        {
            Answer();
        }
    }
}
