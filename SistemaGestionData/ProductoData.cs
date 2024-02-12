using Microsoft.Data.SqlClient;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoData
    {
        // Metodo para la obtencion de un producto
        public static List<Producto> ObtenerProducto(int IdProducto)
        {
            // Generacion de lista, string de conexion y consulta
            List<Producto> lista = new List<Producto>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto WHERE Id=@IdProducto;";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregado de parametro a la consulta
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdProducto";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IdProducto;
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
                                var producto = new Producto(
                                        Convert.ToInt32(dr["Id"]),
                                        dr["Descripciones"].ToString(),
                                        Convert.ToDouble(dr["Costo"]),
                                        Convert.ToDouble(dr["PrecioVenta"]),
                                        Convert.ToInt32(dr["Stock"]),
                                        Convert.ToInt32(dr["IdUsuario"])
                                    );
                                lista.Add(producto);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la obtencion de todos los productos
        public static List<Producto> ListarProductos()
        {
            // Generacion de lista, string de conexion y consulta
            List<Producto> lista = new List<Producto>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto;";

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
                                var producto = new Producto(
                                        Convert.ToInt32(dr["Id"]),
                                        dr["Descripciones"].ToString(),
                                        Convert.ToDouble(dr["Costo"]),
                                        Convert.ToDouble(dr["PrecioVenta"]),
                                        Convert.ToInt32(dr["Stock"]),
                                        Convert.ToInt32(dr["IdUsuario"])
                                    );
                                lista.Add(producto);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la creacion de un producto
        public static void CrearProducto(string Descripcion, double Costo, double PrecioVenta, int Stock, int IdUsuario)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "INSERT INTO Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES (@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = IdUsuario });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        // Metodo para la modificacion de un producto
        public static void ModificarProducto(Producto producto)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "UPDATE Producto SET Descripciones = @Descripcion, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        // Metodo para la eliminacion de un producto
        public static void EliminarProducto(int Id)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True; TrustServerCertificate=True";
            var query = "DELETE FROM Producto WHERE Id = @Id";

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
