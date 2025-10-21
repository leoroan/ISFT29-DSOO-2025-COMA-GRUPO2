namespace ClubDeportivo.Formularios
{
    partial class frmCarnet
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
            lblFechaInscripcion = new Label();
            lblNombreSocio = new Label();
            lblNroCarnet = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnImprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFechaInscripcion
            // 
            lblFechaInscripcion.AutoSize = true;
            lblFechaInscripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaInscripcion.Location = new Point(202, 168);
            lblFechaInscripcion.Name = "lblFechaInscripcion";
            lblFechaInscripcion.Size = new Size(192, 28);
            lblFechaInscripcion.TabIndex = 17;
            lblFechaInscripcion.Text = "Fecha de Inscripcion:";
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreSocio.Location = new Point(202, 126);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(170, 28);
            lblNombreSocio.TabIndex = 16;
            lblNombreSocio.Text = "Nombre de Socio:";
            // 
            // lblNroCarnet
            // 
            lblNroCarnet.AutoSize = true;
            lblNroCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNroCarnet.Location = new Point(202, 86);
            lblNroCarnet.Name = "lblNroCarnet";
            lblNroCarnet.Size = new Size(139, 28);
            lblNroCarnet.TabIndex = 15;
            lblNroCarnet.Text = "Nro de Carnet:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(735, 147);
            label2.TabIndex = 13;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(735, 51);
            label1.TabIndex = 12;
            label1.Text = "CARNET DE SOCIO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carnet;
            pictureBox1.Location = new Point(25, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(325, 235);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(114, 29);
            btnImprimir.TabIndex = 19;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 276);
            Controls.Add(btnImprimir);
            Controls.Add(pictureBox1);
            Controls.Add(lblFechaInscripcion);
            Controls.Add(lblNombreSocio);
            Controls.Add(lblNroCarnet);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnet";
            Load += frmCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFechaInscripcion;
        private Label lblNombreSocio;
        private Label lblNroCarnet;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnImprimir;
    }
}