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
    public partial class DialogBuscarUsuario : Form
    {
        public DialogBuscarUsuario()
        {
            InitializeComponent();
        }

        private void DialogBuscarUsuario_Load(object sender, EventArgs e)
        {
            // Obtener el listado de usuarios
            var lista = UsuarioBussiness.GetUsuarios();

            // Setear como minimo y maximo del rango
            IDSelection.Minimum = lista.FirstOrDefault().Id;
            IDSelection.Maximum = lista.LastOrDefault().Id;
        }

        private void IDConfirm_Click(object sender, EventArgs e)
        {
            // Setea el valor de busqueda en base al index y cierra el dialogo
            UsuariosForm.ID_Usuario_Busqueda = ((int)IDSelection.Value);
            this.Close();
        }
    }
}
