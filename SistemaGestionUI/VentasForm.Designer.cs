namespace SistemaGestionUI
{
    partial class VentasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SwitchUsuarios = new Button();
            SwitchProductos = new Button();
            EliminarUsuarioBtn = new Button();
            EditarUsuarioBtn = new Button();
            CrearUsuarioBtn = new Button();
            BuscarUsuarioBtn = new Button();
            ListarUsuariosBtn = new Button();
            TablaDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TablaDatos).BeginInit();
            SuspendLayout();
            // 
            // SwitchUsuarios
            // 
            SwitchUsuarios.Location = new Point(929, 13);
            SwitchUsuarios.Name = "SwitchUsuarios";
            SwitchUsuarios.Size = new Size(80, 41);
            SwitchUsuarios.TabIndex = 15;
            SwitchUsuarios.Text = "Usuarios";
            SwitchUsuarios.UseVisualStyleBackColor = true;
            SwitchUsuarios.Click += SwitchUsuarios_Click;
            // 
            // SwitchProductos
            // 
            SwitchProductos.Location = new Point(843, 13);
            SwitchProductos.Name = "SwitchProductos";
            SwitchProductos.Size = new Size(80, 41);
            SwitchProductos.TabIndex = 14;
            SwitchProductos.Text = "Productos";
            SwitchProductos.UseVisualStyleBackColor = true;
            SwitchProductos.Click += SwitchProductos_Click;
            // 
            // EliminarUsuarioBtn
            // 
            EliminarUsuarioBtn.Location = new Point(650, 13);
            EliminarUsuarioBtn.Name = "EliminarUsuarioBtn";
            EliminarUsuarioBtn.Size = new Size(153, 41);
            EliminarUsuarioBtn.TabIndex = 13;
            EliminarUsuarioBtn.Text = "Eliminar Usuario";
            EliminarUsuarioBtn.UseVisualStyleBackColor = true;
            // 
            // EditarUsuarioBtn
            // 
            EditarUsuarioBtn.Location = new Point(491, 13);
            EditarUsuarioBtn.Name = "EditarUsuarioBtn";
            EditarUsuarioBtn.Size = new Size(153, 41);
            EditarUsuarioBtn.TabIndex = 12;
            EditarUsuarioBtn.Text = "Editar Usuario";
            EditarUsuarioBtn.UseVisualStyleBackColor = true;
            // 
            // CrearUsuarioBtn
            // 
            CrearUsuarioBtn.Location = new Point(332, 13);
            CrearUsuarioBtn.Name = "CrearUsuarioBtn";
            CrearUsuarioBtn.Size = new Size(153, 41);
            CrearUsuarioBtn.TabIndex = 11;
            CrearUsuarioBtn.Text = "Crear Usuario";
            CrearUsuarioBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarUsuarioBtn
            // 
            BuscarUsuarioBtn.Location = new Point(173, 13);
            BuscarUsuarioBtn.Name = "BuscarUsuarioBtn";
            BuscarUsuarioBtn.Size = new Size(153, 41);
            BuscarUsuarioBtn.TabIndex = 10;
            BuscarUsuarioBtn.Text = "Buscar Usuario";
            BuscarUsuarioBtn.UseVisualStyleBackColor = true;
            // 
            // ListarUsuariosBtn
            // 
            ListarUsuariosBtn.Location = new Point(14, 13);
            ListarUsuariosBtn.Name = "ListarUsuariosBtn";
            ListarUsuariosBtn.Size = new Size(153, 41);
            ListarUsuariosBtn.TabIndex = 9;
            ListarUsuariosBtn.Text = "Listar Usuarios";
            ListarUsuariosBtn.UseVisualStyleBackColor = true;
            ListarUsuariosBtn.Click += ListarUsuariosBtn_Click;
            // 
            // TablaDatos
            // 
            TablaDatos.AllowUserToAddRows = false;
            TablaDatos.AllowUserToDeleteRows = false;
            TablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            TablaDatos.Location = new Point(14, 60);
            TablaDatos.MultiSelect = false;
            TablaDatos.Name = "TablaDatos";
            TablaDatos.RowTemplate.Height = 25;
            TablaDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaDatos.ShowEditingIcon = false;
            TablaDatos.Size = new Size(995, 449);
            TablaDatos.TabIndex = 8;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 522);
            Controls.Add(SwitchUsuarios);
            Controls.Add(SwitchProductos);
            Controls.Add(EliminarUsuarioBtn);
            Controls.Add(EditarUsuarioBtn);
            Controls.Add(CrearUsuarioBtn);
            Controls.Add(BuscarUsuarioBtn);
            Controls.Add(ListarUsuariosBtn);
            Controls.Add(TablaDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VentasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentasForm";
            ((System.ComponentModel.ISupportInitialize)TablaDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SwitchUsuarios;
        private Button SwitchProductos;
        private Button EliminarUsuarioBtn;
        private Button EditarUsuarioBtn;
        private Button CrearUsuarioBtn;
        private Button BuscarUsuarioBtn;
        private Button ListarUsuariosBtn;
        private DataGridView TablaDatos;
    }
}