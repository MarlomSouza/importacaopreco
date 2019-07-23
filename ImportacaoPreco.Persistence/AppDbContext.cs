using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImportacaoPreco.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cor> Cores { get; set; }
        public DbSet<Tamanho> Tamanhos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Subgrupo> Subgrupos { get; set; }


    }
}