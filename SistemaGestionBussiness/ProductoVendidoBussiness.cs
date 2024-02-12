using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class ProductoVendidoBussiness
    {
        // Clase para obtener el listado de productos vendidos
        public static List<ProductoVendido> GetProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        // Clase para obtener un producto vendido
        public static List<ProductoVendido> GetProductoVendido(int Id)
        {
            return ProductoVendidoData.ObtenerProductoVendido(Id);
        }

        // Clase para crear un producto vendido
        public static void NewProductoVendido(int IdProducto, int Stock, int IdVenta)
        {
            ProductoVendidoData.CrearProductoVendido(IdProducto, Stock, IdVenta);
        }

        // Clase para editar un producto vendido
        public static void EditProductoVendido(ProductoVendido EditedProductoVendido)
        {
            ProductoVendidoData.ModificarProductoVendido(EditedProductoVendido);
        }

        // Clase para eliminar un producto vendido
        public static void RemoveProductoVendido(int Id)
        {
            ProductoVendidoData.EliminarProductoVendido(Id);
        }
    }
}
