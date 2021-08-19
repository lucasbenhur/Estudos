using System;

class URI
{
    static void Main(string[] args)
    {
        int tempo, velocidadeMedia;

        tempo = int.Parse(Console.ReadLine());
        velocidadeMedia = int.Parse(Console.ReadLine());

        var litros = (tempo * velocidadeMedia) / 12.0;

        Console.WriteLine($"{litros:F3}");
    }
}