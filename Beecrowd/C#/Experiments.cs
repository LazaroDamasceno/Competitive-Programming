using System;
using System.Linq;
using System.Collections.Generic;

namespace Beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> animais = new Dictionary<char, int>();
            animais.Add('C', 0);
            animais.Add('R', 0);
            animais.Add('S', 0);
            int casos = int.Parse(Console.ReadLine());
            while (casos != 0)
            {
                string[] linha = Console.ReadLine().Split();
                int quantidade = int.Parse(linha[0]);
                char tipo = char.Parse(linha[1]);
                if (tipo == 'C' || tipo == 'R' || tipo == 'S')
                    animais[tipo] += quantidade;
                casos--;
            }
            Console.WriteLine($"Total: {animais.Values.Sum()} cobaias");
            Console.WriteLine($"Total de coelhos: {animais['C']}");
            Console.WriteLine($"Total de ratos: {animais['R']}");
            Console.WriteLine($"Total de sapos: {animais['S']}");
            Console.WriteLine($"Percentual de coelhos: {((animais['C'] * 1.0)/ animais.Values.Sum()) * 100.0:.00} %");
            Console.WriteLine($"Percentual de ratos: {((animais['R'] * 1.0)/ animais.Values.Sum()) * 100.0:.00} %");
            Console.WriteLine($"Percentual de sapos: {((animais['S'] * 1.0)/ animais.Values.Sum()) * 100.0:.00} %");
        }
    }
}
