using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        [HttpGet("listado")]
        public IEnumerable<ProductoVendido> GetAll()
        {
            return ProductoVendidoBussiness.GetProductosVendidos();
        }

        [HttpGet("ver/{id}")]
        public ActionResult<ProductoVendido> GetById(int id)
        {
            try
            {
                return ProductoVendidoBussiness.GetProductoVendido(id).FirstOrDefault();
            }
            catch
            {
                return BadRequest("Id de producto vendido inexistente");
            }
        }

        [HttpGet("crear")]
        public ActionResult<String> Create(int IdProducto, int Stock, int IdVenta)
        {
            // Verificar que exista el producto
            try
            {
                ProductoBussiness.GetProducto(IdProducto);
            }
            catch
            {
                return BadRequest("Id de producto inexistente");
            }

            // Verificar que exista la venta
            try
            {
                VentaBussiness.GetVenta(IdVenta);
            }
            catch
            {
                return BadRequest("Id de venta inexistente");
            }

            // Crear el nuevo producto vendido
            try
            {
                ProductoVendidoBussiness.NewProductoVendido(IdProducto, Stock, IdVenta);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        [HttpGet("editar")]
        public ActionResult<String> Edit(int Id, int IdProducto, int Stock, int IdVenta)
        {
            // Verificar la existencia del producto vendido
            try
            {
                ProductoVendidoBussiness.GetProductoVendido(Id);
            }
            catch
            {
                return BadRequest("Id de producto vendido inexistente");
            }

            // Verificar que exista el producto
            try
            {
                ProductoBussiness.GetProducto(IdProducto);
            }
            catch
            {
                return BadRequest("Id de producto inexistente");
            }

            // Verificar que exista la venta
            try
            {
                VentaBussiness.GetVenta(IdVenta);
            }
            catch
            {
                return BadRequest("Id de venta inexistente");
            }

            // Generar el producto vendido editado
            ProductoVendido EditedProductoVendido = new ProductoVendido(Id, IdProducto, Stock, IdVenta);

            // Realizar edicion
            try
            {
                ProductoVendidoBussiness.EditProductoVendido(EditedProductoVendido);
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
            // Verificar la existencia del producto vendido
            try
            {
                ProductoVendidoBussiness.GetProductoVendido(Id);
            }
            catch
            {
                return BadRequest("Id de producto vendido inexistente");
            }

            // Realizar eliminacion
            try
            {
                ProductoVendidoBussiness.RemoveProductoVendido(Id);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }

        }
    }
}
