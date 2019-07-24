namespace ImportacaoPreco.Dominio.Entities
{
    public class Subgrupo : Entity<Subgrupo>
    {
        public readonly string Nome;
        public readonly Grupo Grupo;

        protected Subgrupo() { }
        public Subgrupo(string nome, Grupo grupo)
        {
            Nome = nome;
            Grupo = grupo;
        }

    }
}