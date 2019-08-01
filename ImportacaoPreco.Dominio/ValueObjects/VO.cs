namespace ImportacaoPreco.Dominio.VO
{
    public abstract class VO<T>
    {
        public abstract bool EqualsCore(T outro);
    }
}