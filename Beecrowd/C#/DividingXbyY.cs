using System;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            while (testcases != 0)
            {
                string[] line = Console.ReadLine().Split();
                int X = int.Parse(line[0]);
                int Y = int.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");   
                }
                else
                {
                    Console.WriteLine($"{(X*1.0)/Y:0.0}");
                }
                testcases--;
            }
        }
    }
}
