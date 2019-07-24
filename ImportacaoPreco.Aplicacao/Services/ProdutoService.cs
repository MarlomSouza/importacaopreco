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

        public ProdutoService(IRepository<Produto> repository, IRepository<Tamanho> tamanhoRepository) : base(repository)
        {
            _tamanhoRepository = tamanhoRepository;
        }

        public override void Criar(ProdutoDto entityDto)
        {
            var tamanhos = _tamanhoRepository.ObterTodos(TamanhoPredicate.TamanhoSelecionado(entityDto.Tamanhos))
            var cores = new[] { new Cor("Branca") };
            var grupo = new Grupo("Grupo I");
            var subGrupo = new Subgrupo("Subgrupo I", grupo);
            var preco = new Preco(100);

            var produto = new Produto(entityDto.Nome, tamanhos, cores, subGrupo, preco);
            Criar(produto);
        }
    }
}