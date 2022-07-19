using System;
using System.Collections.Generic;
using System.Linq;

namespace CompetitiveProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            double A = double.Parse(line[0]);
            double B = double.Parse(line[1]);
            double C = double.Parse(line[2]);
            double rectangledTriangle = (A * C) / 2.0;
            double trapezium  = (C * (A + B)) / 2.0;
            double rectangle = A * B;
            double square = B * B;
            double circle = C * C * 3.14159;
            Console.WriteLine($"TRIANGULO: {rectangledTriangle:0.000}");
            Console.WriteLine($"CIRCULO: {circle:0.000}");
            Console.WriteLine($"TRAPEZIO: {trapezium:0.000}");
            Console.WriteLine($"QUADRADO: {square:0.000}");
            Console.WriteLine($"RETANGULO: {rectangle:0.000}"); 
        }
    }
}
