using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.UI.Controllers
{

    public class ProdutosController : BaseController<Produto, ProdutoDto>
    {
        public ProdutosController(IEntityService<Produto, ProdutoDto> service) : base(service) { }
    }
}