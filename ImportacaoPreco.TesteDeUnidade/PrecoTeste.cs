using System;
using ImportacaoPreco.Dominio;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class PrecoTeste
    {
        [Theory]
        [InlineData(10.0)]
        public void DeveCriarPreco(decimal valor)
        {
            //Given

            //When
            var preco = new Preco(valor);
            //Then
            Assert.Equal(valor, preco.Valor);
        }
        [Theory]
        [InlineData(-10)]
        public void NaoDeveCriarPrecoComValorInvalido(decimal valorInvalido)
        {
            //Given

            //When
            Action act = () => new Preco(valorInvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(act).Message;
            Assert.Equal("Não deve criar Preço com valor invalido", mensagem);
        }
    }
}