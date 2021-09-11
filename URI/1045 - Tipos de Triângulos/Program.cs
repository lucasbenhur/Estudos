using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        string entrada = Console.ReadLine();

        var lista = new List<double>
        {
            double.Parse(entrada.Split(' ')[0]),
            double.Parse(entrada.Split(' ')[1]),
            double.Parse(entrada.Split(' ')[2])
        };

        lista = lista.OrderByDescending(x => x).ToList();

        a = lista[0];
        b = lista[1];
        c = lista[2];

        if (a >= b + c)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
            return;
        }            

        if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
            Console.WriteLine("TRIANGULO RETANGULO");

        if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            Console.WriteLine("TRIANGULO OBTUSANGULO");

        if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            Console.WriteLine("TRIANGULO ACUTANGULO");

        if (a == b && a == c)
            Console.WriteLine("TRIANGULO EQUILATERO");

        if ((a == b && a != c) ||
            (a == c && a != b) ||
            (b == c && b != a))
            Console.WriteLine("TRIANGULO ISOSCELES");
    }
}