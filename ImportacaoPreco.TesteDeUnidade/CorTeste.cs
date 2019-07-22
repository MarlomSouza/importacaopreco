using System;
using ImportacaoPreco.Dominio.Entity;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class CorTeste
    {
        [Theory]
        [InlineData("Branco")]
        [InlineData("Preto")]
        [InlineData("Azul")]
        public void DeveCriarCorComNome(string nome)
        {
            //When
            var cor = new Cor(nome);
            //Then
            Assert.Equal(nome, cor.Nome);
        }

        [Theory]
        [InlineData(" ")]
        [InlineData(null)]
        [InlineData("")]
        public void NaoDeveCriarCorComNomeInvalido(string nomeinvalido)
        {
            //Given

            //When
            Func<object> testCode = () => new Cor(nomeinvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(testCode).Message;
            Assert.Equal("Nome da Cor invalida", mensagem);
        }
    }
}