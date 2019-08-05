using System;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.ValueObjects;
using ImportacaoPreco.Dominio.VO;
using Xunit;

namespace ImportacaoPreco.TesteDeUnidade
{
    public class ProdutoTeste
    {
        [Fact]
        public void DeveCriarProduto()
        {
            //Given
            var nome = "Tenis";
            var grupo = new Grupo("Sapato");
            var cores = new Cor[] { new Cor("Verde"), new Cor("Preto") };
            var tamanho = new Tamanho[] { new Tamanho("grande"), new Tamanho("Pequeno") };
            var subgrupo = new Subgrupo("Tenis", grupo);
            var preco = new decimal(10);
            var precoPromocional = new PrecoPromocional(10, DateTime.Now, DateTime.Now.AddDays(1));
            var precosPromocionais = new [] {precoPromocional};
            //When
            var produto = new Produto(nome, tamanho, cores, subgrupo, preco, precosPromocionais);
            //Then
            Assert.Equal(nome, produto.Nome);
            Assert.Equal(preco, produto.Preco);
            Assert.Equal(cores, produto.Cores);
            Assert.Equal(tamanho, produto.Tamanhos);
            Assert.Equal(subgrupo, produto.Subgrupo);
            Assert.Equal(precosPromocionais, produto.PrecosPromocionais);
        }

        [Fact]
        public void NaoDeveCriarProdutoComNomeInvalido()
        {
            //Given

            //When

            //Then
        }
    }
}