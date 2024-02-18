using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Usuario
    {
        // Declaracion de propiedades privadas
        private int _Id;
        private string _Nombre;
        private string _Apellido;
        private string _NombreUsuario;
        private string _Contraseña;
        private string _Mail;

        // Declaracion de metodos de acceso publicos
        public int Id { get => _Id; set => _Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Mail { get => _Mail; set => _Mail = value; }

        // Funcion de constructor con parametros
        public Usuario(int Id, string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            _Id = Id;
            _Nombre = Nombre;
            _Apellido = Apellido;
            _NombreUsuario = NombreUsuario;
            _Contraseña = Contraseña;
            _Mail = Mail;
        }

        // Funcion de constructor sin parametros
        public Usuario()
        {
            _Id = 0;
            _Nombre = string.Empty;
            _Apellido = string.Empty;
            _NombreUsuario = string.Empty;
            _Contraseña = string.Empty;
            _Mail = string.Empty;
        }
    }
}
