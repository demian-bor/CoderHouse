using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using SistemaGestionData;
using System.Diagnostics.Contracts;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("listado")]
        public IEnumerable<Usuario> GetAll()
        {
            return UsuarioBussiness.GetUsuarios();
        }

        [HttpGet("ver/{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            try
            {
                return UsuarioBussiness.GetUsuario(id).FirstOrDefault();
            }
            catch
            {
                return BadRequest("Id de usuario inexistente");
            }
        }

        // api/Usuario/crear?Nombre=&Apellido=&NombreUsuario=&Contrase%C3%B1a=&Mail=
        [HttpGet("crear")]
        public ActionResult<String> Create(string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            try
            {
                UsuarioBussiness.NewUsuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        // api/Usuario/editar?Id=&Nombre=&Apellido=&NombreUsuario=&Contrase%C3%B1a=&Mail=
        [HttpGet("editar")]
        public ActionResult<String> Edit(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            // Verificar la existencia del usuario
            try
            {
                UsuarioBussiness.GetUsuario(Id);
            }
            catch
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Generar el usuario editado
            Usuario EditedUser = new Usuario(Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail);

            // Realizar edicion
            try
            {
                UsuarioBussiness.EditUsuario(EditedUser);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        [HttpGet("eliminar/{Id}")]
        public ActionResult<String> Remove(int Id)
        {
            // Verificar la existencia del usuario
            try
            {
                UsuarioBussiness.GetUsuario(Id);
            }
            catch
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Realizar eliminacion
            try
            {
                UsuarioBussiness.RemoveUsuario(Id);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
            
        }
    }
}
