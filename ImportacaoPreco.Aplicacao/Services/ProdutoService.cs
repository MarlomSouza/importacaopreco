using System.Linq;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.Predicates;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class ProdutoService : EntityService<Produto, ProdutoDto>, IEntityService<Produto, ProdutoDto>
    {
        private readonly IRepository<Tamanho> _tamanhoRepository;
        private readonly IRepository<Cor> _corRepositorio;
        private readonly IRepository<Subgrupo> _subgrupoRepositorio;

        public ProdutoService(IRepository<Produto> repository, IRepository<Tamanho> tamanhoRepository, IRepository<Cor> corRepositorio,
                             IRepository<Subgrupo> subgrupoRepositorio) : base(repository)
        {
            _tamanhoRepository = tamanhoRepository;
            _corRepositorio = corRepositorio;
            _subgrupoRepositorio = subgrupoRepositorio;
        }

        public override void Criar(ProdutoDto entityDto)
        {
            var ids = PredicateEntity.Contains<Tamanho>(entityDto.Tamanhos);
            var tamanhos = _tamanhoRepository.ObterTodos(ids);
            var idCores = PredicateEntity.Contains<Cor>(entityDto.CorId);
            var cores = _corRepositorio.ObterTodos(idCores);
            var subGrupo = _subgrupoRepositorio.ObterPorId(entityDto.SubgrupoId);
            var preco = new Preco(entityDto.Valor_Base);
            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco);
            Criar(produto);
        }
    }
}