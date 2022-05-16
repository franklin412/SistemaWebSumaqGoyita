using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Facturas = new HashSet<Factura>();
        }

        public int IdEmpresa { get; set; }
        public string NomEmpresa { get; set; } = null!;
        public int Ruc { get; set; }
        public string Detalle1 { get; set; } = null!;
        public string Detalle2 { get; set; } = null!;
        public string Detalle3 { get; set; } = null!;

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
