using SistemaGestionBussiness;
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
    public partial class DialogNuevaVenta : Form
    {
        public DialogNuevaVenta()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, EventArgs e)
        {
            if (Comentarios.Text != String.Empty)
            {
                VentaBussiness.NewVenta(
                    Comentarios.Text,
                    ((int)IDUsuario.Value)
                );
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta informacion!", "Error");
            }
        }

        private void DialogNuevaVenta_Load(object sender, EventArgs e)
        {
            // Obtener el listado de ventas
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear como minimo y maximo del rango
            IDUsuario.Minimum = lista.FirstOrDefault().Id;
            IDUsuario.Maximum = lista.LastOrDefault().Id;
        }
    }
}
