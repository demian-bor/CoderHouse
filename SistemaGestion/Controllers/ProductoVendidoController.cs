using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;
using System.Linq;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        // Traer un producto vendido por usuario
        [HttpGet("{idUsuario}")]
        public ActionResult<ProductoVendido> GetById(int idUsuario)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(idUsuario);
            if (users.Id == 0)
            {
                return BadRequest("Id de usuario inexistente");
            }

            // traer Id de ventas relacionadas a usuario
            // con ese listado de id de ventas traer el listado de productos vendidos por IdVenta

            // Buscar ventas asociadas
            var ventas = VentaBussiness.GetVentas().Where(Item => Item.IdUsuario == idUsuario);
            if (ventas.Count() > 0 && ventas.First().Id != 0)
            {
                // Buscar productos vendidos por ventas
                var prodvendido = ProductoVendidoBussiness.GetProductosVendidos().Where(Item => ventas.ToString().Contains(Item.IdVenta.ToString()));
                if (prodvendido.Count() > 0 && prodvendido.First().Id != 0)
                {
                    return Ok(prodvendido);
                }
                else
                {
                    return NotFound("No se encontraron productos vedidos del usuario");
                }
            }
            else
            {
                return NotFound("No se encontraron ventas asociadas al usuario");
            }
        }

        // NO SE SOLICITO TODO LO DE ABAJO
        //[HttpGet("listado")]
        //public IEnumerable<ProductoVendido> GetAll()
        //{
        //    return ProductoVendidoBussiness.GetProductosVendidos();
        //}

        //[HttpGet("ver/{id}")]
        //public ActionResult<ProductoVendido> GetById(int id)
        //{
        //    try
        //    {
        //        return ProductoVendidoBussiness.GetProductoVendido(id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto vendido inexistente");
        //    }
        //}

        //[HttpGet("crear")]
        //public ActionResult<String> Create(int IdProducto, int Stock, int IdVenta)
        //{
        //    // Verificar que exista el producto
        //    try
        //    {
        //        ProductoBussiness.GetProducto(IdProducto);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto inexistente");
        //    }

        //    // Verificar que exista la venta
        //    try
        //    {
        //        VentaBussiness.GetVenta(IdVenta);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de venta inexistente");
        //    }

        //    // Crear el nuevo producto vendido
        //    try
        //    {
        //        ProductoVendidoBussiness.NewProductoVendido(IdProducto, Stock, IdVenta);
        //        return Ok();
        //    }
        //    catch
        //    {
        //        return BadRequest("Ocurrio un error");
        //    }
        //}

        //[HttpGet("editar")]
        //public ActionResult<String> Edit(int Id, int IdProducto, int Stock, int IdVenta)
        //{
        //    // Verificar la existencia del producto vendido
        //    try
        //    {
        //        ProductoVendidoBussiness.GetProductoVendido(Id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto vendido inexistente");
        //    }

        //    // Verificar que exista el producto
        //    try
        //    {
        //        ProductoBussiness.GetProducto(IdProducto);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto inexistente");
        //    }

        //    // Verificar que exista la venta
        //    try
        //    {
        //        VentaBussiness.GetVenta(IdVenta);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de venta inexistente");
        //    }

        //    // Generar el producto vendido editado
        //    ProductoVendido EditedProductoVendido = new ProductoVendido(Id, IdProducto, Stock, IdVenta);

        //    // Realizar edicion
        //    try
        //    {
        //        ProductoVendidoBussiness.EditProductoVendido(EditedProductoVendido);
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
        //    // Verificar la existencia del producto vendido
        //    try
        //    {
        //        ProductoVendidoBussiness.GetProductoVendido(Id);
        //    }
        //    catch
        //    {
        //        return BadRequest("Id de producto vendido inexistente");
        //    }

        //    // Realizar eliminacion
        //    try
        //    {
        //        ProductoVendidoBussiness.RemoveProductoVendido(Id);
        //        return Ok();
        //    }
        //    catch
        //    {
        //        return BadRequest("Ocurrio un error");
        //    }

        //}
    }
}
