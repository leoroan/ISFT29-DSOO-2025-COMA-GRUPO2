namespace Proyecto.Formularios
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
            lblIngreso = new Label();
            btnInscribir = new Button();
            btnAsignarCurso = new Button();
            btnPagarCurso = new Button();
            button4 = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(36, 25);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(38, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "label1";
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(106, 94);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(203, 69);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir Postulante";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnAsignarCurso
            // 
            btnAsignarCurso.Location = new Point(368, 94);
            btnAsignarCurso.Name = "btnAsignarCurso";
            btnAsignarCurso.Size = new Size(203, 69);
            btnAsignarCurso.TabIndex = 2;
            btnAsignarCurso.Text = "Asignar Curso";
            btnAsignarCurso.UseVisualStyleBackColor = true;
            btnAsignarCurso.Click += btnAsignarCurso_Click;
            // 
            // btnPagarCurso
            // 
            btnPagarCurso.Location = new Point(106, 191);
            btnPagarCurso.Name = "btnPagarCurso";
            btnPagarCurso.Size = new Size(203, 69);
            btnPagarCurso.TabIndex = 3;
            btnPagarCurso.Text = "Pagar Curso";
            btnPagarCurso.UseVisualStyleBackColor = true;
            btnPagarCurso.Click += btnPagarCurso_Click;
            // 
            // button4
            // 
            button4.Location = new Point(368, 191);
            button4.Name = "button4";
            button4.Size = new Size(203, 69);
            button4.TabIndex = 4;
            button4.Text = "Emitir comprobante de Curso";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(449, 11);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 300);
            Controls.Add(btnSalir);
            Controls.Add(button4);
            Controls.Add(btnPagarCurso);
            Controls.Add(btnAsignarCurso);
            Controls.Add(btnInscribir);
            Controls.Add(lblIngreso);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventana Principal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnInscribir;
        private Button btnAsignarCurso;
        private Button btnPagarCurso;
        private Button button4;
        private Button btnSalir;
    }
}