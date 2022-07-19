using System;
using System.Linq;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            while (input != 2002)
            {
                Console.WriteLine("Senha Invalida");
                input = int.Parse(Console.ReadLine());
                if (input == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
            }
        }
    }
}
