using System.Collections.Generic;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImportacaoPreco.UI.Controllers
{
    public abstract class BaseController<T> : ControllerBase where T : Entity<T>
    {
        protected IEntityService<T> _service;

        public BaseController(IEntityService<T> service) => _service = service;

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