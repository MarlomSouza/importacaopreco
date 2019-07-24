using System;
using System.Collections.Generic;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Base
{
    public interface IRepository<TEntidade> where TEntidade : Entity<TEntidade>
    {
        TEntidade ObterPorId(int id);
        IEnumerable<TEntidade> ObterTodos();
        IEnumerable<TEntidade> ObterTodos(Predicate<TEntidade> predicate);
        void Adicionar(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Remover(TEntidade entidade);
    }
}