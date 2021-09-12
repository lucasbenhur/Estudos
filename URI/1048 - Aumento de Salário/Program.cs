using System;

class Program
{
    static void Main(string[] args)
    {
        var salario = double.Parse(Console.ReadLine());

        double novoSalario = 0, reajusteGanho = 0;
        int percentual = 0;

        if (salario >= 0 && salario <= 400)
        {
            novoSalario = salario * 1.15;
            reajusteGanho = salario * 0.15;
            percentual = 15;
        }

        if (salario >= 400.01 && salario <= 800)
        {
            novoSalario = salario * 1.12;
            reajusteGanho = salario * 0.12;
            percentual = 12;
        }

        if (salario >= 800.01 && salario <= 1200)
        {
            novoSalario = salario * 1.10;
            reajusteGanho = salario * 0.10;
            percentual = 10;
        }

        if (salario >= 1200.01 && salario <= 2000)
        {
            novoSalario = salario * 1.07;
            reajusteGanho = salario * 0.07;
            percentual = 7;
        }

        if (salario > 2000)
        {
            novoSalario = salario * 1.04;
            reajusteGanho = salario * 0.04;
            percentual = 4;
        }

        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
        Console.WriteLine($"Em percentual: {percentual} %");
    }
}
