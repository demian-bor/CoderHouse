namespace SistemaGestionUI.DialogVenta
{
    partial class DialogBuscarVenta
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
            VentaIdLabel = new Label();
            IDSelection = new NumericUpDown();
            BuscarVenta = new Button();
            ((System.ComponentModel.ISupportInitialize)IDSelection).BeginInit();
            SuspendLayout();
            // 
            // VentaIdLabel
            // 
            VentaIdLabel.AutoSize = true;
            VentaIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VentaIdLabel.Location = new Point(76, 40);
            VentaIdLabel.Name = "VentaIdLabel";
            VentaIdLabel.Size = new Size(99, 21);
            VentaIdLabel.TabIndex = 0;
            VentaIdLabel.Text = "Ingrese el ID:";
            // 
            // IDSelection
            // 
            IDSelection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            IDSelection.Location = new Point(66, 83);
            IDSelection.Name = "IDSelection";
            IDSelection.Size = new Size(120, 27);
            IDSelection.TabIndex = 1;
            // 
            // BuscarVenta
            // 
            BuscarVenta.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarVenta.Location = new Point(80, 125);
            BuscarVenta.Name = "BuscarVenta";
            BuscarVenta.Size = new Size(89, 37);
            BuscarVenta.TabIndex = 2;
            BuscarVenta.Text = "Buscar";
            BuscarVenta.UseVisualStyleBackColor = true;
            BuscarVenta.Click += BuscarVenta_Click;
            // 
            // DialogBuscarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 195);
            Controls.Add(BuscarVenta);
            Controls.Add(IDSelection);
            Controls.Add(VentaIdLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogBuscarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Venta";
            Load += DialogBuscarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)IDSelection).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VentaIdLabel;
        private NumericUpDown IDSelection;
        private Button BuscarVenta;
    }
}