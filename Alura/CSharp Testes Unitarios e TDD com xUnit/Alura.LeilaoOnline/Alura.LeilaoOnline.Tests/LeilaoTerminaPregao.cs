using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTerminaPregao
    {
        [Theory]
        [InlineData(1200, 1250, new double[] { 800, 900, 1000, 1200, 1250, 1300, 1500 })]
        public void RetornaValorSuperiorMaiProximoDadoLeilaoNessaModalidade(
            double valorDestino,
            double valorEsperado,
            double[] lances)
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário):
            // > Todas as pré-condições e entradas necessárias.
            // > Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorSuperiorMaisProximo(valorDestino);
            var leilao = new Leilao("Van Gogh", modalidade);
            leilao.IniciaPregao();

            Interessada cliente;
            int index = 1;
            foreach (var lance in lances)
            {
                cliente = new Interessada($"Cliente - {index}", leilao);

                leilao.RecebeLance(cliente, lance);

                index++;
            }

            // Act - (Atuar / Agir): Atue no objeto/método em teste com os parâmetros organizados
            leilao.TerminaPregao();

            // Assert - (Afirme / Declare) Verificar se a ação do método em teste se comporta conforme o esperado
            Assert.Equal(valorEsperado, leilao.Ganhador.Valor);
        }


        [Theory]
        [InlineData(1200, new double[] { 800, 900, 1000, 1200 })]
        [InlineData(1000, new double[] { 800, 900, 1000, 990 })]
        [InlineData(800, new double[] { 800 })]
        public void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(
            double valorEsperado,
            double[] lances)
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário):
            // > Todas as pré-condições e entradas necessárias.
            // > Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorMaior();
            var leilao = new Leilao("Van Gogh", modalidade);
            leilao.IniciaPregao();

            Interessada cliente;
            int index = 1;
            foreach (var lance in lances)
            {
                cliente = new Interessada($"Cliente - {index}", leilao);

                leilao.RecebeLance(cliente, lance);

                index++;
            }

            // Act - (Atuar / Agir): Atue no objeto/método em teste com os parâmetros organizados
            leilao.TerminaPregao();

            // Assert - (Afirme / Declare) Verificar se a ação do método em teste se comporta conforme o esperado
            Assert.Equal(valorEsperado, leilao.Ganhador.Valor);
        }

        [Fact]
        public void LancaInvalidOperationExceptionDadoPregaoNaoIniciado()
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário):
            // > Todas as pré-condições e entradas necessárias.
            // > Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorMaior();
            var leilao = new Leilao("Van Gogh", modalidade);

            // Act - (Agir): Invoca método sobre teste com os parâmetros organizados
            var excecaoObtida = Assert.Throws<System.InvalidOperationException>(                
                () => leilao.TerminaPregao()
            );

            // Assert - (Afirme / Declare) Verificar se a ação do método em teste se comporta conforme o esperado
            var msgEsperada = $"Não foi possível terminar o pregão com status diferente de {nameof(EstadoLeilao.LeilaoEmAndamento)}";

            Assert.Equal(msgEsperada, excecaoObtida.Message);
        }

        [Fact]
        public void RetornaZeroDadoLeilaoSemLance()
        {
            // Pattern AAA

            // Arrange - (Organizar / Cenário): Inicializa os objetos e define o valor dos dados que serão passados para o método sendo testado.
            IModalidade modalidade = new ValorMaior();
            var leilao = new Leilao("Van Gogh", modalidade);
            leilao.IniciaPregao();

            // Act - (Agir): Invoca método sobre teste com os parâmetros organizados
            leilao.TerminaPregao();

            // Assert - (Afirme / Declare) Verificar se a ação do método em teste se comporta conforme o esperado
            double esperado = 0;
            double obtido = leilao.Ganhador.Valor;

            Assert.Equal(esperado, obtido);
        }
    }
}
