using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Persona
    {
        public Persona()
        {
            DetalleCarritos = new HashSet<DetalleCarrito>();
            Reclamos = new HashSet<Reclamo>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdPersona { get; set; }
        public string Nombre { get; set; } = null!;
        public string APaterno { get; set; } = null!;
        public string AMaterno { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Telefono { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public string NumeroDoc { get; set; } = null!;

        public virtual ICollection<DetalleCarrito> DetalleCarritos { get; set; }
        public virtual ICollection<Reclamo> Reclamos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
