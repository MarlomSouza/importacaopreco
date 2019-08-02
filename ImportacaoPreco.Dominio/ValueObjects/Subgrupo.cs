using ImportacaoPreco.Dominio.Entities;
using ImportacaoPreco.Dominio.VO;

namespace ImportacaoPreco.Dominio.ValueObjects
{
    public class Subgrupo : VO<Subgrupo>
    {
        public string Nome { get; private set; }
        public Grupo Grupo { get; private set; }

        protected Subgrupo() { }
        public Subgrupo(string nome, Grupo grupo)
        {
            Nome = nome;
            Grupo = grupo;
        }

        public override bool EqualsCore(Subgrupo outro) => Nome == outro.Nome && Grupo == outro.Grupo;

    }
}