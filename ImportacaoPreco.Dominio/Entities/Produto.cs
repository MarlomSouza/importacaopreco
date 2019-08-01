using System.Collections.Generic;
using ImportacaoPreco.Dominio.ValueObjects;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Produto : Entity<Produto>
    {
        public IEnumerable<Cor> Cores { get; private set; }
        public Subgrupo Subgrupo { get; private set; }
        public IEnumerable<Tamanho> Tamanhos { get; private set; }
        public Preco Preco { get; private set; }

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