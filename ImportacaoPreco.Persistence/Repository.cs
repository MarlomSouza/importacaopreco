using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Persistence
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context) => _context = context;

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

        public virtual TEntity ObterPorId(int id)
        {
            return _context.Set<TEntity>().Single(entity => entity.Id == id);
        }

        public void Remover(TEntity entidade)
        {
            _context.Set<TEntity>().Remove(entidade);
            _context.SaveChanges();
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            var entidades = _context.Set<TEntity>().ToList();
            return entidades.Any() ? entidades : new List<TEntity>();
        }

        public virtual IEnumerable<TEntity> ObterTodos(Func<TEntity, bool> predicate)
        {
            var entidades = _context.Set<TEntity>().Where(predicate).ToList();
            return entidades.Any() ? entidades : new List<TEntity>();
        }
    }
}