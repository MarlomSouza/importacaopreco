using System;
using System.Collections.Generic;
using System.Linq;
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
            var random = new Random();
            var tamanhos = MapeadorDeTamanho(entityDto.Tamanhos);
            var cores = MapeadorDeCor(entityDto.Cores);
            var subGrupo = new Subgrupo("Tenis", new Grupo("Calcaçado"));
            var preco = entityDto.Valor_Base;
            var precoPromocinal = new PrecoPromocional(preco * random.Next(), DateTime.Now, DateTime.Now.AddDays(1));
            var precosPromocionais = new[] { precoPromocinal };
            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco, precosPromocionais);
            Criar(produto);
        }

        public static IList<Tamanho> MapeadorDeTamanho(IList<string> tamanhos) => tamanhos.Select(t => new Tamanho(t)).ToList();
        public static IList<Cor> MapeadorDeCor(IList<string> cores) => cores.Select(c => new Cor(c)).ToList();
    }
}