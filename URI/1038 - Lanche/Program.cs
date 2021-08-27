using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dicLanche = new Dictionary<int, double>();

        dicLanche.Add(1, 4.00);
        dicLanche.Add(2, 4.50);
        dicLanche.Add(3, 5.00);
        dicLanche.Add(4, 2.00);
        dicLanche.Add(5, 1.50);

        var entrada = Console.ReadLine();

        var codigo = int.Parse(entrada.Split(' ')[0]);
        var qtde = double.Parse(entrada.Split(' ')[1]);

        var valor = dicLanche[codigo] * qtde;

        Console.WriteLine($"Total: R$ {valor:F2}");
    }
}
