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
    public partial class DialogBuscarProducto : Form
    {
        public DialogBuscarProducto()
        {
            InitializeComponent();
        }

        private void DialogBuscarProducto_Load(object sender, EventArgs e)
        {
            // Obtener el listado de usuarios
            var lista = ProductoBussiness.GetProductos();

            // Setear como minimo y maximo del rango
            SelectedID.Minimum = lista.FirstOrDefault().Id;
            SelectedID.Maximum = lista.LastOrDefault().Id;
        }

        private void SearchID_Click(object sender, EventArgs e)
        {
            // Setea el valor de busqueda en base al index y cierra el dialogo
            ProductosForm.ID_Producto_Busqueda = ((int)SelectedID.Value);
            this.Close();
        }
    }
}
