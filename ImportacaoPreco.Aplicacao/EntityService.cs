using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public abstract class EntityService<TEntity> : IEntityService<TEntity> where TEntity : Entity<TEntity>
    {
        private readonly IRepository<TEntity> _repository;

        public EntityService(IRepository<TEntity> repository) => _repository = repository;

        public abstract void Criar(string nome);

        public void Criar(TEntity entity) => _repository.Adicionar(entity);

        public TEntity ObterPorId(int id) => _repository.ObterPorId(id);
    }
}