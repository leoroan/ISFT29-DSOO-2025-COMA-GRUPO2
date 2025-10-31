namespace ClubDeportivo.Formularios
{
    partial class frmListado
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
            dtgListado = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListado).BeginInit();
            SuspendLayout();
            // 
            // dtgListado
            // 
            dtgListado.AllowUserToAddRows = false;
            dtgListado.AllowUserToDeleteRows = false;
            dtgListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListado.Location = new Point(12, 36);
            dtgListado.Name = "dtgListado";
            dtgListado.ReadOnly = true;
            dtgListado.Size = new Size(776, 363);
            dtgListado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(13, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Listado de Deudores a la fecha:";
            // 
            // frmListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 408);
            Controls.Add(lblTitulo);
            Controls.Add(dtgListado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado";
            Load += frmListado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgListado;
        private Label lblTitulo;
    }
}