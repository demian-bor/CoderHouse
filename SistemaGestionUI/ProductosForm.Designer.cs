namespace SistemaGestionUI
{
    partial class ProductosForm
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
            SwitchVentas = new Button();
            SwitchUsuarios = new Button();
            EliminarProductoBtn = new Button();
            EditarProductoBtn = new Button();
            CrearProductoBtn = new Button();
            BuscarProductoBtn = new Button();
            ListarProductosBtn = new Button();
            TablaDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TablaDatos).BeginInit();
            SuspendLayout();
            // 
            // SwitchVentas
            // 
            SwitchVentas.Location = new Point(929, 13);
            SwitchVentas.Name = "SwitchVentas";
            SwitchVentas.Size = new Size(80, 41);
            SwitchVentas.TabIndex = 15;
            SwitchVentas.Text = "Ventas";
            SwitchVentas.UseVisualStyleBackColor = true;
            SwitchVentas.Click += SwitchVentas_Click;
            // 
            // SwitchUsuarios
            // 
            SwitchUsuarios.Location = new Point(843, 13);
            SwitchUsuarios.Name = "SwitchUsuarios";
            SwitchUsuarios.Size = new Size(80, 41);
            SwitchUsuarios.TabIndex = 14;
            SwitchUsuarios.Text = "Usuarios";
            SwitchUsuarios.UseVisualStyleBackColor = true;
            SwitchUsuarios.Click += SwitchUsuarios_Click;
            // 
            // EliminarProductoBtn
            // 
            EliminarProductoBtn.Location = new Point(650, 13);
            EliminarProductoBtn.Name = "EliminarProductoBtn";
            EliminarProductoBtn.Size = new Size(153, 41);
            EliminarProductoBtn.TabIndex = 13;
            EliminarProductoBtn.Text = "Eliminar Producto";
            EliminarProductoBtn.UseVisualStyleBackColor = true;
            EliminarProductoBtn.Click += EliminarProductoBtn_Click;
            // 
            // EditarProductoBtn
            // 
            EditarProductoBtn.Location = new Point(491, 13);
            EditarProductoBtn.Name = "EditarProductoBtn";
            EditarProductoBtn.Size = new Size(153, 41);
            EditarProductoBtn.TabIndex = 12;
            EditarProductoBtn.Text = "Editar Producto";
            EditarProductoBtn.UseVisualStyleBackColor = true;
            EditarProductoBtn.Click += EditarProductoBtn_Click;
            // 
            // CrearProductoBtn
            // 
            CrearProductoBtn.Location = new Point(332, 13);
            CrearProductoBtn.Name = "CrearProductoBtn";
            CrearProductoBtn.Size = new Size(153, 41);
            CrearProductoBtn.TabIndex = 11;
            CrearProductoBtn.Text = "Crear Producto";
            CrearProductoBtn.UseVisualStyleBackColor = true;
            CrearProductoBtn.Click += CrearProductoBtn_Click;
            // 
            // BuscarProductoBtn
            // 
            BuscarProductoBtn.Location = new Point(173, 13);
            BuscarProductoBtn.Name = "BuscarProductoBtn";
            BuscarProductoBtn.Size = new Size(153, 41);
            BuscarProductoBtn.TabIndex = 10;
            BuscarProductoBtn.Text = "Buscar Producto";
            BuscarProductoBtn.UseVisualStyleBackColor = true;
            BuscarProductoBtn.Click += BuscarProductoBtn_Click;
            // 
            // ListarProductosBtn
            // 
            ListarProductosBtn.Location = new Point(14, 13);
            ListarProductosBtn.Name = "ListarProductosBtn";
            ListarProductosBtn.Size = new Size(153, 41);
            ListarProductosBtn.TabIndex = 9;
            ListarProductosBtn.Text = "Listar Productos";
            ListarProductosBtn.UseVisualStyleBackColor = true;
            ListarProductosBtn.Click += ListarProductosBtn_Click;
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
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 522);
            Controls.Add(SwitchVentas);
            Controls.Add(SwitchUsuarios);
            Controls.Add(EliminarProductoBtn);
            Controls.Add(EditarProductoBtn);
            Controls.Add(CrearProductoBtn);
            Controls.Add(BuscarProductoBtn);
            Controls.Add(ListarProductosBtn);
            Controls.Add(TablaDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductosForm";
            Load += ProductosForm_Load;
            ((System.ComponentModel.ISupportInitialize)TablaDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SwitchVentas;
        private Button SwitchUsuarios;
        private Button EliminarProductoBtn;
        private Button EditarProductoBtn;
        private Button CrearProductoBtn;
        private Button BuscarProductoBtn;
        private Button ListarProductosBtn;
        private DataGridView TablaDatos;
    }
}