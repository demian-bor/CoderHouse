using SistemaGestionBussiness;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI.DialogProducto
{
    public partial class DialogEditarProducto : Form
    {
        public DialogEditarProducto()
        {
            InitializeComponent();
        }

        private void CrearProducto_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text != String.Empty)
            {
                Producto EditedProducto = new Producto(
                        ProductosForm.ID_Producto_Busqueda,
                        Descripcion.Text,
                        ((double)Costo.Value),
                        ((double)PrecioVenta.Value),
                        ((int)Stock.Value),
                        ((int)IdUsuario.Value)
                    );
                ProductoBussiness.EditProducto(
                        EditedProducto
                    );
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta informacion!", "Error");
            }
        }

        private void DialogEditarProducto_Load(object sender, EventArgs e)
        {
            // Obtener el listado de Productos
            var lista = ProductoBussiness.GetProductos();

            // Setear como minimo y maximo del rango
            IdUsuario.Minimum = lista.FirstOrDefault().Id;
            IdUsuario.Maximum = lista.LastOrDefault().Id;

            // Obtener el listado de usuarios
            List<Producto> EditProduct = ProductoBussiness.GetProducto(ProductosForm.ID_Producto_Busqueda);

            // Completar los campos de edicion
            Descripcion.Text = EditProduct.FirstOrDefault().Descripcion.ToString();
            Costo.Value = ((decimal)EditProduct.FirstOrDefault().Costo);
            PrecioVenta.Value = ((decimal)EditProduct.FirstOrDefault().PrecioVenta);
            Stock.Value = EditProduct.FirstOrDefault().Stock;
            IdUsuario.Value = EditProduct.FirstOrDefault().IdUsuario;
        }
    }
}
