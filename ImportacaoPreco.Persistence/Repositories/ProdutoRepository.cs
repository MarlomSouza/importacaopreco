using System.Linq;
using ImportacaoPreco.Dominio.Base;
using ImportacaoPreco.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImportacaoPreco.Persistence.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IRepository<Produto>
    {
        public ProdutoRepository(AppDbContext context) : base(context) { }

        public override Produto ObterPorId(int id) =>
        _context.Produtos.Include(p => p.Tamanhos).Include(p => p.Cores).Include(p => p.Subgrupo.Grupo).Single(p => p.Id == id);
    }
}