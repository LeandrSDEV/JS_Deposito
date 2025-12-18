using JSDeposito.Application.Interfaces;
using JSDeposito.Domain.Entities;
using JSDeposito.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace JSDeposito.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _context.Produtos
                .Where(p => p.Ativo)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
