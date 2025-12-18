using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSDeposito.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }
        public bool Ativo { get; private set; }
    }

}
