using System;
using System.Collections.Generic;
using System.Linq;
using ImportacaoPreco.Dominio.ValueObjects;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.Entities
{
    public class Produto : Entity<Produto>
    {
        public string Nome { get; protected set; }
        public IEnumerable<Cor> Cores { get; private set; }
        public Subgrupo Subgrupo { get; private set; }
        public IEnumerable<Tamanho> Tamanhos { get; private set; }
        public decimal Preco { get; private set; }
        private ICollection<PrecoPromocional> _precosPromocionais;
        public IEnumerable<PrecoPromocional> PrecosPromocionais => _precosPromocionais;

        protected Produto() { }


        public Produto(string nome, IEnumerable<Tamanho> tamanhos, IEnumerable<Cor> cores, Subgrupo subgrupo, decimal preco, IList<PrecoPromocional> precosPromocionais)
        {
            ValidarPreco(preco);
            Nome = nome;
            Tamanhos = tamanhos;
            Cores = cores;
            Subgrupo = subgrupo;
            Preco = preco;
            _precosPromocionais = precosPromocionais;
        }

        private void ValidarPreco(decimal preco)
        {
            if (preco <= 0)
                throw new ArgumentException("Não deve criar Preoduco com preço invalido");
        }
    }
}