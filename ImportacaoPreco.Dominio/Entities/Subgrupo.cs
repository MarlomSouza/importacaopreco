namespace ImportacaoPreco.Dominio.Entities
{
    public class Subgrupo : Entity<Subgrupo>
    {
        public Grupo Grupo { get; private set; }

        protected Subgrupo() { }
        public Subgrupo(string nome, Grupo grupo)
        {
            Nome = nome;
            Grupo = grupo;
        }

    }
}