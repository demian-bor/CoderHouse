using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        [HttpGet("listado")]
        public IEnumerable<Venta> GetAll()
        {
            return VentaBussiness.GetVentas();
        }

        [HttpGet("ver/{id}")]
        public ActionResult<Venta> GetById(int id)
        {
            try
            {
                return VentaBussiness.GetVenta(id).FirstOrDefault();
            }
            catch
            {
                return BadRequest("Id de venta inexistente");
            }
        }

        [HttpGet("crear")]
        public ActionResult<String> Create(string Comentarios, int IdUsuario)
        {
            // Verificar que exista el usuario
            try
            {
                UsuarioBussiness.GetUsuario(IdUsuario);
            }
            catch
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Crear la nueva venta
            try
            {
                VentaBussiness.NewVenta(Comentarios, IdUsuario);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        [HttpGet("editar")]
        public ActionResult<String> Edit(int Id, string Comentarios, int IdUsuario)
        {
            // Verificar la existencia de la venta
            try
            {
                VentaBussiness.GetVenta(Id);
            }
            catch
            {
                return BadRequest("Id de venta inexistente");
            }

            // Verificar la existencia del usuario
            try
            {
                UsuarioBussiness.GetUsuario(IdUsuario);
            }
            catch
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Generar el usuario editado
            Venta EditedVenta = new Venta(Id, Comentarios, IdUsuario);

            // Realizar edicion
            try
            {
                VentaBussiness.EditVenta(EditedVenta);
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
            // Verificar la existencia de la venta
            try
            {
                VentaBussiness.GetVenta(Id);
            }
            catch
            {
                return BadRequest("Id de venta inexistente");
            }

            // Realizar eliminacion
            try
            {
                VentaBussiness.RemoveVenta(Id);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }

        }
    }
}
