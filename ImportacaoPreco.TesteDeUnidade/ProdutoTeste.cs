using ImportacaoPreco.Dominio.Entity;
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
            var cor = new Cor("Verde");
            var tamanho = new Tamanho("Grande");
            var subgrupo = new Subgrupo("Tenis");
            var preco  = new Preco(10);
            //When
            var produto = new Produto(nome, tamanho, cor, subgrupo, preco);
            //Then
            Assert.Equal(nome, produto.Nome);
            Assert.Equal(preco, produto.Preco);
            Assert.Equal(cor, produto.Cor);
            Assert.Equal(tamanho, produto.Tamanho);
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