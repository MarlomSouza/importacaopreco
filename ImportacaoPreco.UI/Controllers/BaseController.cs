using System.Collections.Generic;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Aplicacao.Services;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T, TDto> : ControllerBase where T : Entity<T> where TDto : Dto
    {
        protected IEntityService<T, TDto> _service;

        public BaseController(IEntityService<T, TDto> service) => _service = service;

        public void Post([FromBody] TDto dto) => _service.Criar(dto);

        [HttpGet]
        public IEnumerable<T> Get() => _service.ObterTodos();

        [HttpGet]
        [Route("{id}")]
        public T GetById(int id) => _service.ObterPorId(id);

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id) => _service.Remover(id);
    }
}