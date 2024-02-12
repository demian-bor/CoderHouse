namespace SistemaGestionUI.DialogProducto
{
    partial class DialogBuscarProducto
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
            IDProductoLabel = new Label();
            SelectedID = new NumericUpDown();
            SearchID = new Button();
            ((System.ComponentModel.ISupportInitialize)SelectedID).BeginInit();
            SuspendLayout();
            // 
            // IDProductoLabel
            // 
            IDProductoLabel.AutoSize = true;
            IDProductoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDProductoLabel.Location = new Point(72, 47);
            IDProductoLabel.Name = "IDProductoLabel";
            IDProductoLabel.Size = new Size(99, 21);
            IDProductoLabel.TabIndex = 0;
            IDProductoLabel.Text = "Ingrese el ID:";
            // 
            // SelectedID
            // 
            SelectedID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SelectedID.Location = new Point(61, 86);
            SelectedID.Name = "SelectedID";
            SelectedID.Size = new Size(120, 27);
            SelectedID.TabIndex = 1;
            // 
            // SearchID
            // 
            SearchID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchID.Location = new Point(77, 132);
            SearchID.Name = "SearchID";
            SearchID.Size = new Size(90, 33);
            SearchID.TabIndex = 2;
            SearchID.Text = "Buscar";
            SearchID.UseVisualStyleBackColor = true;
            SearchID.Click += SearchID_Click;
            // 
            // DialogBuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 209);
            Controls.Add(SearchID);
            Controls.Add(SelectedID);
            Controls.Add(IDProductoLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DialogBuscarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar por Id";
            Load += DialogBuscarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)SelectedID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDProductoLabel;
        private NumericUpDown SelectedID;
        private Button SearchID;
    }
}