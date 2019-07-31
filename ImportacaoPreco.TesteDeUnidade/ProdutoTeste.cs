using ImportacaoPreco.Dominio.Entities;
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
            var cor = new Cor[] { new Cor("Verde"), new Cor("Preto") };
            var tamanho = new Tamanho[] { new Tamanho("grande"), new Tamanho("Pequeno") };
            var subgrupo = new Subgrupo("Tenis", grupo);
            var preco = new Preco(10);
            //When
            var produto = new Produto(nome, tamanho, cor, subgrupo, preco);
            //Then
            Assert.Equal(nome, produto.Nome);
            Assert.Equal(preco, produto.Preco);
            Assert.Equal(cor, produto.Cores);
            Assert.Equal(tamanho, produto.Tamanhos);
            Assert.Equal(subgrupo, produto.Subgrupo);
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