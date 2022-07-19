using System;

namespace A_In_Search_of_an_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int ans = 0;
            for (int i = 0; i < cases; i++)
            {
                ans += (int.Parse(input[i]));
            }
            Console.WriteLine(ans > 0 ? "hard" : "easy");
        }
    }
}
