using System;

class Program
{
    static void Main(string[] args)
    {
        int hInicio, hFim, mInicio, mFim;
        string entrada = Console.ReadLine();

        hInicio = int.Parse(entrada.Split(' ')[0]);
        mInicio = int.Parse(entrada.Split(' ')[1]);
        hFim = int.Parse(entrada.Split(' ')[2]);
        mFim = int.Parse(entrada.Split(' ')[3]);

        if (hInicio == hFim && 
            mInicio == mFim)
        {
            Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }
        else
        {
            var h = hInicio;
            var m = mInicio;
            var duracaoHora = 0;
            var duracaoMinuto = 1;

            while (true)
            {
                m++;

                if (m == 60)
                {
                    m = 0;

                    h++;
                    if (h == 24)
                        h = 0;
                }

                if (h == hFim &&
                    m == mFim)
                    break;
                else
                {
                    duracaoMinuto++;

                    if (duracaoMinuto == 60)
                    {
                        duracaoMinuto = 0;
                        duracaoHora++;
                    }
                }
            }

            Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
        }

    }
}
