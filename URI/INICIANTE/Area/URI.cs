using System;

class URI
{
    static void Main(string[] args)
    {
        const double pi = 3.14159;

        var entrada = Console.ReadLine().Split(' ');

        var A = double.Parse(entrada[0]);
        var B = double.Parse(entrada[1]);
        var C = double.Parse(entrada[2]);

        var areaTriangulo = (A * C) / 2;
        var areaCirculo = pi * (C * C);
        var areaTrapezio = ((A + B) * C) / 2;
        var areaQuadrado = B * B;
        var areaRetangulo = A * B;

        Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3")}");
        Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3")}");
    }
}
