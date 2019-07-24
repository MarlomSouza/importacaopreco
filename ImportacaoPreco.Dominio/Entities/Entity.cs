namespace ImportacaoPreco.Dominio.Entities
{
    public abstract class Entity<T>
    {
        public int Id { get; set; }
        public string Nome { get; protected set; }
    }
}