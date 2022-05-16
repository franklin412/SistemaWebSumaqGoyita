namespace WebApi.Models
{
    public partial class Usuario
    {
        public static Persona RegistrarPersona(string NombreCliente, string aPaterno, string aMaterno, string direccion, string razonSocial, string email, int telefono, string numeroDoc, string docIdentidadType)
        {
            GoyitaContext db = new GoyitaContext();
            Persona persona = new Persona();
            persona.Nombre = NombreCliente;
            persona.APaterno = aPaterno;
            persona.AMaterno = aMaterno;
            persona.Direccion = direccion;
            persona.RazonSocial = razonSocial;
            persona.Email = email;
            persona.Telefono = telefono;
            persona.NumeroDoc = numeroDoc;
            persona.DocIdentidad = docIdentidadType;
            db.Personas.Add(persona);
            db.SaveChanges();
            return persona;

        }

        public static Usuario RegistrarUsuario(string LoginName, string contraseña, int IdPersona)
        {
            GoyitaContext db = new GoyitaContext();
            Usuario usuario = new Usuario();
            usuario.LoginUsuario = LoginName;
            usuario.Password = contraseña;
            usuario.IdPersona = IdPersona;
            db.Usuarios.Add(usuario);
            db.SaveChanges();
            return usuario;
        }
    }
}
