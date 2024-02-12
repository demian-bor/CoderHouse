namespace SistemaGestionUI
{
    partial class DialogEditarUsuario
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
            CrearUsr = new Button();
            CorreoLabel = new Label();
            ContrasenaLabel = new Label();
            UserLabel = new Label();
            ApellidoLabel = new Label();
            NameLabel = new Label();
            CorreoInput = new TextBox();
            ContrasenaInput = new TextBox();
            UsuarioInput = new TextBox();
            ApellidoInput = new TextBox();
            NombreInput = new TextBox();
            SuspendLayout();
            // 
            // CrearUsr
            // 
            CrearUsr.Location = new Point(123, 194);
            CrearUsr.Name = "CrearUsr";
            CrearUsr.Size = new Size(99, 40);
            CrearUsr.TabIndex = 32;
            CrearUsr.Text = "Modificar";
            CrearUsr.UseVisualStyleBackColor = true;
            CrearUsr.Click += CrearUsr_Click;
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CorreoLabel.Location = new Point(92, 153);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(61, 21);
            CorreoLabel.TabIndex = 31;
            CorreoLabel.Text = "Correo:";
            // 
            // ContrasenaLabel
            // 
            ContrasenaLabel.AutoSize = true;
            ContrasenaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContrasenaLabel.Location = new Point(61, 125);
            ContrasenaLabel.Name = "ContrasenaLabel";
            ContrasenaLabel.Size = new Size(92, 21);
            ContrasenaLabel.TabIndex = 30;
            ContrasenaLabel.Text = "Contraseña:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLabel.Location = new Point(86, 96);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(67, 21);
            UserLabel.TabIndex = 29;
            UserLabel.Text = "Usuario:";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApellidoLabel.Location = new Point(83, 68);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(70, 21);
            ApellidoLabel.TabIndex = 28;
            ApellidoLabel.Text = "Apellido:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(82, 38);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(71, 21);
            NameLabel.TabIndex = 27;
            NameLabel.Text = "Nombre:";
            // 
            // CorreoInput
            // 
            CorreoInput.Location = new Point(159, 154);
            CorreoInput.Name = "CorreoInput";
            CorreoInput.Size = new Size(100, 23);
            CorreoInput.TabIndex = 26;
            // 
            // ContrasenaInput
            // 
            ContrasenaInput.Location = new Point(159, 125);
            ContrasenaInput.Name = "ContrasenaInput";
            ContrasenaInput.PasswordChar = '*';
            ContrasenaInput.Size = new Size(100, 23);
            ContrasenaInput.TabIndex = 25;
            // 
            // UsuarioInput
            // 
            UsuarioInput.Location = new Point(159, 96);
            UsuarioInput.Name = "UsuarioInput";
            UsuarioInput.Size = new Size(100, 23);
            UsuarioInput.TabIndex = 24;
            // 
            // ApellidoInput
            // 
            ApellidoInput.Location = new Point(159, 67);
            ApellidoInput.Name = "ApellidoInput";
            ApellidoInput.Size = new Size(100, 23);
            ApellidoInput.TabIndex = 23;
            // 
            // NombreInput
            // 
            NombreInput.Location = new Point(159, 38);
            NombreInput.Name = "NombreInput";
            NombreInput.Size = new Size(100, 23);
            NombreInput.TabIndex = 22;
            // 
            // DialogEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 263);
            Controls.Add(CrearUsr);
            Controls.Add(CorreoLabel);
            Controls.Add(ContrasenaLabel);
            Controls.Add(UserLabel);
            Controls.Add(ApellidoLabel);
            Controls.Add(NameLabel);
            Controls.Add(CorreoInput);
            Controls.Add(ContrasenaInput);
            Controls.Add(UsuarioInput);
            Controls.Add(ApellidoInput);
            Controls.Add(NombreInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogEditarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Usuario";
            Load += DialogEditarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CrearUsr;
        private Label CorreoLabel;
        private Label ContrasenaLabel;
        private Label UserLabel;
        private Label ApellidoLabel;
        private Label NameLabel;
        private TextBox CorreoInput;
        private TextBox ContrasenaInput;
        private TextBox UsuarioInput;
        private TextBox ApellidoInput;
        private TextBox NombreInput;
    }
}