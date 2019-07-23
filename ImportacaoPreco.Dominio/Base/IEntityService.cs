using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Dominio.Base
{
    public interface IEntityService<T> where T : Entity<T>
    {
        void Criar(string nome);

        T ObterPorId(int id);
    }
}