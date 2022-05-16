using System;
using System.Collections.Generic;

namespace WebApi.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string LoginUsuario { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdPersona { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
