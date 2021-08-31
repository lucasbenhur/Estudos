using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();

        double n1 = double.Parse(entrada.Split(' ')[0]);
        double n2 = double.Parse(entrada.Split(' ')[1]);
        double n3 = double.Parse(entrada.Split(' ')[2]);
        double n4 = double.Parse(entrada.Split(' ')[3]);
                
        double media = Math.Round(((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1), 1);

        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            if (media < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                if (media >= 5 && media <= 6.9)
                {
                    Console.WriteLine("Aluno em exame.");

                    double notaExame = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Nota do exame: {notaExame:F1}");

                    media = Math.Round((media + notaExame) / 2, 1);

                    if (media >= 5)
                        Console.WriteLine("Aluno aprovado.");
                    else
                        Console.WriteLine("Aluno reprovado.");

                    Console.WriteLine($"Media final: {media:F1}");
                }
            }
        }
    }
}
