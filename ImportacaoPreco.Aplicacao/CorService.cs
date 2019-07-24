using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public class CorService : EntityService<Cor>, IEntityService<Cor>
    {
        public CorService(IRepository<Cor> repository) : base(repository)
        {
        }

        public override void Criar(string nome)
        {
            var cor = new Cor(nome);
            Criar(cor);
        }
    }
}