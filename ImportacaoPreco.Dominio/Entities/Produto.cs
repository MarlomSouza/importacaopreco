using System.Collections.Generic;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Produto : Entity<Produto>
    {
        public readonly string Nome;
        public readonly IEnumerable<Cor> Cores;
        public readonly IEnumerable<Subgrupo> Subgrupos;
        public readonly IEnumerable<Tamanho> Tamanhos;
        public readonly Preco Preco;

        public Produto(string nome, IEnumerable<Tamanho> tamanhos, IEnumerable<Cor> cores, IEnumerable<Subgrupo> subgrupos, Preco preco)
        {
            Nome = nome;
            Tamanhos = tamanhos;
            Cores = cores;
            Subgrupos = subgrupos;
            Preco = preco;
        }
    }
}