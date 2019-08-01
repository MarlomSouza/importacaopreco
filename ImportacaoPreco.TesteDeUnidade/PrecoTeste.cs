using System;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.VO;
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
            Assert.Equal(valor, preco.ValorBase);
        }

        [Theory]
        [InlineData(-10)]
        public void NaoDeveCriarPrecoComValorInvalido(decimal valorInvalido)
        {
            //When
            Action act = () => new Preco(valorInvalido);
            //Then
            var mensagem = Assert.Throws<ArgumentException>(act).Message;
            Assert.Equal("Não deve criar Preço com valor invalido", mensagem);
        }

        [Fact]
        public void DeveAdicionarPrecoPromocional()
        {
            //Given
            var dataInicio = new DateTime(2019, 07, 23);
            var dataFim = new DateTime(2019, 07, 24);
            var precoPromocional = new PrecoPromocional(10, dataInicio, dataFim);
            var preco = new Preco(100);
            //When
            preco.AdicionarPrecoPromocional(precoPromocional);
            //Then
            Assert.Contains(precoPromocional, preco.PrecosPromocionais);
        }

        [Fact]
        public void NaoDeveAdicionarPrecoPromocionalNoMesmoPeriodo()
        {
            //Given
            var preco = new Preco(100);
            var dataInicioPromocao = new DateTime(2019, 07, 20);
            var dataFinalPromocao = new DateTime(2019, 07, 20);
            var precoPromocional = new PrecoPromocional(10, dataInicioPromocao, dataFinalPromocao);
            preco.AdicionarPrecoPromocional(precoPromocional);
            //When
            Action act = () => preco.AdicionarPrecoPromocional(precoPromocional);
            //Then
            var mensagem = Assert.Throws<ApplicationException>(act).Message;
            Assert.Equal("Já existe um preço promocional para o periodo desejado", mensagem);
        }


        [Fact]
        public void DeveRetornarPrecoPromocionalQuandoEstiverVigente()
        {
            //Given
            const int valorPromocional = 10;
            var dataInicio = DateTime.Now;
            var dataFim = DateTime.Now.AddDays(3);
            var precoPromocional = new PrecoPromocional(valorPromocional, dataInicio, dataFim);
            var preco = new Preco(100);
            preco.AdicionarPrecoPromocional(precoPromocional);
            //When
            var valorPromocionalObtido = preco.Valor();
            //Then
            Assert.Equal(valorPromocional, valorPromocionalObtido);
        }

    }
}