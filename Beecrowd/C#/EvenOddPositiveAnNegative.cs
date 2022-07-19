using System;
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            numbers.Add(int.Parse((Console.ReadLine())));
            numbers.Add(int.Parse((Console.ReadLine())));
            numbers.Add(int.Parse((Console.ReadLine())));
            numbers.Add(int.Parse((Console.ReadLine())));
            numbers.Add(int.Parse((Console.ReadLine())));
            
            int even = 0;
            int odd = 0;
            int positive = 0;
            int negative = 0;
            
            foreach (var el in numbers)
            {
                if (el % 2 == 0) even++;
                if (el % 2 != 0) odd++;
                if (el >= 1) positive++;
                if (el <= -1) negative++;
            }

            Console.WriteLine($"{even} valor(es) par(es)");
            Console.WriteLine($"{odd} valor(es) impar(es)");
            Console.WriteLine($"{positive} valor(es) positivo(s)");
            Console.WriteLine($"{negative} valor(es) negativo(s)");
        }
    }
}
