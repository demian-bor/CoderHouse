namespace SistemaGestionUI.DialogVenta
{
    partial class DialogNuevaVenta
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
            ComentarioLabel = new Label();
            IDUsuarioLabel = new Label();
            Crear = new Button();
            Comentarios = new TextBox();
            IDUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)IDUsuario).BeginInit();
            SuspendLayout();
            // 
            // ComentarioLabel
            // 
            ComentarioLabel.AutoSize = true;
            ComentarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComentarioLabel.Location = new Point(65, 35);
            ComentarioLabel.Name = "ComentarioLabel";
            ComentarioLabel.Size = new Size(102, 21);
            ComentarioLabel.TabIndex = 0;
            ComentarioLabel.Text = "Comentarios:";
            // 
            // IDUsuarioLabel
            // 
            IDUsuarioLabel.AutoSize = true;
            IDUsuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDUsuarioLabel.Location = new Point(81, 67);
            IDUsuarioLabel.Name = "IDUsuarioLabel";
            IDUsuarioLabel.Size = new Size(86, 21);
            IDUsuarioLabel.TabIndex = 1;
            IDUsuarioLabel.Text = "ID Usuario:";
            // 
            // Crear
            // 
            Crear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Crear.Location = new Point(130, 99);
            Crear.Name = "Crear";
            Crear.Size = new Size(91, 32);
            Crear.TabIndex = 2;
            Crear.Text = "Crear";
            Crear.UseVisualStyleBackColor = true;
            Crear.Click += Crear_Click;
            // 
            // Comentarios
            // 
            Comentarios.Location = new Point(173, 37);
            Comentarios.Name = "Comentarios";
            Comentarios.Size = new Size(120, 23);
            Comentarios.TabIndex = 3;
            // 
            // IDUsuario
            // 
            IDUsuario.Location = new Point(173, 70);
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Size = new Size(120, 23);
            IDUsuario.TabIndex = 4;
            // 
            // DialogNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 158);
            Controls.Add(IDUsuario);
            Controls.Add(Comentarios);
            Controls.Add(Crear);
            Controls.Add(IDUsuarioLabel);
            Controls.Add(ComentarioLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogNuevaVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nueva Venta";
            Load += DialogNuevaVenta_Load;
            ((System.ComponentModel.ISupportInitialize)IDUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ComentarioLabel;
        private Label IDUsuarioLabel;
        private Button Crear;
        private TextBox Comentarios;
        private NumericUpDown IDUsuario;
    }
}