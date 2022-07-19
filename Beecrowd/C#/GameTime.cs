using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int initialTime = int.Parse(line[0]);
            int finalTime = int.Parse(line[1]);
            int difference = finalTime - initialTime;
            Console.WriteLine(difference > 0 ? 
                $"O JOGO DUROU {difference} HORA(S)" : 
                $"O JOGO DUROU {difference += 24} HORA(S)");
            
        }
    }
}
