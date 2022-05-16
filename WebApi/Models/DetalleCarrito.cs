using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class DetalleCarrito
    {
        public DetalleCarrito()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdDetalleCarro { get; set; }
        public bool? EstadoCarrito { get; set; }
        public int IdProducto { get; set; }
        public int IdPersona { get; set; }

        public virtual Producto IdPersona1 { get; set; } = null!;
        public virtual Persona IdPersonaNavigation { get; set; } = null!;
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
