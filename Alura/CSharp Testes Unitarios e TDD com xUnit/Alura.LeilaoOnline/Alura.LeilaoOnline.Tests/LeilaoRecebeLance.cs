using Alura.LeilaoOnline.Core;
using System.Linq;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeLance
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimoLance()
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário): Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorMaior();
            var leilao = new Leilao("Van Gogh", modalidade);
            leilao.IniciaPregao();

            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);

            // Act - (Agir): Invoca método sobre teste com os parâmetros organizados
            leilao.RecebeLance(fulano, 1000);

            // Assert - (Declarar) Verificar se a ação do método em teste se comporta conforme o esperado
            int qtdeEsperada = 1;
            int qtdeObtida = leilao.Lances.Count();

            Assert.Equal(qtdeEsperada, qtdeObtida);
        }

        [Fact]
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado()
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário): Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorMaior();
            var leilao = new Leilao("Van Gogh", modalidade);
            leilao.IniciaPregao();

            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);

            var siclano = new Interessada("Siclano", leilao);
            leilao.RecebeLance(siclano, 900);

            leilao.TerminaPregao();

            // Act - (Agir): Invoca método sobre teste com os parâmetros organizados
            leilao.RecebeLance(fulano, 1000);

            // Assert - (Declarar) Verificar se a ação do método em teste se comporta conforme o esperado
            int esperado = 2;
            int obtido = leilao.Lances.Count();

            Assert.Equal(esperado, obtido);
        }
    }
}
