using System;

class URI
{
    static void Main(string[] args)
    {
        var km = int.Parse(Console.ReadLine());
        var l = double.Parse(Console.ReadLine());

        var resultado = km / l;

        Console.WriteLine($"{resultado:F3} km/l");
    }
}