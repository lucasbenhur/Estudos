using System;

class URI
{
    static void Main(string[] args)
    {
        var nome = Console.ReadLine();

        double salarioFixo, totalVendas, totalReceber;

        salarioFixo = double.Parse(Console.ReadLine());
        totalVendas = double.Parse(Console.ReadLine());

        totalReceber = salarioFixo + ((totalVendas * 15) / 100);

        Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2"));
    }
}
