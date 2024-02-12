using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        [HttpGet("listado")]
        public IEnumerable<Producto> GetAll()
        {
            return ProductoBussiness.GetProductos();
        }

        [HttpGet("ver/{id}")]
        public ActionResult<Producto> GetById(int id)
        {
            try
            {
                return ProductoBussiness.GetProducto(id).FirstOrDefault();
            }
            catch
            {
                return BadRequest("Id de producto inexistente");
            }
        }

        [HttpGet("crear")]
        public ActionResult<String> Create(string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
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

            // Crear el nuevo producto
            try
            {
                ProductoBussiness.NewProducto(Descripcion, Costo, PrecioVenta, Stock, IdUsuario);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        // api/editar?id=&nombre= etc
        [HttpGet("editar")]
        public ActionResult<String> Edit(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            // Verificar la existencia del producto
            try
            {
                ProductoBussiness.GetProducto(Id);
            }
            catch
            {
                return BadRequest("Id de producto inexistente");
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
            Producto EditedProduct = new Producto(Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario);

            // Realizar edicion
            try
            {
                ProductoBussiness.EditProducto(EditedProduct);
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
            // Verificar la existencia del producto
            try
            {
                ProductoBussiness.GetProducto(Id);
            }
            catch
            {
                return BadRequest("Id de producto inexistente");
            }

            // Realizar eliminacion
            try
            {
                ProductoBussiness.RemoveProducto(Id);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }

        }
    }
}
