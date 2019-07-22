using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entity
{
    public class Produto
    {
        public readonly string Nome;
        public readonly Cor Cor;
        public readonly Subgrupo Subgrupo;
        public readonly Tamanho Tamanho;
        public readonly Preco Preco;

        public Produto(string nome, Tamanho tamanho, Cor cor, Subgrupo subgrupo, Preco preco)
        {
            Nome = nome;
            Tamanho = tamanho;
            Cor = cor;
            Subgrupo = subgrupo;
            Preco = preco;
        }
    }
}