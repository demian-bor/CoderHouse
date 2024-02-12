using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBussiness;

namespace SistemaGestionUI
{
    public partial class VentasForm : Form
    {
        public VentasForm()
        {
            InitializeComponent();
        }

        private void SwitchProductos_Click(object sender, EventArgs e)
        {
            // Retornar al dialog principal de productos
            this.RefToProductos.Show();
            this.Close();
        }

        private void SwitchUsuarios_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y cerrar actual
            VentasForm DialogoUsuarios = new VentasForm();
            DialogoUsuarios.RefToProductos = this.RefToProductos;
            DialogoUsuarios.Show();
            this.Close();
        }

        private void ListarUsuariosBtn_Click(object sender, EventArgs e)
        {

        }

        // Referencia al Form principal de Productos
        public Form RefToProductos { get; set; }
    }
}
