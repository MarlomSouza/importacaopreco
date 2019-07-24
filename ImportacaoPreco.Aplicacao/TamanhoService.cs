using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;

namespace ImportacaoPreco.Aplicacao
{
    public class TamanhoService : EntityService<Tamanho>, IEntityService<Tamanho>
    {
        public TamanhoService(IRepository<Tamanho> repository) : base(repository) { }

        public override void Criar(string nome)
        {
            var tamanho = new Tamanho(nome);
            Criar(tamanho);
        }
    }
}