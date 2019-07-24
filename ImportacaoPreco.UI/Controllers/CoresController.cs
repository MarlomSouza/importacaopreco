using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoresController : BaseController<Cor>
    {
        public CoresController(IEntityService<Cor> service) : base(service)
        {
        }

        [HttpPost]
        public void Post([FromBody] CorDto cor) => _service.Criar(cor.Nome);
    }
}