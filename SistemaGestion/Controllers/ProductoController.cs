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
        public ActionResult Create(Producto NewProduct)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(NewProduct.IdUsuario);
            if (users.Id == 0)
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Crear el nuevo producto
            try
            {
                ProductoBussiness.NewProducto(NewProduct.Descripcion, NewProduct.Costo, NewProduct.PrecioVenta, NewProduct.Stock, NewProduct.IdUsuario);
                return Ok();
            }
            catch
            {
                return BadRequest("Ocurrio un error");
            }
        }

        // Modificar un producto
        [HttpPut()]
        public ActionResult Edit(Producto EditedProd)
        {
            // Verificar la existencia del producto
            var prods = ProductoBussiness.GetProducto(EditedProd.Id);
            if (prods.Id == 0)
            {
                return BadRequest("Id de producto inexistente");
            }

            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(EditedProd.IdUsuario);
            if (users.Id == 0)
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Generar el usuario editado
            Producto EditedProduct = new Producto(EditedProd.Id, EditedProd.Descripcion, EditedProd.Costo, EditedProd.PrecioVenta, EditedProd.Stock, EditedProd.IdUsuario);

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
        public ActionResult Remove(int idProducto)
        {
            // Verificar la existencia del producto
            var prods = ProductoBussiness.GetProducto(idProducto);
            if (prods.Id == 0)
            {
                return BadRequest("Id de producto inexistente");
            }

            // Obtener todos los productos vedidos relacionados
            IEnumerable<ProductoVendido> Prod_Vendidos = ProductoVendidoBussiness.GetProductosVendidos().Where(Item => Item.IdProducto == idProducto);

            // Realizar eliminacion
            try
            {
                foreach (ProductoVendido pvendido in Prod_Vendidos)
                {
                    ProductoVendidoBussiness.RemoveProductoVendido(pvendido.Id);
                }
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
        // public ActionResult<IEnumerable<Producto>> GetByUser(int idUsuario)
        public ActionResult<IEnumerable<Producto>> GetByUser(int idUsuario)
        {
            // Corroborar existencia de usuario
            var users = UsuarioBussiness.GetUsuario(idUsuario);
            if (users.Id == 0 )
            {
                return BadRequest("Id de usuario inexistente");
            }

            // Buscar productos asociados y devolver
            IEnumerable<Producto> prods = ProductoBussiness.GetProductos().Where(Item => Item.IdUsuario == idUsuario);
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
