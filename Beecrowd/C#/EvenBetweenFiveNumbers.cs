using System;
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            foreach (var el in numbers)
            {
                if (el % 2 == 0)
                {
                    answer++;
                }
            }
            Console.WriteLine($"{answer} valores pares");
        }
    }
}
