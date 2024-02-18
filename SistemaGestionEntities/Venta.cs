using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class Venta
    {
        // Declaracion de propiedades privadas
        private int _Id;
        private string _Comentarios;
        private int _IdUsuario;

        // Declaracion de metodos de acceso publicos
        public int Id { get => _Id; set => _Id = value; }
        public string Comentarios { get => _Comentarios; set => _Comentarios = value; }
        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }

        // Funcion de constructor con parametros
        public Venta(int Id, string Comentarios, int IdUsuario)
        {
            _Id = Id;
            _Comentarios = Comentarios;
            _IdUsuario = IdUsuario;
        }

        // Funcion de constructor sin parametros
        public Venta()
        {
            _Id = 0;
            _Comentarios = string.Empty;
            _IdUsuario = 0;
        }
    }
}
