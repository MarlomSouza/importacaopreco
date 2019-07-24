using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Base
{
    public interface IEntityService<T> where T : Entity<T>
    {
        void Criar(string nome);

        void Criar(T entity);

        T ObterPorId(int id);

        IEnumerable<T> ObterTodos();

        void Remover(int id);
    }
}