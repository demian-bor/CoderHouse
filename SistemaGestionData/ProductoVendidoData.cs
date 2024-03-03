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
        public static ProductoVendido ObtenerProductoVendido(int IdProducto)
        {
            // Generacion de productovendido y consulta
            ProductoVendido productovendido = new ProductoVendido();
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido WHERE IdProducto=@IdProducto;";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
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
                                productovendido.Id = Convert.ToInt32(dr["Id"]);
                                productovendido.IdProducto = Convert.ToInt32(dr["IdProducto"]);
                                productovendido.Stock = Convert.ToInt32(dr["Stock"]);
                                productovendido.IdVenta = Convert.ToInt32(dr["IdVenta"]);
                            }
                        }
                    }
                }
            }
            // Devolver el productovendido generado
            return productovendido;
        }

        // Metodo para la obtencion de todos los productos vendidos
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            // Generacion de lista y consulta
            List<ProductoVendido> lista = new List<ProductoVendido>();
            var query = "SELECT Id, IdProducto, Stock, IdVenta FROM ProductoVendido;";

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
            }
            // Devolver la lista generada
            return lista;
        }

        // Metodo para la creacion de un producto vendido
        public static void CrearProductoVendido(int IdProducto, int Stock, int IdVenta)
        {
            // Generacion de consulta
            var query = "INSERT INTO ProductoVendido (IdProducto, Stock, IdVenta) VALUES (@IdProducto, @Stock, @IdVenta)";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = IdVenta });
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Metodo para la modificacion de un producto vendido
        public static void ModificarProductoVendido(ProductoVendido EditedProductoVendido)
        {
            // Generacion de consulta
            var query = "UPDATE ProductoVendido SET IdProducto = @IdProducto, Stock = @Stock, IdVenta = @IdVenta WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = EditedProductoVendido.Id });
                    comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = EditedProductoVendido.IdProducto });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = EditedProductoVendido.Stock });
                    comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = EditedProductoVendido.IdVenta });
                    comando.ExecuteNonQuery();
                }
            }
        }

        // Metodo para la eliminacion de un producto vendido
        public static void EliminarProductoVendido(int Id)
        {
            // Generacion de consulta
            var query = "DELETE FROM ProductoVendido WHERE Id = @Id";

            // Conexion a la BD
            using (SqlConnection conexion = new DB_Connection().NewConnection())
            {
                conexion.Open();
                // Generacion de consulta a BD
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Id });
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
