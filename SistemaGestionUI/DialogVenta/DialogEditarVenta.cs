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

namespace SistemaGestionUI.DialogVenta
{
    public partial class DialogEditarVenta : Form
    {
        public DialogEditarVenta()
        {
            InitializeComponent();
        }

        private void EditarVenta_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text != String.Empty)
            {
                Venta EditedVenta = new Venta(
                        VentasForm.ID_Venta_Busqueda,
                        Descripcion.Text,
                        ((int)IDUsuario.Value)
                    );
                VentaBussiness.EditVenta(
                        EditedVenta
                    );
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta informacion!", "Error");
            }
        }

        private void DialogEditarVenta_Load(object sender, EventArgs e)
        {
            // Obtener el listado de Productos
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear como minimo y maximo del rango
            IDUsuario.Minimum = lista.FirstOrDefault().Id;
            IDUsuario.Maximum = lista.LastOrDefault().Id;

            // Obtener el listado de usuarios
            Venta EditVenta = VentaBussiness.GetVenta(VentasForm.ID_Venta_Busqueda);

            // Completar los campos de edicion
            Descripcion.Text = EditVenta.Comentarios.ToString();
            IDUsuario.Value = EditVenta.IdUsuario;
        }
    }
}
