using System;

class Program
{
    static void Main(string[] args)
    {
        bool saoMultiplos = false;
        int a, b;
        string entrada = Console.ReadLine();

        a = int.Parse(entrada.Split(' ')[0]);
        b = int.Parse(entrada.Split(' ')[1]);

        if (a > b &&
            a % b == 0)
            saoMultiplos = true;

        if (b > a &&
            b % a == 0)
            saoMultiplos = true;

        Console.WriteLine(saoMultiplos ? "Sao Multiplos" : "Nao sao Multiplos");
    }
}
