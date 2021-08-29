using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.Core
{
    public class ValorMaior : IModalidade
    {
        public Lance ObtemGanhador(IEnumerable<Lance> lances)
        {
            return lances
                .DefaultIfEmpty(new Lance(null, 0))
                .OrderBy(o => o.Valor)
                .LastOrDefault();
        }
    }
}