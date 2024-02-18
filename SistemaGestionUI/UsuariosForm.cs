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

namespace SistemaGestionUI
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void SwitchProductos_Click(object sender, EventArgs e)
        {
            // Retornar al dialog principal de productos
            this.RefToProductos.Show();
            this.Close();
        }

        private void SwitchVentas_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y cerrar actual
            VentasForm DialogoVentas = new VentasForm();
            DialogoVentas.RefToProductos = this.RefToProductos;
            DialogoVentas.Show();
            this.Close();
        }

        private void ListarUsuariosBtn_Click(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de usuarios
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Nombre", "Nombre");
            TablaDatos.Columns.Add("Apellido", "Apellido");
            TablaDatos.Columns.Add("Usuario", "Usuario");
            TablaDatos.Columns.Add("Contraseña", "Contraseña");
            TablaDatos.Columns.Add("Correo", "Correo");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Nombre, item.Apellido, item.NombreUsuario, item.Contraseña, item.Mail);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void BuscarUsuarioBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo de busqueda
            DialogBuscarUsuario DialogoBuscarUsuario = new DialogBuscarUsuario();
            DialogoBuscarUsuario.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de usuarios
            var lista = UsuarioBussiness.GetUsuario(ID_Usuario_Busqueda);

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Nombre", "Nombre");
            TablaDatos.Columns.Add("Apellido", "Apellido");
            TablaDatos.Columns.Add("Usuario", "Usuario");
            TablaDatos.Columns.Add("Contraseña", "Contraseña");
            TablaDatos.Columns.Add("Correo", "Correo");
            TablaDatos.Rows.Add(lista.Id, lista.Nombre, lista.Apellido, lista.NombreUsuario, lista.Contraseña, lista.Mail);
            TablaDatos.AutoResizeColumns();
        }

        private void CrearUsuarioBtn_Click(object sender, EventArgs e)
        {
            // Mostrar dialogo y crear usuario
            DialogNuevoUsuario DialogoCrearUsuario = new DialogNuevoUsuario();
            DialogoCrearUsuario.ShowDialog();

            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de usuarios
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Nombre", "Nombre");
            TablaDatos.Columns.Add("Apellido", "Apellido");
            TablaDatos.Columns.Add("Usuario", "Usuario");
            TablaDatos.Columns.Add("Contraseña", "Contraseña");
            TablaDatos.Columns.Add("Correo", "Correo");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Nombre, item.Apellido, item.NombreUsuario, item.Contraseña, item.Mail);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            // Vaciar la vista de Grilla
            TablaDatos.DataSource = null;
            TablaDatos.Rows.Clear();
            TablaDatos.Columns.Clear();

            // Obtener el listado de usuarios
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear los valores a mostrar
            TablaDatos.Columns.Add("ID", "ID");
            TablaDatos.Columns.Add("Nombre", "Nombre");
            TablaDatos.Columns.Add("Apellido", "Apellido");
            TablaDatos.Columns.Add("Usuario", "Usuario");
            TablaDatos.Columns.Add("Contraseña", "Contraseña");
            TablaDatos.Columns.Add("Correo", "Correo");
            foreach (var item in lista)
            {
                TablaDatos.Rows.Add(item.Id, item.Nombre, item.Apellido, item.NombreUsuario, item.Contraseña, item.Mail);
            }
            TablaDatos.AutoResizeColumns();
        }

        private void EditarUsuarioBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el Id a editar
                ID_Usuario_Busqueda = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Mostrar dialogo y crear usuario
                DialogEditarUsuario DialogoModificarUsuario = new DialogEditarUsuario();
                DialogoModificarUsuario.ShowDialog();

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de usuarios
                var lista = UsuarioData.ListarUsuarios();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Nombre", "Nombre");
                TablaDatos.Columns.Add("Apellido", "Apellido");
                TablaDatos.Columns.Add("Usuario", "Usuario");
                TablaDatos.Columns.Add("Contraseña", "Contraseña");
                TablaDatos.Columns.Add("Correo", "Correo");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Nombre, item.Apellido, item.NombreUsuario, item.Contraseña, item.Mail);
                }
                TablaDatos.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No se seleccionó un usuario!", "Error");
            }
        }

        private void EliminarUsuarioBtn_Click(object sender, EventArgs e)
        {
            // Obtener el ID seleccionado
            if (TablaDatos.SelectedRows.Count > 0)
            {
                // Obtener el id a eliminar
                Int32 selected_id = Convert.ToInt32(TablaDatos.SelectedRows[0].Cells[0].Value.ToString());

                // Eliminar usuario
                string message = "Esta seguro que desea eliminar el usuario " + TablaDatos.SelectedRows[0].Cells[3].Value.ToString() + "?";
                string caption = "Confirmar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Si se confirma proceder con eliminacion
                    UsuarioBussiness.RemoveUsuario(selected_id);
                }

                // Vaciar la vista de Grilla
                TablaDatos.DataSource = null;
                TablaDatos.Rows.Clear();
                TablaDatos.Columns.Clear();

                // Obtener el listado de usuarios
                var lista = UsuarioData.ListarUsuarios();

                // Setear los valores a mostrar
                TablaDatos.Columns.Add("ID", "ID");
                TablaDatos.Columns.Add("Nombre", "Nombre");
                TablaDatos.Columns.Add("Apellido", "Apellido");
                TablaDatos.Columns.Add("Usuario", "Usuario");
                TablaDatos.Columns.Add("Contraseña", "Contraseña");
                TablaDatos.Columns.Add("Correo", "Correo");
                foreach (var item in lista)
                {
                    TablaDatos.Rows.Add(item.Id, item.Nombre, item.Apellido, item.NombreUsuario, item.Contraseña, item.Mail);
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
        public static Int32 ID_Usuario_Busqueda { get; set; }
    }
}
