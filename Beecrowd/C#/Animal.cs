using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            if (word1 == "vertebrado")
            {
                if (word2 == "ave")
                {
                    if (word3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                if (word2 == "mamifero")
                {
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    if (word3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            if (word1 == "invertebrado")
            {
                if (word2 == "inseto")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    if (word3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                if (word2 == "anelideo")
                {
                    if (word3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    if (word3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
