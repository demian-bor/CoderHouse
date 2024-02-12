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
            EliminarVentaBtn = new Button();
            EditarVentaBtn = new Button();
            CrearVentaBtn = new Button();
            BuscarVentaBtn = new Button();
            ListarVentasBtn = new Button();
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
            // EliminarVentaBtn
            // 
            EliminarVentaBtn.Location = new Point(650, 13);
            EliminarVentaBtn.Name = "EliminarVentaBtn";
            EliminarVentaBtn.Size = new Size(153, 41);
            EliminarVentaBtn.TabIndex = 13;
            EliminarVentaBtn.Text = "Eliminar Venta";
            EliminarVentaBtn.UseVisualStyleBackColor = true;
            EliminarVentaBtn.Click += EliminarVentaBtn_Click;
            // 
            // EditarVentaBtn
            // 
            EditarVentaBtn.Location = new Point(491, 13);
            EditarVentaBtn.Name = "EditarVentaBtn";
            EditarVentaBtn.Size = new Size(153, 41);
            EditarVentaBtn.TabIndex = 12;
            EditarVentaBtn.Text = "Editar Venta";
            EditarVentaBtn.UseVisualStyleBackColor = true;
            EditarVentaBtn.Click += EditarVentaBtn_Click;
            // 
            // CrearVentaBtn
            // 
            CrearVentaBtn.Location = new Point(332, 13);
            CrearVentaBtn.Name = "CrearVentaBtn";
            CrearVentaBtn.Size = new Size(153, 41);
            CrearVentaBtn.TabIndex = 11;
            CrearVentaBtn.Text = "Crear Venta";
            CrearVentaBtn.UseVisualStyleBackColor = true;
            CrearVentaBtn.Click += CrearVentaBtn_Click;
            // 
            // BuscarVentaBtn
            // 
            BuscarVentaBtn.Location = new Point(173, 13);
            BuscarVentaBtn.Name = "BuscarVentaBtn";
            BuscarVentaBtn.Size = new Size(153, 41);
            BuscarVentaBtn.TabIndex = 10;
            BuscarVentaBtn.Text = "Buscar Venta";
            BuscarVentaBtn.UseVisualStyleBackColor = true;
            BuscarVentaBtn.Click += BuscarVentaBtn_Click;
            // 
            // ListarVentasBtn
            // 
            ListarVentasBtn.Location = new Point(14, 13);
            ListarVentasBtn.Name = "ListarVentasBtn";
            ListarVentasBtn.Size = new Size(153, 41);
            ListarVentasBtn.TabIndex = 9;
            ListarVentasBtn.Text = "Listar Ventas";
            ListarVentasBtn.UseVisualStyleBackColor = true;
            ListarVentasBtn.Click += ListarVentasBtn_Click;
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
            Controls.Add(EliminarVentaBtn);
            Controls.Add(EditarVentaBtn);
            Controls.Add(CrearVentaBtn);
            Controls.Add(BuscarVentaBtn);
            Controls.Add(ListarVentasBtn);
            Controls.Add(TablaDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "VentasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VentasForm";
            Load += VentasForm_Load;
            ((System.ComponentModel.ISupportInitialize)TablaDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button SwitchUsuarios;
        private Button SwitchProductos;
        private Button EliminarVentaBtn;
        private Button EditarVentaBtn;
        private Button CrearVentaBtn;
        private Button BuscarVentaBtn;
        private Button ListarVentasBtn;
        private DataGridView TablaDatos;
    }
}