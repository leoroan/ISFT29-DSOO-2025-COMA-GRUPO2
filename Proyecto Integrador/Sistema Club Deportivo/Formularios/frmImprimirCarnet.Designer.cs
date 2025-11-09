namespace ClubDeportivo.Formularios
{
    partial class frmImprimirCarnet
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
            lblTitulo = new Label();
            pnlPrincipal = new Panel();
            label1 = new Label();
            cboTipoRegistro = new ComboBox();
            lblNumero = new Label();
            txtNro = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            btnImprimir = new Button();
            btnVolver = new Button();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(657, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏅  IMPRIMIR CARNET";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.None;
            pnlPrincipal.BackColor = Color.FromArgb(235, 245, 255);
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPrincipal.Controls.Add(label1);
            pnlPrincipal.Controls.Add(cboTipoRegistro);
            pnlPrincipal.Controls.Add(lblNumero);
            pnlPrincipal.Controls.Add(txtNro);
            pnlPrincipal.Controls.Add(btnBuscar);
            pnlPrincipal.Controls.Add(lblNombre);
            pnlPrincipal.Controls.Add(btnImprimir);
            pnlPrincipal.Controls.Add(btnVolver);
            pnlPrincipal.Location = new Point(57, 158);
            pnlPrincipal.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(540, 224);
            pnlPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 10;
            label1.Text = "Tipo de Persona";
            // 
            // cboTipoRegistro
            // 
            cboTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoRegistro.Location = new Point(191, 21);
            cboTipoRegistro.Name = "cboTipoRegistro";
            cboTipoRegistro.Size = new Size(130, 23);
            cboTipoRegistro.TabIndex = 9;
            cboTipoRegistro.SelectedIndexChanged += cboTipoRegistro_SelectedIndexChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semilight", 12F);
            lblNumero.Location = new Point(48, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 21);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNro
            // 
            txtNro.Font = new Font("Segoe UI", 11F);
            txtNro.Location = new Point(191, 66);
            txtNro.Margin = new Padding(3, 2, 3, 2);
            txtNro.MaxLength = 6;
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(132, 27);
            txtNro.TabIndex = 1;
            txtNro.KeyPress += txtNro_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 102, 204);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(336, 67);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 24);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 12F);
            lblNombre.Location = new Point(48, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 102, 204);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(23, 160);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(144, 36);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(220, 20, 60);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(369, 160);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 36);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Cerrar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmImprimirCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(657, 426);
            Controls.Add(lblTitulo);
            Controls.Add(pnlPrincipal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmImprimirCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            Load += frmPagar_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Panel pnlPrincipal;
        private Label lblNumero;
        private TextBox txtNro;
        private Button btnBuscar;
        private Label lblNombre;
        private Button btnImprimir;
        private Button btnVolver;
        private Label label1;
        private ComboBox cboTipoRegistro;
    }
}