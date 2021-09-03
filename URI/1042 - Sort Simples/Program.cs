using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();

        var listaComoFoiLido = new List<int>();

        listaComoFoiLido.Add(int.Parse(entrada.Split(' ')[0]));
        listaComoFoiLido.Add(int.Parse(entrada.Split(' ')[1]));
        listaComoFoiLido.Add(int.Parse(entrada.Split(' ')[2]));

        var listaOrdemCrescente = listaComoFoiLido.OrderBy(x => x);

        foreach (var item in listaOrdemCrescente)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        foreach (var item in listaComoFoiLido)
        {
            Console.WriteLine(item);
        }
    }
}
