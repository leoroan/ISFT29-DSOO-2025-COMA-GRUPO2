namespace ClubDeportivo.Formularios
{
    partial class frmCarnet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            this.panelTitulo = new Panel();
            this.lblTitulo = new Label();
            this.panelContenido = new Panel();
            this.btnImprimir = new Button();
            this.lblFecha = new Label();
            this.lblNombre = new Label();
            this.lblNumero = new Label();
            this.pbIcono = new PictureBox();

            this.panelTitulo.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pbIcono).BeginInit();
            this.SuspendLayout();

            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = Color.FromArgb(0, 102, 204);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = DockStyle.Top;
            this.panelTitulo.Height = 70;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "🏅 CARNET DE SOCIO";
            this.lblTitulo.Dock = DockStyle.Fill;
            this.lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = Color.FromArgb(240, 248, 255);
            this.panelContenido.Dock = DockStyle.Fill;
            this.panelContenido.Padding = new Padding(20);
            this.panelContenido.Controls.Add(this.btnImprimir);
            this.panelContenido.Controls.Add(this.lblFecha);
            this.panelContenido.Controls.Add(this.lblNombre);
            this.panelContenido.Controls.Add(this.lblNumero);
            this.panelContenido.Controls.Add(this.pbIcono);

            // 
            // pbIcono
            // 
            this.pbIcono.Image = Properties.Resources.Socio; 
            this.pbIcono.Location = new Point(50, 100);
            this.pbIcono.Size = new Size(150, 150);
            this.pbIcono.SizeMode = PictureBoxSizeMode.Zoom;

            // 
            // lblNumero
            // 
            this.lblNumero.Location = new Point(230, 100);
            this.lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblNumero.ForeColor = Color.FromArgb(30, 30, 30);
            this.lblNumero.AutoSize = true;

            // 
            // lblNombre
            // 
            this.lblNombre.Location = new Point(230, 140);
            this.lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblNombre.ForeColor = Color.Black;
            this.lblNombre.AutoSize = true;

            // 
            // lblFecha
            // 
            this.lblFecha.Location = new Point(230, 180);
            this.lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblFecha.ForeColor = Color.Black;
            this.lblFecha.AutoSize = true;

            // 
            // btnImprimir
            // 
            this.btnImprimir.Text = "🖨️ Imprimir Carnet";
            this.btnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.btnImprimir.BackColor = Color.FromArgb(0, 102, 204);
            this.btnImprimir.ForeColor = Color.White;
            this.btnImprimir.FlatStyle = FlatStyle.Flat;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Location = new Point(230, 250);
            this.btnImprimir.Size = new Size(200, 45);
            this.btnImprimir.Cursor = Cursors.Hand;
            this.btnImprimir.Click += new EventHandler(this.btnImprimir_Click);

            // 
            // frmCarnet
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(600, 400);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelTitulo);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Carnet de Socio";
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Load += new EventHandler(this.frmCarnet_Load);

            this.panelTitulo.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.pbIcono).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panelContenido;
        private Button btnImprimir;
        private Label lblFecha;
        private Label lblNombre;
        private Label lblNumero;
        private PictureBox pbIcono;
    }
}