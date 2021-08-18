using System;

class URI
{
    static void Main(string[] args)
    {
        double n, raio, area;

        raio = double.Parse(Console.ReadLine());

        n = 3.14159;

        area = (raio*raio)*n;

        Console.WriteLine("A=" + area.ToString("0.0000"));
    }

}