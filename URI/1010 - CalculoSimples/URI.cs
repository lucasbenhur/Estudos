using System;

class URI
{
    static void Main(string[] args)
    {
        var peca1 = Console.ReadLine();
        var peca2 = Console.ReadLine();

        int qtdePeca1 = int.Parse(peca1.Split(' ')[1]);
        double valorPeca1 = double.Parse(peca1.Split(' ')[2]);

        int qtdePeca2 = int.Parse(peca2.Split(' ')[1]);
        double valorPeca2 = double.Parse(peca2.Split(' ')[2]);

        var calculo = (valorPeca1 * qtdePeca1) + (valorPeca2 * qtdePeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + calculo.ToString("F2"));
    }
}
