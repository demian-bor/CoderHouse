using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        // Declaracion de propiedades
        public int Id;
        public string Nombre;
        public string Apellido;
        public string NombreUsuario;
        public string Contraseña;
        public string Mail;

        // Funcion de constructor con parametros
        public Usuario(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.NombreUsuario = NombreUsuario;
            this.Contraseña = Contraseña;
            this.Mail = Mail;
        }
    }
}
