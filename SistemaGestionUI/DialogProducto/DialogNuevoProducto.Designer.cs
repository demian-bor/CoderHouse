namespace SistemaGestionUI.DialogProducto
{
    partial class DialogNuevoProducto
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
            DescripcionLabel = new Label();
            CostoLabel = new Label();
            PrecioVentaLabel = new Label();
            StockLabel = new Label();
            IdUsuarioLabel = new Label();
            Descripcion = new TextBox();
            Costo = new NumericUpDown();
            PrecioVenta = new NumericUpDown();
            Stock = new NumericUpDown();
            IdUsuario = new NumericUpDown();
            CrearProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)Costo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IdUsuario).BeginInit();
            SuspendLayout();
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescripcionLabel.Location = new Point(68, 32);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new Size(94, 21);
            DescripcionLabel.TabIndex = 0;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // CostoLabel
            // 
            CostoLabel.AutoSize = true;
            CostoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostoLabel.Location = new Point(109, 63);
            CostoLabel.Name = "CostoLabel";
            CostoLabel.Size = new Size(53, 21);
            CostoLabel.TabIndex = 1;
            CostoLabel.Text = "Costo:";
            // 
            // PrecioVentaLabel
            // 
            PrecioVentaLabel.AutoSize = true;
            PrecioVentaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecioVentaLabel.Location = new Point(42, 90);
            PrecioVentaLabel.Name = "PrecioVentaLabel";
            PrecioVentaLabel.Size = new Size(120, 21);
            PrecioVentaLabel.TabIndex = 2;
            PrecioVentaLabel.Text = "Precio de Venta:";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StockLabel.Location = new Point(112, 121);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(50, 21);
            StockLabel.TabIndex = 3;
            StockLabel.Text = "Stock:";
            // 
            // IdUsuarioLabel
            // 
            IdUsuarioLabel.AutoSize = true;
            IdUsuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdUsuarioLabel.Location = new Point(76, 150);
            IdUsuarioLabel.Name = "IdUsuarioLabel";
            IdUsuarioLabel.Size = new Size(86, 21);
            IdUsuarioLabel.TabIndex = 4;
            IdUsuarioLabel.Text = "ID Usuario:";
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(168, 32);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(120, 23);
            Descripcion.TabIndex = 5;
            // 
            // Costo
            // 
            Costo.DecimalPlaces = 2;
            Costo.Location = new Point(168, 61);
            Costo.Maximum = new decimal(new int[] { -727379969, 232, 0, 131072 });
            Costo.Name = "Costo";
            Costo.Size = new Size(120, 23);
            Costo.TabIndex = 6;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DecimalPlaces = 2;
            PrecioVenta.Location = new Point(168, 90);
            PrecioVenta.Maximum = new decimal(new int[] { -727379969, 232, 0, 131072 });
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Size = new Size(120, 23);
            PrecioVenta.TabIndex = 7;
            // 
            // Stock
            // 
            Stock.Location = new Point(168, 119);
            Stock.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            Stock.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Stock.Name = "Stock";
            Stock.Size = new Size(120, 23);
            Stock.TabIndex = 8;
            Stock.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // IdUsuario
            // 
            IdUsuario.Location = new Point(168, 148);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(120, 23);
            IdUsuario.TabIndex = 9;
            // 
            // CrearProducto
            // 
            CrearProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CrearProducto.Location = new Point(131, 191);
            CrearProducto.Name = "CrearProducto";
            CrearProducto.Size = new Size(94, 42);
            CrearProducto.TabIndex = 10;
            CrearProducto.Text = "Crear";
            CrearProducto.UseVisualStyleBackColor = true;
            CrearProducto.Click += CrearProducto_Click;
            // 
            // DialogNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 263);
            Controls.Add(CrearProducto);
            Controls.Add(IdUsuario);
            Controls.Add(Stock);
            Controls.Add(PrecioVenta);
            Controls.Add(Costo);
            Controls.Add(Descripcion);
            Controls.Add(IdUsuarioLabel);
            Controls.Add(StockLabel);
            Controls.Add(PrecioVentaLabel);
            Controls.Add(CostoLabel);
            Controls.Add(DescripcionLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogNuevoProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Producto";
            Load += DialogNuevoProducto_Load;
            ((System.ComponentModel.ISupportInitialize)Costo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)Stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)IdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DescripcionLabel;
        private Label CostoLabel;
        private Label PrecioVentaLabel;
        private Label StockLabel;
        private Label IdUsuarioLabel;
        private TextBox Descripcion;
        private NumericUpDown Costo;
        private NumericUpDown PrecioVenta;
        private NumericUpDown Stock;
        private NumericUpDown IdUsuario;
        private Button CrearProducto;
    }
}