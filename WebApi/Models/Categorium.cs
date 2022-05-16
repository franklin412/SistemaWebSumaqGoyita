using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdCategoria { get; set; }
        public string NombreCat { get; set; } = null!;
        public bool? EstadoCategoria { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
