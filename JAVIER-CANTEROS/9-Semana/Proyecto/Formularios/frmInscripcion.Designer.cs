namespace Proyecto.Formularios
{
    partial class frmInscripcion
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            cboTipo = new ComboBox();
            btnIngresar = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Alumno;
            pictureBox1.Location = new Point(-11, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 45);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 1;
            label1.Text = "INSCRIPCION DEL POSTULANTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(348, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(348, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(237, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(348, 213);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(237, 23);
            txtDocumento.TabIndex = 4;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(348, 174);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(237, 23);
            cboTipo.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(266, 269);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(390, 269);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(519, 269);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "VOLVER";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 90);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 133);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 182);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Tipo Doc.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 221);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Documento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(591, 86);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 13;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(591, 128);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 14;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(591, 182);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 15;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(591, 216);
            label9.Name = "label9";
            label9.Size = new Size(12, 15);
            label9.TabIndex = 16;
            label9.Text = "*";
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 340);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnIngresar);
            Controls.Add(cboTipo);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmInscripcion";
            Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private ComboBox cboTipo;
        private Button btnIngresar;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}