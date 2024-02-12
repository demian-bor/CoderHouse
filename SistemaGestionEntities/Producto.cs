using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Producto
    {
        // Declaracion de propiedades
        public int Id;
        public string Descripcion;
        public double Costo;
        public double PrecioVenta;
        public int Stock;
        public int IdUsuario;

        // Funcion de constructor con parametros
        public Producto(int Id, string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            this.Id = Id;
            this.Descripcion = Descripcion;
            this.Costo = Costo;
            this.PrecioVenta = PrecioVenta;
            this.Stock = Stock;
            this.IdUsuario = IdUsuario;
        }
    }
}
