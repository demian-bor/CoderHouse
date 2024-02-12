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
    public partial class DialogBuscarVenta : Form
    {
        public DialogBuscarVenta()
        {
            InitializeComponent();
        }

        private void BuscarVenta_Click(object sender, EventArgs e)
        {
            // Setea el valor de busqueda en base al index y cierra el dialogo
            VentasForm.ID_Venta_Busqueda = ((int)IDSelection.Value);
            this.Close();
        }

        private void DialogBuscarVenta_Load(object sender, EventArgs e)
        {
            // Obtener el listado de ventas
            var lista = VentaBussiness.GetVentas();

            // Setear como minimo y maximo del rango
            IDSelection.Minimum = lista.FirstOrDefault().Id;
            IDSelection.Maximum = lista.LastOrDefault().Id;
        }
    }
}
