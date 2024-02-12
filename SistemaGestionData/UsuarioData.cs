using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        // Metodo para la obtencion de un usuario
        public static List<Usuario> ObtenerUsuario(int IdUsuario)
        {
            // Generacion de lista, string de conexion y consulta
            List<Usuario> lista = new List<Usuario>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, \"Contrase a\", Mail FROM Usuario WHERE Id=@IdUsuario;";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregado de parametro a la consulta
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdUsuario;
                    comando.Parameters.Add(parametro);

                    // Consulta a BD
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        // Continuar si la consulta nos devolvio datos
                        if (dr.HasRows)
                        {
                            // Recorrer el resultado de la consulta almacenando en lista
                            while (dr.Read())
                            {
                                var usuario = new Usuario(
                                        Convert.ToInt32(dr["Id"]),
                                        dr["Nombre"].ToString(),
                                        dr["Apellido"].ToString(),
                                        dr["NombreUsuario"].ToString(),
                                        dr["Contrase a"].ToString(),
                                        dr["Mail"].ToString()
                                    );
                                lista.Add(usuario);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la obtencion de todos los usuarios
        public static List<Usuario> ListarUsuarios()
        {
            // Generacion de lista, string de conexion y consulta
            List<Usuario> lista = new List<Usuario>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, \"Contrase a\", Mail FROM Usuario;";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Consulta a BD
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        // Continuar si la consulta nos devolvio datos
                        if (dr.HasRows)
                        {
                            // Recorrer el resultado de la consulta almacenando en lista
                            while (dr.Read())
                            {
                                var usuario = new Usuario(
                                        Convert.ToInt32(dr["Id"]),
                                        dr["Nombre"].ToString(),
                                        dr["Apellido"].ToString(),
                                        dr["NombreUsuario"].ToString(),
                                        dr["Contrase a"].ToString(),
                                        dr["Mail"].ToString()
                                    );
                                lista.Add(usuario);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la creacion de un usuario
        public static void CrearUsuario(string Nombre, string Apellido, string NombreUsuario, string Contraseña, string Mail)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, \"Contrase a\", Mail) VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = Mail });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        // Metodo para la modificacion de un usuario
        public static void ModificarUsuario(Usuario usuario)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, \"Contrase a\" = @Contraseña, Mail = @Mail WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        // Metodo para la eliminacion de un usuario
        public static void EliminarUsuario(int Id)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "DELETE FROM Usuario WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}
