namespace ClubDeportivo.Formularios
{
    partial class frmListado
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private DataGridView dtgListado;
        private Panel panelCabecera;
        private Panel panelContenido;
        private Button btnCerrar;
        private Button btnExportar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtgListado = new DataGridView();
            lblTitulo = new Label();
            panelCabecera = new Panel();
            panelContenido = new Panel();
            btnCerrar = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgListado).BeginInit();
            panelCabecera.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // dtgListado
            // 
            dtgListado.AllowUserToAddRows = false;
            dtgListado.AllowUserToDeleteRows = false;
            dtgListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListado.BackgroundColor = Color.White;
            dtgListado.Location = new Point(20, 20);
            dtgListado.Name = "dtgListado";
            dtgListado.ReadOnly = true;
            dtgListado.Size = new Size(931, 514);
            dtgListado.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏆 LISTADO DE DEUDORES";
            // 
            // panelCabecera
            // 
            panelCabecera.BackColor = Color.FromArgb(0, 102, 204);
            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(974, 60);
            panelCabecera.TabIndex = 1;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(240, 244, 248);
            panelContenido.Controls.Add(dtgListado);
            panelContenido.Controls.Add(btnCerrar);
            panelContenido.Controls.Add(btnExportar);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 60);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(20);
            panelContenido.Size = new Size(974, 587);
            panelContenido.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.FromArgb(220, 53, 69);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(483, 540);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExportar.BackColor = Color.FromArgb(0, 120, 215);
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(345, 540);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(120, 35);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "📄 Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // frmListado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 647);
            Controls.Add(panelContenido);
            Controls.Add(panelCabecera);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Deudores";
            Load += frmListado_Load;
            ((System.ComponentModel.ISupportInitialize)dtgListado).EndInit();
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelContenido.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}