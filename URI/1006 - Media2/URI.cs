using System;

class URI
{
    static void Main(string[] args)
    {
        double a, b, c, media;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        media = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

        Console.WriteLine("MEDIA = " + media.ToString("F1"));
    }
}
