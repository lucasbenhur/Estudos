using System;

class URI
{
    static void Main(string[] args)
    {
        var entrada = Console.ReadLine();

        var A = int.Parse(entrada.Split(' ')[0]);
        var B = int.Parse(entrada.Split(' ')[1]);
        var C = int.Parse(entrada.Split(' ')[2]);

        var maiorAB = (A + B + Math.Abs(A - B)) / 2;

        var maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

        Console.WriteLine($"{maiorABC} eh o maior");
    }
}
