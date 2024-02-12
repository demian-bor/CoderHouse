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
        // Clase para obtener el listado de usuarios
        public static List<Producto> GetProductos()
        {
            return ProductoData.ListarProductos();
        }

        // Clase para obtener un usuario
        public static List<Producto> GetProducto(int Id)
        {
            return ProductoData.ObtenerProducto(Id);
        }

        // Clase para crear un usuario
        public static void NewProducto(string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            ProductoData.CrearProducto(Descripcion, Costo, PrecioVenta, Stock, IdUsuario);
        }

        // Clase para crear un usuario
        public static void EditProducto(Producto EditedProducto)
        {
            ProductoData.ModificarProducto(EditedProducto);
        }

        // Clase para crear un usuario
        public static void RemoveProducto(int Id)
        {
            ProductoData.EliminarProducto(Id);
        }
    }
}
