using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdPedido { get; set; }
        public DateTime? RegistroFecha { get; set; }
        public int IdDetalleCarro { get; set; }

        public virtual DetalleCarrito IdDetalleCarroNavigation { get; set; } = null!;
        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
