using System;
using System.Linq;
using System.Collections.Generic;

namespace Question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            Console.WriteLine(phrase.Count(i => i == 'a' 
                || i == 'e'
                || i == 'i'
                || i == 'o'
                || i == 'u'
                || i == 'A'
                || i == 'E'
                || i == 'I'
                || i == 'O'
                || i == 'U'));
        }
    }
}
