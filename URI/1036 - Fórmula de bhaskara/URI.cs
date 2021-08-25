using System;

class URI
{
    static void Main(string[] args)
    {
        string entrada;
        double A, B, C, delta, x1, x2;

        entrada = Console.ReadLine();

        A = double.Parse(entrada.Split(' ')[0]);
        B = double.Parse(entrada.Split(' ')[1]);
        C = double.Parse(entrada.Split(' ')[2]);

        delta = Math.Pow(B, 2) - 4 * A * C;

        if (delta >= 0 && 2 * A != 0)
        {
            x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            x2 = (-B - Math.Sqrt(delta)) / (2 * A);

            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }
}