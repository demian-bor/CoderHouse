using SistemaGestionBussiness;
using SistemaGestionData;
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

namespace SistemaGestionUI
{
    public partial class DialogEditarUsuario : Form
    {
        public DialogEditarUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsr_Click(object sender, EventArgs e)
        {
            if (NombreInput.Text != String.Empty && ApellidoInput.Text != String.Empty && UsuarioInput.Text != String.Empty && ContrasenaInput.Text != String.Empty && CorreoInput.Text != String.Empty)
            {
                Usuario EditedUser = new Usuario(
                        UsuariosForm.ID_Usuario_Busqueda,
                        NombreInput.Text,
                        ApellidoInput.Text,
                        UsuarioInput.Text,
                        ContrasenaInput.Text,
                        CorreoInput.Text
                    );
                UsuarioBussiness.EditUsuario(
                    EditedUser
                );
                this.Close();
            }
            else
            {
                MessageBox.Show("Falta informacion!", "Error");
            }
        }

        private void DialogEditarUsuario_Load(object sender, EventArgs e)
        {
            // Obtener el listado de usuarios
            List<Usuario> EditUser = UsuarioBussiness.GetUsuario(UsuariosForm.ID_Usuario_Busqueda);

            // Completar los campos de edicion
            NombreInput.Text = EditUser.FirstOrDefault().Nombre;
            ApellidoInput.Text = EditUser.FirstOrDefault().Apellido;
            UsuarioInput.Text = EditUser.FirstOrDefault().NombreUsuario;
            ContrasenaInput.Text = EditUser.FirstOrDefault().Contraseña;
            CorreoInput.Text = EditUser.FirstOrDefault().Mail;
        }
    }
}
