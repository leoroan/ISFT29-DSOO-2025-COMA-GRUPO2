namespace ClubDeportivo.Formularios
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            staSistema = new StatusStrip();
            tsbUsuario = new ToolStripStatusLabel();
            tsbRol = new ToolStripStatusLabel();
            btnRegistrarSocio = new Button();
            btnSalir = new Button();
            btnPagarCuota = new Button();
            btnImprimirCarnet = new Button();
            staSistema.SuspendLayout();
            SuspendLayout();
            // 
            // staSistema
            // 
            staSistema.ImageScalingSize = new Size(20, 20);
            staSistema.Items.AddRange(new ToolStripItem[] { tsbUsuario, tsbRol });
            staSistema.Location = new Point(0, 293);
            staSistema.Name = "staSistema";
            staSistema.Padding = new Padding(1, 0, 16, 0);
            staSistema.Size = new Size(566, 26);
            staSistema.TabIndex = 0;
            staSistema.Text = "statusStrip1";
            // 
            // tsbUsuario
            // 
            tsbUsuario.Name = "tsbUsuario";
            tsbUsuario.Size = new Size(62, 20);
            tsbUsuario.Text = "Usuario:";
            // 
            // tsbRol
            // 
            tsbRol.Name = "tsbRol";
            tsbRol.Size = new Size(34, 20);
            tsbRol.Text = "Rol:";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(97, 87);
            btnRegistrarSocio.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(175, 59);
            btnRegistrarSocio.TabIndex = 1;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(470, 258);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(72, 31);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(279, 87);
            btnPagarCuota.Margin = new Padding(3, 4, 3, 4);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(175, 59);
            btnPagarCuota.TabIndex = 3;
            btnPagarCuota.Text = "Pagar Cuota";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.Location = new Point(97, 154);
            btnImprimirCarnet.Margin = new Padding(3, 4, 3, 4);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(175, 59);
            btnImprimirCarnet.TabIndex = 4;
            btnImprimirCarnet.Text = "Imprimir Carnet";
            btnImprimirCarnet.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 319);
            Controls.Add(btnImprimirCarnet);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(staSistema);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Club Deportivo";
            Load += frmPrincipal_Load;
            staSistema.ResumeLayout(false);
            staSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip staSistema;
        private ToolStripStatusLabel tsbUsuario;
        private ToolStripStatusLabel tsbRol;
        private Button btnRegistrarSocio;
        private Button btnSalir;
        private Button btnPagarCuota;
        private Button btnImprimirCarnet;
    }
}