using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        // Declaracion de propiedades privadas
        private int _Id;
        private string _Descripcion;
        private double _Costo;
        private double _PrecioVenta;
        private int _Stock;
        private int _IdUsuario;

        // Declaracion de metodos de acceso publicos
        public int Id { get => _Id; set => _Id = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public double Costo { get => _Costo; set => _Costo = value; }
        public double PrecioVenta { get => _PrecioVenta; set => _PrecioVenta = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }


        // Funcion de constructor con parametros
        public Producto(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            _Id = Id;
            _Descripcion = Descripcion;
            _Costo = Costo;
            _PrecioVenta = PrecioVenta;
            _Stock = Stock;
            _IdUsuario = IdUsuario;
        }

        // Funcion de constructor sin parametros
        public Producto()
        {
            _Id = 0;
            _Descripcion = string.Empty;
            _Costo = 0;
            _PrecioVenta = 0;
            _Stock = 0;
            _IdUsuario = 0;
        }
    }
}
