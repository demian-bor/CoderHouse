using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;
using Microsoft.VisualBasic;

namespace SistemaGestionBussiness
{
    public class VentaBussiness
    {
        // Clase para obtener el listado de ventas
        public static List<Venta> GetVentas()
        {
            return VentaData.ListarVentas();
        }

        // Clase para obtener una venta
        public static Venta GetVenta(int Id)
        {
            return VentaData.ObtenerVenta(Id);
        }

        // Clase para crear una venta
        public static void NewVenta(string Comentarios, int IdUsuario)
        {
            VentaData.CrearVenta(Comentarios, IdUsuario);
        }

        // Clase para editar una venta
        public static void EditVenta(Venta EditedVenta)
        {
            VentaData.ModificarVenta(EditedVenta);
        }

        // Clase para eliminar una venta
        public static void RemoveVenta(int Id)
        {
            VentaData.EliminarVenta(Id);
        }
    }
}
