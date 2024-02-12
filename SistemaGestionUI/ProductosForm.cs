using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionUI.DialogProducto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void SwitchUsuarios_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y ocultar actual
            UsuariosForm DialogoUsuarios = new UsuariosForm();
            DialogoUsuarios.RefToProductos = this;
            DialogoUsuarios.Show();
            this.Hide();
        }

        private void SwitchVentas_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y ocultar actual
            VentasForm DialogoVentas = new VentasForm();
            DialogoVentas.RefToProductos = this;
            DialogoVentas.Show();
            this.Hide();
        }

        private void ListarProductosBtn_Click(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de productos
            var lista = ProductoBussiness.GetProductos();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Descripcion", "Descripcion");
            TablaDatos.Columns.Add("Costo", "Costo");
            TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
            TablaDatos.Columns.Add("Stock", "Stock");
            TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de productos
            var lista = ProductoBussiness.GetProductos();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Descripcion", "Descripcion");
            TablaDatos.Columns.Add("Costo", "Costo");
            TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
            TablaDatos.Columns.Add("Stock", "Stock");
            TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void BuscarProductoBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo de busqueda
            DialogBuscarProducto DialogoBuscarProducto = new DialogBuscarProducto();
            DialogoBuscarProducto.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de productos
            var lista = ProductoBussiness.GetProducto(ID_Producto_Busqueda);

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Descripcion", "Descripcion");
            TablaDatos.Columns.Add("Costo", "Costo");
            TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
            TablaDatos.Columns.Add("Stock", "Stock");
            TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
            TablaDatos.AutoResizeColumns();
        }

        private void CrearProductoBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y crear usuario
            DialogNuevoProducto DialogoCrearProducto = new DialogNuevoProducto();
            DialogoCrearProducto.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de productos
            var lista = ProductoBussiness.GetProductos();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Descripcion", "Descripcion");
            TablaDatos.Columns.Add("Costo", "Costo");
            TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
            TablaDatos.Columns.Add("Stock", "Stock");
            TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void EliminarProductoBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el id a eliminar
                Int32 selected_id = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Eliminar Producto
                string message = "Esta seguro que desea eliminar el producto \"" + TablaDatos.SelectedRows[0].Cells[1].Value.ToString() + "\"?";
                string caption = "Confirmar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Si se confirma proceder con eliminacion
                    ProductoBussiness.RemoveProducto(selected_id);
                }

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de productos
                var lista = ProductoBussiness.GetProductos();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Descripcion", "Descripcion");
                TablaDatos.Columns.Add("Costo", "Costo");
                TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
                TablaDatos.Columns.Add("Stock", "Stock");
                TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
                }
                TablaDatos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se seleccionó un productos!", "Error");
            }
        }

        private void EditarProductoBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el Id a editar
                ID_Producto_Busqueda = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Mostrar dialogo y crear usuario
                DialogEditarProducto DialogoModificarProducto = new DialogEditarProducto();
                DialogoModificarProducto.ShowDialog();

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de productos
                var lista = ProductoBussiness.GetProductos();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Descripcion", "Descripcion");
                TablaDatos.Columns.Add("Costo", "Costo");
                TablaDatos.Columns.Add("PrecioVenta", "PrecioVenta");
                TablaDatos.Columns.Add("Stock", "Stock");
                TablaDatos.Columns.Add("IdUsuario", "IdUsuario");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Descripcion, item.Costo, item.PrecioVenta, item.Stock, item.IdUsuario);
                }
                TablaDatos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se seleccionó un producto!", "Error");
            }
        }

        // Referencia a ID de busqueda de producto
        public static Int32 ID_Producto_Busqueda { get; set; }
    }
}
