using System;

namespace A_Wrong_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(input[0]);
            int operations = int.Parse(input[1]);
            while (operations != 0)
            {
                if (number % 10 != 0)
                {
                    number--;
                }
                else
                {
                    number /= 10;
                }
                operations--;
            }
            Console.WriteLine(number);
        }
    }
}
