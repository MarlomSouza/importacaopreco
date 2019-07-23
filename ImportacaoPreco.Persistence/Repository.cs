using System.Collections.Generic;
using System.Linq;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public void Adicionar(TEntity entidade)
        {
            _context.Set<TEntity>().Add(entidade);
            _context.SaveChanges();
        }

        public void Alterar(TEntity entidade)
        {
            _context.Set<TEntity>().Update(entidade);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Listar()
        {
            var entidades = _context.Set<TEntity>().ToList();
            return entidades.Any() ? entidades : new List<TEntity>();
        }

        public TEntity ObterPorId(int id)
        {
            var query = _context.Set<TEntity>().Where(entity => entity.Id == id);
            return query.Any() ? query.First() : null;
        }

        public void Remover(TEntity entidade)
        {
            _context.Set<TEntity>().Remove(entidade);
            _context.SaveChanges();
        }

        IEnumerable<TEntity> IRepository<TEntity>.Listar()
        {
            throw new System.NotImplementedException();
        }
    }
}