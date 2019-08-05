using System;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.ValueObjects;
using ImportacaoPreco.Dominio.VO;

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
            var preco = entityDto.Valor_Base;
            var precoPromocinal = new PrecoPromocional(10, DateTime.Now, DateTime.Now.AddDays(1));
            var precosPromocionais = new[] { precoPromocinal };
            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco, precosPromocionais);
            Criar(produto);
        }
    }
}