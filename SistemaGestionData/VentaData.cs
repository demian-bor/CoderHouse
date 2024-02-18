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
    public class VentaData
    {
        // Metodo para la obtencion de una venta
        public static Venta ObtenerVenta(int IdVenta)
        {
            // Generacion de venta y consulta
            Venta venta = new Venta();
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@IdVenta;";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregado de parametro a la consulta
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdVenta";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdVenta;
                    comando.Parameters.Add(parametro);

                    // Consulta a BD
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        // Continuar si la consulta nos devolvio datos
                        if (dr.HasRows)
                        {
                            // Recorrer el resultado de la consulta almacenando en venta
                            while (dr.Read())
                            {
                                venta.Id = Convert.ToInt32(dr["Id"]);
                                venta.Comentarios = dr["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                            }
                        }
                    }
                }
            }
            // Devolver la venta generada
            return venta;
        }

        // Metodo para la obtencion de todas las ventas
        public static List<Venta> ListarVentas()
        {
            // Generacion de lista y consulta
            List<Venta> lista = new List<Venta>();
            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta;";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
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
                                var venta = new Venta(
                                        Convert.ToInt32(dr["Id"]),
                                        dr["Comentarios"].ToString(),
                                        Convert.ToInt32(dr["IdUsuario"])
                                    );
                                lista.Add(venta);
                            }
                        }
                    }
                }
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la creacion de una venta
        public static void CrearVenta(string Comentarios, int IdUsuario)
        {
            // Generacion de consulta
            var query = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES (@Comentarios, @IdUsuario)";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = IdUsuario });
                }
            }
        }

        // Metodo para la modificacion de una venta
        public static void ModificarVenta(Venta venta)
        {
            // Generacion de consulta
            var query = "UPDATE Venta SET Comentarios = @Comentarios, IdUsuario = @IdUsuario WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                }
            }
        }

        // Metodo para la eliminacion de una venta
        public static void EliminarVenta(int Id)
        {
            // Generacion de consulta
            var query = "DELETE FROM Venta WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
                }
            }
        }
    }
}
