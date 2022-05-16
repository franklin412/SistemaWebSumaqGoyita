using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleCarritos = new HashSet<DetalleCarrito>();
        }

        public int IdProducto { get; set; }
        public string Nombre { get; set; } = null!;
        public int PrecioVenta { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioXmayor { get; set; }
        public int PrecioXmenor { get; set; }
        public int Stock { get; set; }
        public string? Base64 { get; set; }
        public bool? EstadoProducto { get; set; }
        public int IdCategoria { get; set; }
        public int IdMarca { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
        public virtual Marca IdMarcaNavigation { get; set; } = null!;
        public virtual ICollection<DetalleCarrito> DetalleCarritos { get; set; }
    }
}
