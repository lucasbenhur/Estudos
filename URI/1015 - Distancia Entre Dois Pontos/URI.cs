using System;

class URI
{
    static void Main(string[] args)
    {
        var p1 = Console.ReadLine();
        var p2 = Console.ReadLine();

        var x1 = double.Parse(p1.Split(' ')[0]);
        var y1 = double.Parse(p1.Split(' ')[1]);

        var x2 = double.Parse(p2.Split(' ')[0]);
        var y2 = double.Parse(p2.Split(' ')[1]);

        var distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"{distancia:F4}");
    }
}