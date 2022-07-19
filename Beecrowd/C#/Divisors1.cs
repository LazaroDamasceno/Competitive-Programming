using System;
using System.Collections;
using System.Linq;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var divisors = Enumerable.Range(1, input).Where(i => input % i == 0 ).ToArray();
            foreach (var el in divisors)
                Console.WriteLine(el);
        }
    }
}
