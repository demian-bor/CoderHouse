using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        // Obtener ventas de un usuario
        [HttpGet("{idUsuario}")]
        public ActionResult<IEnumerable<Venta>> GetAll(int idUsuario)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(idUsuario);
            if (users.Id == 0)
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Buscar ventas asociadas y devolver
            var ventas = VentaBussiness.GetVentas().Where(Item => Item.IdUsuario == idUsuario);
            if (ventas.Count() > 0 && ventas.First().Id != 0)
            {
                return Ok(ventas);
            }
            else
            {
                return NotFound("No se encontraron ventas asociadas al usuario");
            }
        }

        // Crear una venta
        [HttpPost("{idUsuario}")]
        public ActionResult Create(List<Producto> NewVentas)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(NewVentas[0].IdUsuario);
            if (users.Id == 0)
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Cargar venta
            int VentaId;
            try
            {
                VentaBussiness.NewVenta("Nueva venta", NewVentas[0].IdUsuario);
                VentaId = VentaBussiness.GetVentas().Last().Id;
            }
            catch
            {
                return BadRequest("Ocurrio un error cargando Venta");
            }

            // Cargar productos vendidos
            foreach (Producto item in NewVentas)
            {
                // Generar venta
                try
                {
                    ProductoVendidoBussiness.NewProductoVendido(item.Id, item.Stock, VentaId);
                    return Ok();
                }
                catch
                {
                    return BadRequest("Ocurrio un error cargando Producto Vendido");
                }
            }
            return BadRequest("Ocurrio un error");

        }


        // Hacia abajo no fue solicitado
        //[HttpGet("ver/{id}")]
        //public ActionResult<Venta> GetById(int id)
        //{
        //    try
        //    {
        //        return VentaBussiness.GetVenta(id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de venta inexistente");
        //    }
        //}

        //[HttpGet("editar")]
        //public ActionResult<String> Edit(int Id, string Comentarios, int IdUsuario)
        //{
        //    // Verificar la existencia de la venta
        //    try
        //    {
        //        VentaBussiness.GetVenta(Id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de venta inexistente");
        //    }

        //    // Verificar la existencia del usuario
        //    try
        //    {
        //        UsuarioBussiness.GetUsuario(IdUsuario);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de usuario inexistente");
        //    }

        //    // Generar el usuario editado
        //    Venta EditedVenta = new Venta(Id, Comentarios, IdUsuario);

        //    // Realizar edicion
        //    try
        //    {
        //        VentaBussiness.EditVenta(EditedVenta);
        //        return Ok();
        //    }
        //    catch
        //    {
        //        return BadRequest("Ocurrio un error");
        //    }
        //}

        //[HttpGet("eliminar/{Id}")]
        //public ActionResult<String> Remove(int Id)
        //{
        //    // Verificar la existencia de la venta
        //    try
        //    {
        //        VentaBussiness.GetVenta(Id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de venta inexistente");
        //    }

        //    // Realizar eliminacion
        //    try
        //    {
        //        VentaBussiness.RemoveVenta(Id);
        //        return Ok();
        //    }
        //    catch
        //    {
        //        return BadRequest("Ocurrio un error");
        //    }

        //}
    }
}
