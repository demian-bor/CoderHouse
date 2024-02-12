using SistemaGestionBussiness;
using SistemaGestionData;
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
    public partial class DialogNuevoProducto : Form
    {
        public DialogNuevoProducto()
        {
            InitializeComponent();
        }

        private void DialogNuevoProducto_Load(object sender, EventArgs e)
        {
            // Obtener el listado de Productos
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear como minimo y maximo del rango
            IdUsuario.Minimum = lista.FirstOrDefault().Id;
            IdUsuario.Maximum = lista.LastOrDefault().Id;
        }

        private void CrearProducto_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text != String.Empty)
            {
                ProductoBussiness.NewProducto(
                    Descripcion.Text,
                    ((double)Costo.Value),
                    ((double)PrecioVenta.Value),
                    ((int)Stock.Value),
                    ((int)IdUsuario.Value)
                );
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta informacion!", "Error");
            }
        }
    }
}
