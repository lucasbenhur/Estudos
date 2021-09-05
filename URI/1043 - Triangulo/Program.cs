using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        string entrada = Console.ReadLine();

        a = double.Parse(entrada.Split(' ')[0]);
        b = double.Parse(entrada.Split(' ')[1]);
        c = double.Parse(entrada.Split(' ')[2]);

        if (b - c < a &&
            b + c > a &&
            a - c < b &&
            a + c > b &&
            a - b < c &&
            a + b > c)
        {
            double perimetro = a + b + c;

            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else
        {
            double area = ((a + b) * c) / 2;

            Console.WriteLine($"Area = {area:F1}");
        }
    }
}
