using System;

class URI
{
    static void Main(string[] args)
    {
        int valor;

        valor = int.Parse(Console.ReadLine());

        int anos = valor / 365;
        int meses = (valor - (anos * 365)) / 30;
        int dias = valor - (anos * 365) - (meses * 30);

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}