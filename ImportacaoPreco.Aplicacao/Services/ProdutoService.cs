using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.ValueObjects;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class ProdutoService : EntityService<Produto, ProdutoDto>, IEntityService<Produto, ProdutoDto>
    {
        public ProdutoService(IRepository<Produto> repository) : base(repository)
        { }

        public override void Criar(ProdutoDto entityDto)
        {

            var tamanhos = new[] { new Tamanho("Grande") };
            var cores = new[] { new Cor("Verde") };
            var subGrupo = new Subgrupo("Tenis", new Grupo("Calcaçado"));
            var preco = new Preco(entityDto.Valor_Base);
            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco);
            Criar(produto);
        }
    }
}