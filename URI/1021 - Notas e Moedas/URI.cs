using System;

class URI
{
    static void Main(string[] args)
    {
        double valor;

        valor = double.Parse(Console.ReadLine());

        int reais = (int)valor;
        int centavos = (int)((valor - reais) * 100);

        var notas100 = reais / 100;
        reais -= notas100 * 100;

        var notas50 = reais / 50;
        reais -= notas50 * 50;

        var notas20 = reais / 20;
        reais -= notas20 * 20;

        var notas10 = reais / 10;
        reais -= notas10 * 10;

        var notas5 = reais / 5;
        reais -= notas5 * 5;

        var notas2 = reais / 2;
        reais -= notas2 * 2;

        var moedas100 = reais / 1;

        var moedas050 = centavos / 50;
        centavos -= moedas050 * 50;

        var moedas025 = centavos / 25;
        centavos -= moedas025 * 25;

        var moedas010 = centavos / 10;
        centavos -= moedas010 * 10;

        var moedas005 = centavos / 5;
        centavos -= moedas005 * 5;

        var moedas001 = centavos / 1;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{notas100} nota(s) de R$ 100.00");
        Console.WriteLine($"{notas50} nota(s) de R$ 50.00");
        Console.WriteLine($"{notas20} nota(s) de R$ 20.00");
        Console.WriteLine($"{notas10} nota(s) de R$ 10.00");
        Console.WriteLine($"{notas5} nota(s) de R$ 5.00");
        Console.WriteLine($"{notas2} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moedas100} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moedas050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moedas025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moedas010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moedas005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moedas001} moeda(s) de R$ 0.01");
    }
}