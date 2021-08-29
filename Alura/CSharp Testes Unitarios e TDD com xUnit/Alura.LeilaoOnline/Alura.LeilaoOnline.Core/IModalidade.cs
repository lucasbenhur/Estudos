using System.Collections.Generic;

namespace Alura.LeilaoOnline.Core
{
    public  interface IModalidade
    {
        Lance ObtemGanhador(IEnumerable<Lance> lances);
    }
}