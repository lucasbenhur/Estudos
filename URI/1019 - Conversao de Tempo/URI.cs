using System;

class URI
{
    static void Main(string[] args)
    {
        int valor;

        valor = int.Parse(Console.ReadLine());

        int hora = valor / 3600;
        int minuto = (valor - (hora * 3600)) / 60;
        int segundo = (valor - (hora * 3600) - (minuto * 60));

        Console.WriteLine($"{hora}:{minuto}:{segundo}");
    }
}