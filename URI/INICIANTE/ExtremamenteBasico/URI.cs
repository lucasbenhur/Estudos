using System;

class URI
{

    static void Main(string[] args)
    {
        var strA = Console.ReadLine();
        var strB = Console.ReadLine();

        int A;
        int B;

        Int32.TryParse(strA, out A);
        Int32.TryParse(strB, out B);

        var X = A + B;

        Console.WriteLine("X = " + X);
    }

}