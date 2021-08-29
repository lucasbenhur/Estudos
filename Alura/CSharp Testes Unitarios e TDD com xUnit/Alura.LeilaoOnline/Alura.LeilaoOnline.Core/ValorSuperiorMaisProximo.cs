using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class ValorSuperiorMaisProximo : IModalidade
    {
        public double ValorDestino { get; }

        public ValorSuperiorMaisProximo(double valorDestino)
        {
            ValorDestino = valorDestino;
        }

        public Lance ObtemGanhador(IEnumerable<Lance> lances)
        {
            return lances
                   .DefaultIfEmpty(new Lance(null, 0))
                   .Where(l => l.Valor > ValorDestino)
                   .OrderBy(l => l.Valor)
                   .FirstOrDefault();
        }
    }
}