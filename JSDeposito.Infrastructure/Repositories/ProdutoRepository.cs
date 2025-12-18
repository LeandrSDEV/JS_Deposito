using JSDeposito.Application.Interfaces;
using JSDeposito.Domain.Entities;
using JSDeposito.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSDeposito.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public Task<IEnumerable<Produto>> ObterTodos()
            => _context.Produtos.Where(p => p.Ativo).ToListAsync();
    }

}
