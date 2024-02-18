using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoBussiness
    {
        // Clase para obtener el listado de productos
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }

        // Clase para obtener un productos
        public static Producto GetProducto(int Id)
        {
            return ProductoData.ObtenerProducto(Id);
        }

        // Clase para crear un productos
        public static void NewProducto(string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            ProductoData.CrearProducto(Descripcion, Costo, PrecioVenta, Stock, IdUsuario);
        }

        // Clase para editar un productos
        public static void EditProducto(Producto EditedProducto)
        {
            ProductoData.ModificarProducto(EditedProducto);
        }

        // Clase para eliminar un productos
        public static void RemoveProducto(int Id)
        {
            ProductoData.EliminarProducto(Id);
        }
    }
}
