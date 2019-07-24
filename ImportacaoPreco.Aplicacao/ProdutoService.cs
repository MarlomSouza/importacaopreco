using System.Collections.Generic;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Aplicacao
{
    public class ProdutoService : EntityService<Produto>, IEntityService<Produto>
    {
        public ProdutoService(IRepository<Produto> repository) : base(repository) { }

        public override void Criar(string nome)
        {
            var tamanhos = new[] { new Tamanho("P") };
            var cores = new[] { new Cor("Branca") };
            var grupo = new Grupo("Grupo I");
            var subGrupo = new Subgrupo("Subgrupo I", grupo);
            var preco = new Preco(100);

            var produto = new Produto(nome, tamanhos, cores, subGrupo, preco);
            Criar(produto);
        }
    }
}