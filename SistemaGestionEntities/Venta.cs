using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {
        // Declaracion de propiedades
        public int Id;
        public string Comentarios;
        public int IdUsuario;

        // Funcion de constructor con parametros
        public Venta(int Id, string Comentarios, int IdUsuario)
        {
            this.Id = Id;
            this.Comentarios = Comentarios;
            this.IdUsuario = IdUsuario;
        }
    }
}
