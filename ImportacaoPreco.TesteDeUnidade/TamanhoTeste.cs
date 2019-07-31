using System;
using ImportacaoPreco.Dominio.Entities;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class TamanhoTeste
    {

        [Theory]
        [InlineData("PP")]
        [InlineData("P")]
        [InlineData("M")]
        [InlineData("G")]
        [InlineData("GG")]
        public void DeveCriarTamanhoComNome(string nome)
        {
            //Given

            //When
            var tamanho = new Tamanho(nome);
            //Then
            Assert.Equal(nome, tamanho.Nome);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void NaoDeveCriarTamanhoComNomeInvalido(string nomeinvalido)
        {
            //Given

            //When
            Func<object> testCode = () => new Tamanho (nomeinvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(testCode).Message;
            Assert.Equal("Nome do Tamanho invalido", mensagem);
        }
    }
}