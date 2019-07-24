using System;
using System.Collections.Generic;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public abstract class EntityService<TEntity, TDto> : IEntityService<TEntity, TDto> where TEntity : Entity<TEntity> where TDto : Dto
    {
        private readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository) => _repository = repository;

        public virtual void Criar(TDto entityDto)
        {
            var entidade = (TEntity)Activator.CreateInstance(typeof(TEntity), entityDto.Nome);
            Criar(entidade);
        }

        public void Criar(TEntity entity) => _repository.Adicionar(entity);

        public TEntity ObterPorId(int id) => _repository.ObterPorId(id);

        public IEnumerable<TEntity> ObterTodos() => _repository.ObterTodos();

        public void Remover(int id)
        {
            var entidade = ObterPorId(id);
            _repository.Remover(entidade);
        }

    }
}