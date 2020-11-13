using System;

class URI
{
    static void Main(string[] args)
    {
        const double pi = 3.14159;

        var raio = double.Parse(Console.ReadLine());

        var volume = (4.0 / 3.0) * pi * Math.Pow(raio, 3.0);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}
