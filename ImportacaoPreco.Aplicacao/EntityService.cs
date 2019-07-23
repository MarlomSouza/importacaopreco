using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public abstract class EntityService<TEntity> : IEntityService<Grupo>  where TEntity : Entity<TEntity>
    {
        private readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository) => _repository = repository;

        protected void Criar(TEntity entity) => _repository.Adicionar(entity);

        protected TEntity ObterPorId(int id) => _repository.ObterPorId(id);
    }
}