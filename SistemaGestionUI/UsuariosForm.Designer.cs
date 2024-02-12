namespace SistemaGestionUI
{
    partial class UsuariosForm
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
            TablaDatos = new DataGridView();
            ListarUsuariosBtn = new Button();
            BuscarUsuarioBtn = new Button();
            CrearUsuarioBtn = new Button();
            EditarUsuarioBtn = new Button();
            EliminarUsuarioBtn = new Button();
            SwitchProductos = new Button();
            SwitchVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaDatos).BeginInit();
            SuspendLayout();
            // 
            // TablaDatos
            // 
            TablaDatos.AllowUserToAddRows = false;
            TablaDatos.AllowUserToDeleteRows = false;
            TablaDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            TablaDatos.Location = new Point(12, 61);
            TablaDatos.MultiSelect = false;
            TablaDatos.Name = "TablaDatos";
            TablaDatos.RowTemplate.Height = 25;
            TablaDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TablaDatos.ShowEditingIcon = false;
            TablaDatos.Size = new Size(995, 449);
            TablaDatos.TabIndex = 0;
            // 
            // ListarUsuariosBtn
            // 
            ListarUsuariosBtn.Location = new Point(12, 14);
            ListarUsuariosBtn.Name = "ListarUsuariosBtn";
            ListarUsuariosBtn.Size = new Size(153, 41);
            ListarUsuariosBtn.TabIndex = 1;
            ListarUsuariosBtn.Text = "Listar Usuarios";
            ListarUsuariosBtn.UseVisualStyleBackColor = true;
            ListarUsuariosBtn.Click += ListarUsuariosBtn_Click;
            // 
            // BuscarUsuarioBtn
            // 
            BuscarUsuarioBtn.Location = new Point(171, 14);
            BuscarUsuarioBtn.Name = "BuscarUsuarioBtn";
            BuscarUsuarioBtn.Size = new Size(153, 41);
            BuscarUsuarioBtn.TabIndex = 2;
            BuscarUsuarioBtn.Text = "Buscar Usuario";
            BuscarUsuarioBtn.UseVisualStyleBackColor = true;
            BuscarUsuarioBtn.Click += BuscarUsuarioBtn_Click;
            // 
            // CrearUsuarioBtn
            // 
            CrearUsuarioBtn.Location = new Point(330, 14);
            CrearUsuarioBtn.Name = "CrearUsuarioBtn";
            CrearUsuarioBtn.Size = new Size(153, 41);
            CrearUsuarioBtn.TabIndex = 3;
            CrearUsuarioBtn.Text = "Crear Usuario";
            CrearUsuarioBtn.UseVisualStyleBackColor = true;
            CrearUsuarioBtn.Click += CrearUsuarioBtn_Click;
            // 
            // EditarUsuarioBtn
            // 
            EditarUsuarioBtn.Location = new Point(489, 14);
            EditarUsuarioBtn.Name = "EditarUsuarioBtn";
            EditarUsuarioBtn.Size = new Size(153, 41);
            EditarUsuarioBtn.TabIndex = 4;
            EditarUsuarioBtn.Text = "Editar Usuario";
            EditarUsuarioBtn.UseVisualStyleBackColor = true;
            EditarUsuarioBtn.Click += EditarUsuarioBtn_Click;
            // 
            // EliminarUsuarioBtn
            // 
            EliminarUsuarioBtn.Location = new Point(648, 14);
            EliminarUsuarioBtn.Name = "EliminarUsuarioBtn";
            EliminarUsuarioBtn.Size = new Size(153, 41);
            EliminarUsuarioBtn.TabIndex = 5;
            EliminarUsuarioBtn.Text = "Eliminar Usuario";
            EliminarUsuarioBtn.UseVisualStyleBackColor = true;
            EliminarUsuarioBtn.Click += EliminarUsuarioBtn_Click;
            // 
            // SwitchProductos
            // 
            SwitchProductos.Location = new Point(841, 14);
            SwitchProductos.Name = "SwitchProductos";
            SwitchProductos.Size = new Size(80, 41);
            SwitchProductos.TabIndex = 6;
            SwitchProductos.Text = "Productos";
            SwitchProductos.UseVisualStyleBackColor = true;
            SwitchProductos.Click += SwitchProductos_Click;
            // 
            // SwitchVentas
            // 
            SwitchVentas.Location = new Point(927, 14);
            SwitchVentas.Name = "SwitchVentas";
            SwitchVentas.Size = new Size(80, 41);
            SwitchVentas.TabIndex = 7;
            SwitchVentas.Text = "Ventas";
            SwitchVentas.UseVisualStyleBackColor = true;
            SwitchVentas.Click += SwitchVentas_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 522);
            Controls.Add(SwitchVentas);
            Controls.Add(SwitchProductos);
            Controls.Add(EliminarUsuarioBtn);
            Controls.Add(EditarUsuarioBtn);
            Controls.Add(CrearUsuarioBtn);
            Controls.Add(BuscarUsuarioBtn);
            Controls.Add(ListarUsuariosBtn);
            Controls.Add(TablaDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UsuariosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += UsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)TablaDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TablaDatos;
        private Button ListarUsuariosBtn;
        private Button BuscarUsuarioBtn;
        private Button CrearUsuarioBtn;
        private Button EditarUsuarioBtn;
        private Button EliminarUsuarioBtn;
        private Button SwitchProductos;
        private Button SwitchVentas;
    }
}