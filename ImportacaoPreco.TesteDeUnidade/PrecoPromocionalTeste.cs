using Xunit;
using ImportacaoPreco.Dominio;
using System;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class PrecoPromocionalTeste
    {
        [Fact]
        public void DeveCriarPrecoPromocional()
        {
            //Given
            var valor = 10;
            var dataInicioPromocao = new DateTime(2019, 07, 19);
            var dataFimPromocao = new DateTime(2019, 07, 25);
            //When
            var precoPromocional = new PrecoPromocional(valor, dataInicioPromocao, dataFimPromocao);
            //Then
            Assert.Equal(valor, precoPromocional.Valor);
            Assert.Equal(dataInicioPromocao, precoPromocional.DataInicioPromocao);
            Assert.Equal(dataFimPromocao, precoPromocional.DataFimPromocao);
        }

        [Fact]
        public void NaoDeveCriarValorDePrecoPromocionalInvalido()
        {
            //Given
            var valor = -10;
            var dataInicioPromocao = new DateTime(2019,07,19);
            var dataFimPromocao = new DateTime(2019,07,25);
            //When
            Action act = () => new PrecoPromocional(valor, dataInicioPromocao, dataFimPromocao);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(act).Message;
            Assert.Equal("Não deve criar Preço promocional com valor invalido", mensagem);
        }
        [Fact]
        public void NaoDeveCriarPrecoPromocionalComDataInvalida()
        {
        //Given
        var valor = 10;
        var dataInicioPromocao = new DateTime(2020,07,21);
        var dataFimPromocao = new DateTime(2020,07,19);
        //When
        Action act = () => new PrecoPromocional(valor, dataInicioPromocao, dataFimPromocao);
        //Then
        var mensagem = Assert.Throws<ArgumentException>(act).Message;
        Assert.Equal("Não deve criar Preco promocional com Data invalida", mensagem);
        }
    }
}