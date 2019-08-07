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
        private readonly IRepository<Grupo> _grupoRepositorio;

        public ProdutoService(IRepository<Produto> repository, IRepository<Grupo> grupoRepositorio) : base(repository) => _grupoRepositorio = grupoRepositorio;

        public override void Criar(ProdutoDto entityDto)
        {
            var random = new Random();
            var tamanhos = MapeadorDeTamanho(entityDto.Tamanhos);
            var cores = MapeadorDeCor(entityDto.Cores);
            var subgrupo = MapeadorDeSubGrupo(entityDto);
            var preco = entityDto.Valor_Base * random.Next(10);
            var precoPromocinal = new PrecoPromocional(preco * random.Next(5), DateTime.Now, DateTime.Now.AddDays(random.Next(10)));
            var precosPromocionais = new[] { precoPromocinal };
            var produto = new Produto(entityDto.Nome, tamanhos, cores, subgrupo, preco, precosPromocionais);
            Criar(produto);
        }

        public static IList<Tamanho> MapeadorDeTamanho(IList<string> tamanhos) => tamanhos.Select(t => new Tamanho(t)).ToList();
        public static IList<Cor> MapeadorDeCor(IList<string> cores) => cores.Select(c => new Cor(c)).ToList();

        public Subgrupo MapeadorDeSubGrupo(ProdutoDto entityDto)
        {
            var grupo = _grupoRepositorio.ObterPorId(entityDto.GrupoId);

            var subgrupo = grupo?.Subgrupos?.FirstOrDefault(sb => sb.Nome.Equals(entityDto.Subgrupo));
            if (subgrupo == null)
                return new Subgrupo(entityDto.Subgrupo, grupo);

            return subgrupo;
        }
    }
}