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
            panelTitulo = new Panel();
            lblTipoCarnet = new Label();
            panelContenido = new Panel();
            lblDni = new Label();
            btnImprimir = new Button();
            lblFecha = new Label();
            lblNombre = new Label();
            lblNumero = new Label();
            pbIcono = new PictureBox();
            panelTitulo.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).BeginInit();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(0, 102, 204);
            panelTitulo.Controls.Add(lblTipoCarnet);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Margin = new Padding(3, 2, 3, 2);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(525, 52);
            panelTitulo.TabIndex = 1;
            // 
            // lblTipoCarnet
            // 
            lblTipoCarnet.Dock = DockStyle.Fill;
            lblTipoCarnet.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTipoCarnet.ForeColor = Color.White;
            lblTipoCarnet.Location = new Point(0, 0);
            lblTipoCarnet.Name = "lblTipoCarnet";
            lblTipoCarnet.Size = new Size(525, 52);
            lblTipoCarnet.TabIndex = 0;
            lblTipoCarnet.Text = "🏅 CARNET";
            lblTipoCarnet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(240, 248, 255);
            panelContenido.Controls.Add(lblDni);
            panelContenido.Controls.Add(btnImprimir);
            panelContenido.Controls.Add(lblFecha);
            panelContenido.Controls.Add(lblNombre);
            panelContenido.Controls.Add(lblNumero);
            panelContenido.Controls.Add(pbIcono);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 52);
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Padding = new Padding(18, 15, 18, 15);
            panelContenido.Size = new Size(525, 268);
            panelContenido.TabIndex = 0;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.ForeColor = Color.Black;
            lblDni.Location = new Point(201, 135);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 21);
            lblDni.TabIndex = 5;
            lblDni.Text = "dni";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 102, 204);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(201, 212);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(175, 34);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "🖨️ Imprimir Carnet";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.ForeColor = Color.Black;
            lblFecha.Location = new Point(201, 166);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 21);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "fecha";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(201, 105);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "nombre";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumero.ForeColor = Color.FromArgb(30, 30, 30);
            lblNumero.Location = new Point(201, 75);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(122, 21);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "carnet numero";
            // 
            // pbIcono
            // 
            pbIcono.Image = Properties.Resources.Socio;
            pbIcono.Location = new Point(44, 75);
            pbIcono.Margin = new Padding(3, 2, 3, 2);
            pbIcono.Name = "pbIcono";
            pbIcono.Size = new Size(131, 112);
            pbIcono.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcono.TabIndex = 4;
            pbIcono.TabStop = false;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 320);
            Controls.Add(panelContenido);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            Load += frmCarnet_Load;
            panelTitulo.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcono).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelTitulo;
        private Label lblTipoCarnet;
        private Panel panelContenido;
        private Button btnImprimir;
        private Label lblFecha;
        private Label lblNombre;
        private Label lblNumero;
        private PictureBox pbIcono;
        private Label lblDni;
    }
}