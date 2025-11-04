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

            ((System.ComponentModel.ISupportInitialize)(dtgListado)).BeginInit();
            panelCabecera.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();

            // === PANEL CABECERA ===
            panelCabecera.BackColor = Color.FromArgb(0, 102, 204);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Height = 60;
            panelCabecera.Controls.Add(lblTitulo);

            // === LABEL TÍTULO ===
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "🏆 LISTADO DE DEUDORES";

            // === PANEL CONTENIDO ===
            panelContenido.BackColor = Color.FromArgb(240, 244, 248);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Padding = new Padding(20);
            panelContenido.Controls.Add(dtgListado);
            panelContenido.Controls.Add(btnCerrar);
            panelContenido.Controls.Add(btnExportar);

            // === DATAGRIDVIEW ===
            dtgListado.AllowUserToAddRows = false;
            dtgListado.AllowUserToDeleteRows = false;
            dtgListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListado.BackgroundColor = Color.White;
            dtgListado.BorderStyle = BorderStyle.FixedSingle;
            dtgListado.ReadOnly = true;
            dtgListado.Location = new Point(20, 20);
            dtgListado.Size = new Size(740, 290);
            dtgListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // === BOTONES ===
            btnExportar.Text = "📄 Exportar";
            btnExportar.BackColor = Color.FromArgb(0, 120, 215);
            btnExportar.ForeColor = Color.White;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Size = new Size(120, 35);
            btnExportar.Location = new Point(520, 330);
            btnExportar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            // (podrás asignarle luego un evento como Click)

            btnCerrar.Text = "Cerrar";
            btnCerrar.BackColor = Color.FromArgb(220, 53, 69);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Size = new Size(120, 35);
            btnCerrar.Location = new Point(660, 330);
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.Click += (s, e) => Close();

            // === FORMULARIO ===
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            BackColor = Color.White;
            Controls.Add(panelContenido);
            Controls.Add(panelCabecera);
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de Deudores";
            Load += frmListado_Load;

            ((System.ComponentModel.ISupportInitialize)(dtgListado)).EndInit();
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelContenido.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}