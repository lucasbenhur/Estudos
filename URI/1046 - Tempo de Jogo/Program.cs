using System;

class Program
{
    static void Main(string[] args)
    {
        int horaInicial, horaFinal;
        string entrada = Console.ReadLine();

        horaInicial = int.Parse(entrada.Split(' ')[0]);
        horaFinal = int.Parse(entrada.Split(' ')[1]);

        if (horaInicial == horaFinal)
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        }
        else
        {
            int inicio = horaInicial;
            int duracao = 1;
            while (true)
            {
                inicio++;

                if (inicio == 24)
                    inicio = 0;

                if (inicio == horaFinal)
                    break;
                else
                    duracao++;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}