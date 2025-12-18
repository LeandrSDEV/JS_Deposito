using JSDeposito.Application.DTOs;
using JSDeposito.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSDeposito.Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _repo;

        public ProdutoService(IProdutoRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<ProdutoDto>> Listar()
        {
            var produtos = await _repo.ObterTodos();
            return produtos.Select(p => new ProdutoDto { });
        }
    }
}
