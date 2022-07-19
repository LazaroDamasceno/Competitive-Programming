using System;
using System.Linq;
using System.Collections.Generic;

namespace _1535A
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cases; i++)
            {
                string[] inputs = Console.ReadLine().Split();
                List<int> marks = new List<int>();
                marks.Insert(0, int.Parse(inputs[0]));
                marks.Insert(1, int.Parse(inputs[1]));
                marks.Insert(2, int.Parse(inputs[2]));
                marks.Insert(3, int.Parse(inputs[3]));
                int groupOne = Math.Max(marks[0], marks[1]);
                int groupTwo = Math.Max(marks[2], marks[3]);
                int biggestOne = marks.Max();
                marks.RemoveAt(marks.IndexOf(marks.Max()));
                int biggestTwo = marks.Max();
                marks.RemoveAt(marks.IndexOf(marks.Max()));
                if ((groupOne == biggestOne || groupOne == biggestTwo) 
                    && (groupTwo == biggestOne || groupTwo == biggestTwo))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
