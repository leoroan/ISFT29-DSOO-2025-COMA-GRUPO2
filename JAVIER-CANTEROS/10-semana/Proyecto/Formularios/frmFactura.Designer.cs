namespace Proyecto.Formularios
{
    partial class frmFactura
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
            btnImprimir = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblDfecha = new Label();
            label4 = new Label();
            lblAlumno = new Label();
            label6 = new Label();
            lblCurso = new Label();
            lblDia = new Label();
            lblFPago = new Label();
            lblValor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(279, 435);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 0;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(643, 39);
            label1.TabIndex = 1;
            label1.Text = "COMPROBANTE DE PAGO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 77);
            label2.Name = "label2";
            label2.Size = new Size(643, 111);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(229, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblDfecha
            // 
            lblDfecha.AutoSize = true;
            lblDfecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDfecha.Location = new Point(379, 93);
            lblDfecha.Name = "lblDfecha";
            lblDfecha.Size = new Size(53, 21);
            lblDfecha.TabIndex = 4;
            lblDfecha.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(379, 147);
            label4.Name = "label4";
            label4.Size = new Size(267, 21);
            label4.TabIndex = 5;
            label4.Text = "Datos Generales del  Instituto Tecnico";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(58, 225);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(149, 21);
            lblAlumno.TabIndex = 6;
            lblAlumno.Text = "Margarita Vlemman";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 199);
            label6.Name = "label6";
            label6.Size = new Size(643, 229);
            label6.TabIndex = 7;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurso.Location = new Point(58, 267);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(151, 21);
            lblCurso.TabIndex = 8;
            lblCurso.Text = "Se inscribio al curso:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(58, 306);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(148, 21);
            lblDia.TabIndex = 9;
            lblDia.Text = "Fecha de Comienzo:";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFPago.Location = new Point(61, 352);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(117, 21);
            lblFPago.TabIndex = 10;
            lblFPago.Text = "Forma de Pago:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(379, 352);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(59, 21);
            lblValor.TabIndex = 11;
            lblValor.Text = "Monto:";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 470);
            Controls.Add(lblValor);
            Controls.Add(lblFPago);
            Controls.Add(lblDia);
            Controls.Add(lblCurso);
            Controls.Add(lblAlumno);
            Controls.Add(label4);
            Controls.Add(lblDfecha);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnImprimir);
            Controls.Add(label6);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFactura";
            Load += frmFactura_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImprimir;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblDfecha;
        private Label label4;
        private Label lblAlumno;
        private Label label6;
        private Label lblCurso;
        private Label lblDia;
        private Label lblFPago;
        private Label lblValor;
    }
}