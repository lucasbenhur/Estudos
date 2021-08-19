using System;
using System.Collections.Generic;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int valor;
        List<int> notas = new List<int>
        {
            100,
            50,
            20,
            10,
            5,
            2,
            1
        };

        valor = int.Parse(Console.ReadLine());

        Console.WriteLine(valor);

        foreach (var nota in notas)
        {
            var qtdeNotas = valor / nota;
            
            Console.WriteLine($"{qtdeNotas} nota(s) de R$ {nota.ToString("F2", new CultureInfo("pt-BR"))}");

            valor -= qtdeNotas * nota;
        }
    }
}