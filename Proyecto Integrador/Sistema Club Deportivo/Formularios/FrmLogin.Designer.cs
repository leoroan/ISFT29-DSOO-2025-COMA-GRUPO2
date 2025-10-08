namespace ClubDeportivo.formularios
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnIngresar = new Button();
            txtPass = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 30);
            label3.Name = "label3";
            label3.Size = new Size(351, 45);
            label3.TabIndex = 13;
            label3.Text = "INGRESO AL SISTEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 161);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 12;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 110);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 11;
            label1.Text = "Usuario:";
            // 
            // BtnIngresar
            // 
            BtnIngresar.Location = new Point(321, 222);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(166, 34);
            BtnIngresar.TabIndex = 2;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(259, 179);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(317, 23);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(259, 130);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(317, 23);
            txtUsuario.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icono;
            pictureBox1.Location = new Point(24, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 286);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnIngresar;
        private TextBox txtPass;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
    }
}
