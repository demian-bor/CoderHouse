using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        // Declaracion de propiedades
        public int Id;
        public int IdProducto;
        public int Stock;
        public int IdVenta;

        // Funcion de constructor con parametros
        public ProductoVendido(int Id, int IdProducto, int Stock, int IdVenta)
        {
            this.Id = Id;
            this.IdProducto = IdProducto;
            this.Stock = Stock;
            this.IdVenta = IdVenta;
        }
    }
}
