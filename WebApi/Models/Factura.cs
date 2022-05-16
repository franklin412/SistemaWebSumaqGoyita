using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int IdPedido { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
        public virtual Pedido IdPedidoNavigation { get; set; } = null!;
    }
}
