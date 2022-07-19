using System;
using System.Collections.Generic;

namespace UriOnlineJudge
{
    class Program
    {
        static string Solution(int input)
        {
            Dictionary<int, string> DDD = new Dictionary<int, string>();
            DDD.Add(61, "Brasilia");
            DDD.Add(71, "Salvador");
            DDD.Add(11, "Sao Paulo");
            DDD.Add(21, "Rio de Janeiro");
            DDD.Add(32, "Juiz de Fora");
            DDD.Add(19, "Campinas");
            DDD.Add(27, "Vitoria");
            DDD.Add(31, "Belo Horizonte");
            try { return DDD[input]; }
            catch { return "DDD nao cadastrado"; }
        }
        static void Main(string[] args)
        { 
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Solution(input));
        }
    }
}
