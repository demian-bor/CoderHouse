namespace SistemaGestionUI
{
    partial class DialogBuscarUsuario
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
            IDLabel = new Label();
            IDSelection = new NumericUpDown();
            IDConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)IDSelection).BeginInit();
            SuspendLayout();
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(67, 39);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(99, 21);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "Ingresa el ID:";
            // 
            // IDSelection
            // 
            IDSelection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IDSelection.Location = new Point(58, 76);
            IDSelection.Name = "IDSelection";
            IDSelection.Size = new Size(120, 27);
            IDSelection.TabIndex = 1;
            // 
            // IDConfirm
            // 
            IDConfirm.Location = new Point(67, 120);
            IDConfirm.Name = "IDConfirm";
            IDConfirm.Size = new Size(102, 41);
            IDConfirm.TabIndex = 2;
            IDConfirm.Text = "Buscar";
            IDConfirm.UseVisualStyleBackColor = true;
            IDConfirm.Click += IDConfirm_Click;
            // 
            // DialogBuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 199);
            Controls.Add(IDConfirm);
            Controls.Add(IDSelection);
            Controls.Add(IDLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogBuscarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar por ID";
            Load += DialogBuscarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)IDSelection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDLabel;
        private NumericUpDown IDSelection;
        private Button IDConfirm;
    }
}