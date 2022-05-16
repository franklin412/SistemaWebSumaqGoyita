using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioConsultasController : Controller
    {
        [HttpPost]
        [Route("RegistrarUsuario")]
        public Persona RegistrarPersonaUsuario(string NombreCliente, string aPaterno, string aMaterno,
            string direccion,
            string razonSocial,
            string email,
            int telefono,
            string numeroDoc,
            string LoginName,
            string contraseña,
            string docIdentidadType)
        {
            var objectPersona = Usuario.RegistrarPersona(NombreCliente, aPaterno, aMaterno, direccion, razonSocial, email, telefono, numeroDoc, docIdentidadType);
            Usuario.RegistrarUsuario(LoginName, contraseña, objectPersona.IdPersona);
            return objectPersona;
        }
    }
}
