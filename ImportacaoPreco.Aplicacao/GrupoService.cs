using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public class GrupoService : EntityService<Grupo>, IEntityService<Grupo>
    {
        public GrupoService(IRepository<Grupo> repository) : base(repository) { }

        public void Criar(string nome)
        {
            var grupo = new Grupo(nome);
            Criar(grupo);
        }
    }
}