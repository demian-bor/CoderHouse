using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class ProductoVendido
    {
        // Declaracion de propiedades privadas
        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        // Declaracion de metodos de acceso publicos
        public int Id { get => _Id; set => _Id = value; }
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public int IdVenta { get => _IdVenta; set => _IdVenta = value; }

        // Funcion de constructor con parametros
        public ProductoVendido(int Id, int IdProducto, int Stock, int IdVenta)
        {
            _Id = Id;
            _IdProducto = IdProducto;
            _Stock = Stock;
            _IdVenta = IdVenta;
        }

        // Funcion de constructor sin parametros
        public ProductoVendido()
        {
            _Id = 0;
            _IdProducto = 0;
            _Stock = 0;
            _IdVenta = 0;
        }
    }
}
