using System;

class URI
{
    static void Main(string[] args)
    {
        int numero, qtdHoras;
        float valorHora, salario;

        numero = int.Parse(Console.ReadLine());
        qtdHoras = int.Parse(Console.ReadLine());
        valorHora = float.Parse(Console.ReadLine());

        salario = qtdHoras * valorHora;

        Console.WriteLine("NUMBER = " + numero);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
    }
}
