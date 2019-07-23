namespace ImportacaoPreco.Dominio.Entities
{
    public class Subgrupo : Entity<Subgrupo>
    {
        public readonly string Nome;
        public readonly Grupo Grupo;
        public Subgrupo(string nome, Grupo grupo)
        {
            Nome = nome;
            Grupo = grupo;

        }

    }
}