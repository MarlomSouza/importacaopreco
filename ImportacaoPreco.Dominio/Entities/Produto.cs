using System.Collections.Generic;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Produto : Entity<Produto>
    {
        public readonly string Nome;
        public readonly IEnumerable<Cor> Cores;
        public readonly Subgrupo Subgrupo;
        public readonly IEnumerable<Tamanho> Tamanhos;
        public readonly Preco Preco;

        protected Produto() { }

        public Produto(string nome, IEnumerable<Tamanho> tamanhos, IEnumerable<Cor> cores, Subgrupo subgrupo, Preco preco)
        {
            Nome = nome;
            Tamanhos = tamanhos;
            Cores = cores;
            Subgrupo = subgrupo;
            Preco = preco;
        }
    }
}