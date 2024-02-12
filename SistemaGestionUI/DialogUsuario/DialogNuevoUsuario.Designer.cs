﻿namespace SistemaGestionUI
{
    partial class DialogNuevoUsuario
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
            CrearUsr.Location = new Point(107, 189);
            CrearUsr.Name = "CrearUsr";
            CrearUsr.Size = new Size(99, 40);
            CrearUsr.TabIndex = 21;
            CrearUsr.Text = "Crear";
            CrearUsr.UseVisualStyleBackColor = true;
            CrearUsr.Click += CrearUsr_Click;
            // 
            // CorreoLabel
            // 
            CorreoLabel.AutoSize = true;
            CorreoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CorreoLabel.Location = new Point(76, 148);
            CorreoLabel.Name = "CorreoLabel";
            CorreoLabel.Size = new Size(61, 21);
            CorreoLabel.TabIndex = 20;
            CorreoLabel.Text = "Correo:";
            // 
            // ContrasenaLabel
            // 
            ContrasenaLabel.AutoSize = true;
            ContrasenaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ContrasenaLabel.Location = new Point(45, 120);
            ContrasenaLabel.Name = "ContrasenaLabel";
            ContrasenaLabel.Size = new Size(92, 21);
            ContrasenaLabel.TabIndex = 19;
            ContrasenaLabel.Text = "Contraseña:";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserLabel.Location = new Point(70, 91);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(67, 21);
            UserLabel.TabIndex = 18;
            UserLabel.Text = "Usuario:";
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ApellidoLabel.Location = new Point(67, 63);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(70, 21);
            ApellidoLabel.TabIndex = 17;
            ApellidoLabel.Text = "Apellido:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(66, 33);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(71, 21);
            NameLabel.TabIndex = 16;
            NameLabel.Text = "Nombre:";
            // 
            // CorreoInput
            // 
            CorreoInput.Location = new Point(143, 149);
            CorreoInput.Name = "CorreoInput";
            CorreoInput.Size = new Size(100, 23);
            CorreoInput.TabIndex = 15;
            // 
            // ContrasenaInput
            // 
            ContrasenaInput.Location = new Point(143, 120);
            ContrasenaInput.Name = "ContrasenaInput";
            ContrasenaInput.PasswordChar = '*';
            ContrasenaInput.Size = new Size(100, 23);
            ContrasenaInput.TabIndex = 14;
            // 
            // UsuarioInput
            // 
            UsuarioInput.Location = new Point(143, 91);
            UsuarioInput.Name = "UsuarioInput";
            UsuarioInput.Size = new Size(100, 23);
            UsuarioInput.TabIndex = 13;
            // 
            // ApellidoInput
            // 
            ApellidoInput.Location = new Point(143, 62);
            ApellidoInput.Name = "ApellidoInput";
            ApellidoInput.Size = new Size(100, 23);
            ApellidoInput.TabIndex = 12;
            // 
            // NombreInput
            // 
            NombreInput.Location = new Point(143, 33);
            NombreInput.Name = "NombreInput";
            NombreInput.Size = new Size(100, 23);
            NombreInput.TabIndex = 11;
            // 
            // DialogNuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 256);
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
            Name = "DialogNuevoUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Usuario";
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