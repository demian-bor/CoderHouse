using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        // Clase para obtener el listado de usuarios
        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        // Clase para obtener un usuario
        public static List<Usuario> GetUsuario(int Id)
        {
            return UsuarioData.ObtenerUsuario(Id);
        }

        // Clase para crear un usuario
        public static void NewUsuario(string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            UsuarioData.CrearUsuario(Nombre, Apellido, NombreUsuario, Contraseña, Mail);
        }

        // Clase para crear un usuario
        public static void EditUsuario(Usuario EditedUser)
        {
            UsuarioData.ModificarUsuario(EditedUser);
        }

        // Clase para crear un usuario
        public static void RemoveUsuario(int Id)
        {
            UsuarioData.EliminarUsuario(Id);
        }
    }
}

