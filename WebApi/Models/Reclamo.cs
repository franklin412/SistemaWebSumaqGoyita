using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Reclamo
    {
        public int IdReclamo { get; set; }
        public string Descripcion { get; set; } = null!;
        public string TipoMensaje { get; set; } = null!;
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
