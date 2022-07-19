using System;

namespace CodeForces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string ans = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 'A'
                    && input[i] != 'O'
                    && input[i] != 'Y'
                    && input[i] != 'E'
                    && input[i] != 'U'
                    && input[i] != 'I'
                    && input[i] != 'a'
                    && input[i] != 'o'
                    && input[i] != 'y'
                    && input[i] != 'e'
                    && input[i] != 'u'
                    && input[i] != 'i')
                {
                    ans += '.';
                    ans += input[i];
                }
            }
            Console.WriteLine(ans.ToLower());
        }
    }
}
