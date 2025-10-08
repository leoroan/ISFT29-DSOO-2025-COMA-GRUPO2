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
            staSistema.SuspendLayout();
            SuspendLayout();
            // 
            // staSistema
            // 
            staSistema.Items.AddRange(new ToolStripItem[] { tsbUsuario, tsbRol });
            staSistema.Location = new Point(0, 173);
            staSistema.Name = "staSistema";
            staSistema.Size = new Size(311, 22);
            staSistema.TabIndex = 0;
            staSistema.Text = "statusStrip1";
            // 
            // tsbUsuario
            // 
            tsbUsuario.Name = "tsbUsuario";
            tsbUsuario.Size = new Size(50, 17);
            tsbUsuario.Text = "Usuario:";
            // 
            // tsbRol
            // 
            tsbRol.Name = "tsbRol";
            tsbRol.Size = new Size(27, 17);
            tsbRol.Text = "Rol:";
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(85, 65);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(153, 44);
            btnRegistrarSocio.TabIndex = 1;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(236, 147);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(63, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 195);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(staSistema);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
    }
}