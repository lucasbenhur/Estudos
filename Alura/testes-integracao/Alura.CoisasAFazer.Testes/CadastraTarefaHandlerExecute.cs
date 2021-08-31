using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Services.Handlers;
using System;
using System.Linq;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidasDeveIncluirNoBD()
        {
            // arrange
            // Instancia o DOMAIN
            var comando = new CadastraTarefa("Estudar xUnit", new Categoria("Estudo"), new DateTime(2021, 12, 31));

            var repositorio = new RepositorioFake();

            // Instancia o SERVICE
            var handler = new CadastraTarefaHandler(repositorio);

            // act
            // Executa o método sobre teste
            handler.Execute(comando);

            // assert
            var tarefa = repositorio.ObtemTarefas(t => t.Titulo == "Estudar xUnit").FirstOrDefault();
            Assert.NotNull(tarefa);
        }
    }
}
