namespace Proyecto.Formularios
{
    partial class frmPagar
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
            txtNro = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(318, 156);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 11;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optTarjeta);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.Location = new Point(318, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(32, 56);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(59, 19);
            optTarjeta.TabIndex = 1;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Checked = true;
            optEfvo.Location = new Point(32, 31);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(67, 19);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // btnComprobante
            // 
            btnComprobante.Enabled = false;
            btnComprobante.Location = new Point(60, 172);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(113, 23);
            btnComprobante.TabIndex = 9;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(60, 129);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(113, 23);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(73, 65);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(100, 23);
            txtNro.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(286, 25);
            label1.TabIndex = 6;
            label1.Text = "Ingrese Numero de inscripcion";
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 219);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtNro);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PAGAR EL CURSO";
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
        private TextBox txtNro;
        private Label label1;
    }
}