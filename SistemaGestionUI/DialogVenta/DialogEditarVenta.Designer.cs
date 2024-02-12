namespace SistemaGestionUI.DialogVenta
{
    partial class DialogEditarVenta
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
            IDUsuarioLabel = new Label();
            EditarVenta = new Button();
            Descripcion = new TextBox();
            IDUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)IDUsuario).BeginInit();
            SuspendLayout();
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescripcionLabel.Location = new Point(65, 38);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new Size(94, 21);
            DescripcionLabel.TabIndex = 0;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // IDUsuarioLabel
            // 
            IDUsuarioLabel.AutoSize = true;
            IDUsuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDUsuarioLabel.Location = new Point(73, 74);
            IDUsuarioLabel.Name = "IDUsuarioLabel";
            IDUsuarioLabel.Size = new Size(86, 21);
            IDUsuarioLabel.TabIndex = 1;
            IDUsuarioLabel.Text = "ID Usuario:";
            // 
            // EditarVenta
            // 
            EditarVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditarVenta.Location = new Point(113, 108);
            EditarVenta.Name = "EditarVenta";
            EditarVenta.Size = new Size(91, 33);
            EditarVenta.TabIndex = 2;
            EditarVenta.Text = "Guardar";
            EditarVenta.UseVisualStyleBackColor = true;
            EditarVenta.Click += EditarVenta_Click;
            // 
            // Descripcion
            // 
            Descripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Descripcion.Location = new Point(165, 38);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(120, 27);
            Descripcion.TabIndex = 3;
            // 
            // IDUsuario
            // 
            IDUsuario.Location = new Point(165, 74);
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Size = new Size(120, 23);
            IDUsuario.TabIndex = 4;
            // 
            // DialogEditarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 165);
            Controls.Add(IDUsuario);
            Controls.Add(Descripcion);
            Controls.Add(EditarVenta);
            Controls.Add(IDUsuarioLabel);
            Controls.Add(DescripcionLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogEditarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Venta";
            Load += DialogEditarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)IDUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DescripcionLabel;
        private Label IDUsuarioLabel;
        private Button EditarVenta;
        private TextBox Descripcion;
        private NumericUpDown IDUsuario;
    }
}