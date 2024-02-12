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
    public partial class DialogNuevoUsuario : Form
    {
        public DialogNuevoUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsr_Click(object sender, EventArgs e)
        {
            if (NombreInput.Text != String.Empty && ApellidoInput.Text != String.Empty && UsuarioInput.Text != String.Empty && ContrasenaInput.Text != String.Empty && CorreoInput.Text != String.Empty)
            {
                UsuarioBussiness.NewUsuario(
                    NombreInput.Text,
                    ApellidoInput.Text,
                    UsuarioInput.Text,
                    ContrasenaInput.Text,
                    CorreoInput.Text
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
