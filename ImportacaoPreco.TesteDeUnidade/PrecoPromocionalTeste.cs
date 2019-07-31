using Xunit;
using System;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class PrecoPromocionalTeste
    {
        [Fact]
        public void DeveCriarPrecoPromocional()
        {
            //Given
            var valor = 10;
            var dataInicioPromocao = DateTime.Now;
            var dataFimPromocao = DateTime.Now.AddDays(7);
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
            var dataInicioPromocao = DateTime.Now;
            var dataFimPromocao = DateTime.Now.AddDays(7);
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
        var dataInicioPromocao = DateTime.Now;
        var dataFimPromocao = DateTime.Now.AddDays(-10);
        //When
        Action act = () => new PrecoPromocional(valor, dataInicioPromocao, dataFimPromocao);
        //Then
        var mensagem = Assert.Throws<ArgumentException>(act).Message;
        Assert.Equal("Não deve criar Preco promocional com Data invalida", mensagem);
        }
    }
}