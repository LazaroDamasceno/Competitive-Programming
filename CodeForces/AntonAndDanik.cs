using System;

namespace UriOnlineJudge
{
    class URI
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int Anton = 0;
            int Danik = 0;
            int Friendship = 0;
            foreach (char el in input)
            {
                if (el == 'A') { Anton++; }
                else if (el == 'D') { Danik++; }
                else { Friendship++; }
            }
            if (Anton > Danik) { Console.WriteLine("Anton"); }
            else if (Anton < Danik) { Console.WriteLine("Danik"); }
            else { Console.WriteLine("Friendship"); }
        }
    }
}
