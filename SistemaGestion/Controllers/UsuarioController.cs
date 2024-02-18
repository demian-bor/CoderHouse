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
        // Iniciar sesion
        [HttpGet("{nombreUsuario}/{contraseña}")]
        public ActionResult<Usuario> UserLoginCheck(string nombreUsuario, string contraseña)
        {
            // Buscar usuario y devolver
            var users = UsuarioBussiness.GetUsuarios().Where(Item => Item.NombreUsuario == nombreUsuario);
            if (users.Count() > 0 && users.First().Id != 0)
            {
                if (users.FirstOrDefault().Contraseña == contraseña)
                {
                    return Ok(users);
                }
                else
                {
                    return BadRequest("Acceso denegado");
                }
            }
            else
            {
                return NotFound("Usuario inexistente");
            }
        }

        // Crear un usuario
        [HttpPost()]
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

        // Modificar un usuario
        [HttpPut()]
        public ActionResult<String> Edit(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(Id);
            if (users.Id == 0)
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

        // Treer un usuario
        [HttpGet("{nombreUsuario}")]
        public ActionResult<Usuario> GetById(string nombreUsuario)
        {
            // Buscar usuario y devolver
            var users = UsuarioBussiness.GetUsuarios().Where(Item => Item.NombreUsuario == nombreUsuario);
            if (users.Count() > 0 && users.First().Id != 0)
            {
                return Ok(users);
            }
            else
            {
                return NotFound("Usuario inexistente");
            }
        }

        // Eliminar un usuario
        [HttpDelete("{Id}")]
        public ActionResult<String> Remove(int Id)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(Id);
            if (users.Id == 0)
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

        // Listar usuarios (no solicitado)
        // [HttpGet("listado")]
        // public IEnumerable<Usuario> GetAll()
        // {
        //    return UsuarioBussiness.GetUsuarios();
        // }
    }
}
