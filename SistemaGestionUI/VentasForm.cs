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
using SistemaGestionData;
using SistemaGestionUI.DialogVenta;

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

        private void ListarVentasBtn_Click(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de ventas
            var lista = VentaBussiness.GetVentas();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Comentarios", "Comentarios");
            TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de ventas
            var lista = VentaBussiness.GetVentas();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Comentarios", "Comentarios");
            TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void EliminarVentaBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el id a eliminar
                Int32 selected_id = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Eliminar usuario
                string message = "Esta seguro que desea eliminar la venta " + TablaDatos.SelectedRows[0].Cells[1].Value.ToString() + "?";
                string caption = "Confirmar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Si se confirma proceder con eliminacion
                    VentaBussiness.RemoveVenta(selected_id);
                }

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de ventas
                var lista = VentaBussiness.GetVentas();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Comentarios", "Comentarios");
                TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
                }
                TablaDatos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se seleccionó una venta!", "Error");
            }
        }

        private void BuscarVentaBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo de busqueda
            DialogBuscarVenta DialogoBuscarVenta = new DialogBuscarVenta();
            DialogoBuscarVenta.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de ventas
            var lista = VentaBussiness.GetVenta(ID_Venta_Busqueda);

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Comentarios", "Comentarios");
            TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void CrearVentaBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y crear venta
            DialogNuevaVenta DialogoCrearVenta = new DialogNuevaVenta();
            DialogoCrearVenta.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de ventas
            var lista = VentaBussiness.GetVentas();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Comentarios", "Comentarios");
            TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void EditarVentaBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el Id a editar
                ID_Venta_Busqueda = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Mostrar dialogo y editar venta
                DialogEditarVenta DialogoEditarVenta = new DialogEditarVenta();
                DialogoEditarVenta.ShowDialog();

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de ventas
                var lista = VentaBussiness.GetVentas();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Comentarios", "Comentarios");
                TablaDatos.Columns.Add("Id Usuario", "Id Usuario");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Comentarios, item.IdUsuario);
                }
                TablaDatos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se seleccionó un usuario!", "Error");
            }
        }

        // Referencia al Form principal de Productos
        public Form RefToProductos { get; set; }

        // Referencia a ID de busqueda de usuario
        public static Int32 ID_Venta_Busqueda { get; set; }
    }
}
