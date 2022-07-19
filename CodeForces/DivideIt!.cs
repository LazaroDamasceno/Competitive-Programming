using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeForcesInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int testcases = int.Parse(Console.ReadLine());
            while (testcases > 0)
            {
                long input = long.Parse(Console.ReadLine());
                while (input != 1)
                {
                    if (input % 2 == 0)
                    {
                        input /= 2;
                        counter++;
                    } 
                    else if (input % 3 == 0)
                    {
                        input *= 2;
                        input /= 3;
                        counter++;
                    } 
                    else if (input % 5 == 0)
                    {
                        input *= 4;
                        input /= 5;
                        counter++;
                    }
                    else
                    {
                        counter = -1;
                        break;
                    }
                }
                Console.WriteLine(counter);
                counter = 0;
                testcases--;
            }
        }
    }   
}
/
