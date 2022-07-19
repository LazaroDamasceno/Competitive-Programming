using System;

namespace A_Soldier_and_Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int cost_banana = int.Parse(input[0]);
            int number_dollars = int.Parse(input[1]);
            int wanted_bananas = int.Parse(input[2]);
            int sum = 0;
            for (int i = 1; i <= wanted_bananas; i++)
                sum += (cost_banana * i);
            Console.WriteLine((sum - number_dollars) <= 0 ? 0 : (sum - number_dollars));
        }
    }
}
