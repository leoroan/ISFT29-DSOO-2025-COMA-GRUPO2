namespace ClubDeportivo.Formularios
{
    partial class frmPagarCuota
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
            btnVolver = new Button();
            groupBox1 = new GroupBox();
            optTarjeta = new RadioButton();
            optEfvo = new RadioButton();
            btnComprobante = new Button();
            btnPagar = new Button();
            txtNroSocio = new TextBox();
            label1 = new Label();
            btnBuscarSocio = new Button();
            lblNombreSocio = new Label();
            lblPrecioCuota = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(416, 274);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 17;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optTarjeta);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.Location = new Point(12, 133);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(267, 133);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(37, 76);
            optTarjeta.Margin = new Padding(3, 4, 3, 4);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(74, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Checked = true;
            optEfvo.Location = new Point(37, 42);
            optEfvo.Margin = new Padding(3, 4, 3, 4);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(83, 24);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(165, 274);
            btnComprobante.Margin = new Padding(3, 4, 3, 4);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(129, 31);
            btnComprobante.TabIndex = 15;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(12, 274);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(129, 31);
            btnPagar.TabIndex = 14;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(165, 17);
            txtNroSocio.Margin = new Padding(3, 4, 3, 4);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(114, 27);
            txtNroSocio.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 12;
            label1.Text = "Numero de Socio:";
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Location = new Point(295, 18);
            btnBuscarSocio.Margin = new Padding(3, 4, 3, 4);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(86, 31);
            btnBuscarSocio.TabIndex = 18;
            btnBuscarSocio.Text = "Buscar";
            btnBuscarSocio.UseVisualStyleBackColor = true;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreSocio.Location = new Point(12, 57);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(147, 23);
            lblNombreSocio.TabIndex = 19;
            lblNombreSocio.Text = "Nombre de Socio:";
            // 
            // lblPrecioCuota
            // 
            lblPrecioCuota.AutoSize = true;
            lblPrecioCuota.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioCuota.Location = new Point(12, 91);
            lblPrecioCuota.Name = "lblPrecioCuota";
            lblPrecioCuota.Size = new Size(112, 23);
            lblPrecioCuota.TabIndex = 20;
            lblPrecioCuota.Text = "Precio Cuota:";
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 331);
            Controls.Add(lblPrecioCuota);
            Controls.Add(lblNombreSocio);
            Controls.Add(btnBuscarSocio);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtNroSocio);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private GroupBox groupBox1;
        private RadioButton optTarjeta;
        private RadioButton optEfvo;
        private Button btnComprobante;
        private Button btnPagar;
        private TextBox txtNroSocio;
        private Label label1;
        private Button btnBuscarSocio;
        private Label lblNombreSocio;
        private Label lblPrecioCuota;
    }
}