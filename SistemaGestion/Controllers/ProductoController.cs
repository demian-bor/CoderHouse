using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Linq;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        // Crear un producto
        [HttpPost()]
        public ActionResult<String> Create(string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(IdUsuario);
            if (users.Id == 0)
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

        // Modificar un producto
        [HttpPut()]
        public ActionResult<String> Edit(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            // Verificar la existencia del producto
            var prods = ProductoBussiness.GetProducto(Id);
            if (prods.Id == 0)
            {
                return BadRequest("Id de producto inexistente");
            }

            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(IdUsuario);
            if (users.Id == 0)
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

        // Eliminar un producto
        [HttpDelete("{idProducto}")]
        public ActionResult<String> Remove(int idProducto)
        {
            // Verificar la existencia del producto
            var prods = ProductoBussiness.GetProducto(idProducto);
            if (prods.Id == 0)
            {
                return BadRequest("Id de producto inexistente");
            }

            // Realizar eliminacion
            try
            {
                ProductoBussiness.RemoveProducto(idProducto);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        // Traer productos de un usuario
        [HttpGet("{idUsuario}")]
        public ActionResult<IEnumerable<Producto>> GetByUser(int idUsuario)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(idUsuario);
            if (users.Id == 0 )
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Buscar productos asociados y devolver
            var prods = ProductoBussiness.GetProductos().Where(Item => Item.IdUsuario == idUsuario);
            if (prods.Count() > 0 && prods.First().Id != 0)
            {
                return Ok(prods);
            }
            else
            {
                return NotFound("No se encontraron productos asociados al usuario");
            }
        }

        // No se solicita traer todos los productos
        //[HttpGet()]
        //public IEnumerable<Producto> GetAll()
        //{
        //    return ProductoBussiness.GetProductos();
        //}

        // No se solicita traer un producto por su id de producto
        //[HttpGet("{id}")]
        //public ActionResult<Producto> GetById(int id)
        //{
        //    try
        //    {
        //        return ProductoBussiness.GetProducto(id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto inexistente");
        //    }
        //}

    }
}
