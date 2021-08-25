using System;

class URI
{
    static void Main(string[] args)
    {
        string entrada;
        int A, B, C, D;

        entrada = Console.ReadLine();

        A = int.Parse(entrada.Split(' ')[0]);
        B = int.Parse(entrada.Split(' ')[1]);
        C = int.Parse(entrada.Split(' ')[2]);
        D = int.Parse(entrada.Split(' ')[3]);

        if ((B > C) &&
            (D > A) &&
            ((C + D) > (A + B)) &&
            (C > 0 && D > 0) &&
            (A % 2 == 0))
        {
            Console.WriteLine("Valores aceitos");
        } else
        {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}