using JSDeposito.Domain.Emuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSDeposito.Domain.Entities
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal Total { get; private set; }
        public PedidoStatus Status { get; private set; }
    }

}
