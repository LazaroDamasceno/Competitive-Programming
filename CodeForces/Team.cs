using System;
using System.Linq;
using System.Collections.Generic;

namespace InCSharp
{
    class InCSharp
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> numbers = new List<int>();
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                string[] inputs = Console.ReadLine().Split();
                numbers.Add(int.Parse(inputs[0]));
                numbers.Add(int.Parse(inputs[1]));
                numbers.Add(int.Parse(inputs[2]));
                if (numbers.Sum() >= 2)
                {
                    count++;
                }
                numbers.Clear();
                testcases--;
            }
            Console.WriteLine(count);
        }
    }
}
