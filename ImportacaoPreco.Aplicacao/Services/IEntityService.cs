using System.Collections.Generic;
using ImportacaoPreco.Aplicacao.Dtos;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public interface IEntityService<T, TDto> where T : Entity<T> where TDto : Dto
    {
        void Criar(TDto entityDto);

        void Criar(T entity);

        T ObterPorId(int id);

        IEnumerable<T> ObterTodos();

        void Remover(int id);
    }
}