using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao.Services
{
    public class SubgrupoService : EntityService<Subgrupo>, IEntityService<Subgrupo>
    {
        public SubgrupoService(IRepository<Subgrupo> repository) : base(repository)
        {
        }

        public override void Criar(string nome)
        {
            
        }
    }
}