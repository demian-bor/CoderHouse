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
    public class ProductoVendidoData
    {
        // Metodo para la obtencion de un producto vendido
        public static List<ProductoVendido> ObtenerProductoVendido(int IdProducto)
        {
            // Generacion de lista, string de conexion y consulta
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True;";
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido WHERE IdProducto=@IdProducto;";

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
                                var productovendido = new ProductoVendido(
                                        Convert.ToInt32(dr["Id"]),
                                        Convert.ToInt32(dr["IdProducto"]),
                                        Convert.ToInt32(dr["Stock"]),
                                        Convert.ToInt32(dr["IdVenta"])
                                    );
                                lista.Add(productovendido);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la obtencion de todos los productos vendidos
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            // Generacion de lista, string de conexion y consulta
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True;";
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido;";

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
                                var productovendido = new ProductoVendido(
                                        Convert.ToInt32(dr["Id"]),
                                        Convert.ToInt32(dr["IdProducto"]),
                                        Convert.ToInt32(dr["Stock"]),
                                        Convert.ToInt32(dr["IdVenta"])
                                    );
                                lista.Add(productovendido);
                            }
                        }
                    }
                }
                conexion.Close();
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la creacion de un producto vendido
        public static void CrearProductoVendido(ProductoVendido productovendido)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True;";
            var query = "INSERT INTO ProductoVendido (IdProducto, Stock, IdVenta) VALUES (@IdProducto, @Stock, @IdVenta)";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });
                }
                conexion.Close();
            }
        }

        // Metodo para la modificacion de un producto vendido
        public static void ModificarProductoVendido(ProductoVendido productovendido)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True;";
            var query = "UPDATE ProductoVendido SET IdProducto = @IdProducto, Stock = @Stock, IdVenta = @IdVenta WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productovendido.Id });
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });
                }
                conexion.Close();
            }
        }

        // Metodo para la eliminacion de un producto vendido
        public static void EliminarProductoVendido(ProductoVendido productovendido)
        {
            // Generacion de string de conexion y consulta
            string connectionString = "Server=.; DataBase=CoderHouse; Trusted_Connection=True;";
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = productovendido.Id });
                }
                conexion.Close();
            }
        }
    }
}
