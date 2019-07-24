using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TamanhoController : BaseController<Tamanho>
    {
        public TamanhoController(IEntityService<Tamanho> service) : base(service)
        {
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] TamanhoDto tamanho) => _service.Criar(tamanho.Nome);
    }
}