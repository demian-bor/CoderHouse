namespace SistemaGestionUI.DialogProducto
{
    partial class DialogEditarProducto
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
            EditarProducto = new Button();
            IdUsuario = new NumericUpDown();
            Stock = new NumericUpDown();
            PrecioVenta = new NumericUpDown();
            Costo = new NumericUpDown();
            Descripcion = new TextBox();
            IdUsuarioLabel = new Label();
            StockLabel = new Label();
            PrecioVentaLabel = new Label();
            CostoLabel = new Label();
            DescripcionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)IdUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Costo).BeginInit();
            SuspendLayout();
            // 
            // EditarProducto
            // 
            EditarProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditarProducto.Location = new Point(131, 194);
            EditarProducto.Name = "EditarProducto";
            EditarProducto.Size = new Size(94, 42);
            EditarProducto.TabIndex = 21;
            EditarProducto.Text = "Modificar";
            EditarProducto.UseVisualStyleBackColor = true;
            EditarProducto.Click += CrearProducto_Click;
            // 
            // IdUsuario
            // 
            IdUsuario.Location = new Point(168, 151);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(120, 23);
            IdUsuario.TabIndex = 20;
            // 
            // Stock
            // 
            Stock.Location = new Point(168, 122);
            Stock.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            Stock.Name = "Stock";
            Stock.Size = new Size(120, 23);
            Stock.TabIndex = 19;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DecimalPlaces = 2;
            PrecioVenta.Location = new Point(168, 93);
            PrecioVenta.Maximum = new decimal(new int[] { -727379969, 232, 0, 131072 });
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Size = new Size(120, 23);
            PrecioVenta.TabIndex = 18;
            // 
            // Costo
            // 
            Costo.DecimalPlaces = 2;
            Costo.Location = new Point(168, 64);
            Costo.Maximum = new decimal(new int[] { -727379969, 232, 0, 131072 });
            Costo.Name = "Costo";
            Costo.Size = new Size(120, 23);
            Costo.TabIndex = 17;
            // 
            // Descripcion
            // 
            Descripcion.Location = new Point(168, 35);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(120, 23);
            Descripcion.TabIndex = 16;
            // 
            // IdUsuarioLabel
            // 
            IdUsuarioLabel.AutoSize = true;
            IdUsuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IdUsuarioLabel.Location = new Point(76, 153);
            IdUsuarioLabel.Name = "IdUsuarioLabel";
            IdUsuarioLabel.Size = new Size(86, 21);
            IdUsuarioLabel.TabIndex = 15;
            IdUsuarioLabel.Text = "ID Usuario:";
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StockLabel.Location = new Point(112, 124);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(50, 21);
            StockLabel.TabIndex = 14;
            StockLabel.Text = "Stock:";
            // 
            // PrecioVentaLabel
            // 
            PrecioVentaLabel.AutoSize = true;
            PrecioVentaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecioVentaLabel.Location = new Point(42, 93);
            PrecioVentaLabel.Name = "PrecioVentaLabel";
            PrecioVentaLabel.Size = new Size(120, 21);
            PrecioVentaLabel.TabIndex = 13;
            PrecioVentaLabel.Text = "Precio de Venta:";
            // 
            // CostoLabel
            // 
            CostoLabel.AutoSize = true;
            CostoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CostoLabel.Location = new Point(109, 66);
            CostoLabel.Name = "CostoLabel";
            CostoLabel.Size = new Size(53, 21);
            CostoLabel.TabIndex = 12;
            CostoLabel.Text = "Costo:";
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescripcionLabel.Location = new Point(68, 35);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new Size(94, 21);
            DescripcionLabel.TabIndex = 11;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // DialogEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 263);
            Controls.Add(EditarProducto);
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
            Name = "DialogEditarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            Load += DialogEditarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)IdUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)Stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)Costo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditarProducto;
        private NumericUpDown IdUsuario;
        private NumericUpDown Stock;
        private NumericUpDown PrecioVenta;
        private NumericUpDown Costo;
        private TextBox Descripcion;
        private Label IdUsuarioLabel;
        private Label StockLabel;
        private Label PrecioVentaLabel;
        private Label CostoLabel;
        private Label DescripcionLabel;
    }
}