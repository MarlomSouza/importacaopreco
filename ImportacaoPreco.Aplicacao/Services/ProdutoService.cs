using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class ProdutoService : EntityService<Produto, ProdutoDto>, IEntityService<Produto, ProdutoDto>
    {
        public ProdutoService(IRepository<Produto> repository) : base(repository) { }

        public override void Criar(ProdutoDto entityDto)
        {
            var tamanhos = new[] { new Tamanho("P") };
            var cores = new[] { new Cor("Branca") };
            var grupo = new Grupo("Grupo I");
            var subGrupo = new Subgrupo("Subgrupo I", grupo);
            var preco = new Preco(100);

            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco);
            Criar(produto);
        }
    }
}