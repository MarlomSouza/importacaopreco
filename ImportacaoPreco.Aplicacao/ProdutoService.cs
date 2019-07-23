using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public class ProdutoService : IProdutoService
    {
        private readonly IRepository<Produto> _produtoRepository;

        public ProdutoService(IRepository<Produto> produtoRepository) => _produtoRepository = produtoRepository;

        public void Criar(string nome)
        {
            
        }
    }
}