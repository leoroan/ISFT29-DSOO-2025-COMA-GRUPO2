namespace RegistroPostulantesForm
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label_nombreUsuario = new Label();
            label_contrasenia = new Label();
            textBox_nombreUsuario = new TextBox();
            textBox_contrasenia = new TextBox();
            button_login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_nombreUsuario
            // 
            label_nombreUsuario.AutoSize = true;
            label_nombreUsuario.Location = new Point(265, 46);
            label_nombreUsuario.Name = "label_nombreUsuario";
            label_nombreUsuario.Size = new Size(166, 25);
            label_nombreUsuario.TabIndex = 1;
            label_nombreUsuario.Text = "Nombre de usuario";
            label_nombreUsuario.Click += label1_Click;
            // 
            // label_contrasenia
            // 
            label_contrasenia.AutoSize = true;
            label_contrasenia.Location = new Point(265, 121);
            label_contrasenia.Name = "label_contrasenia";
            label_contrasenia.Size = new Size(101, 25);
            label_contrasenia.TabIndex = 2;
            label_contrasenia.Text = "Contraseña";
            // 
            // textBox_nombreUsuario
            // 
            textBox_nombreUsuario.Location = new Point(345, 74);
            textBox_nombreUsuario.Name = "textBox_nombreUsuario";
            textBox_nombreUsuario.Size = new Size(150, 31);
            textBox_nombreUsuario.TabIndex = 3;
            // 
            // textBox_contrasenia
            // 
            textBox_contrasenia.Location = new Point(345, 149);
            textBox_contrasenia.Name = "textBox_contrasenia";
            textBox_contrasenia.Size = new Size(150, 31);
            textBox_contrasenia.TabIndex = 4;
            textBox_contrasenia.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Location = new Point(383, 212);
            button_login.Name = "button_login";
            button_login.Size = new Size(112, 34);
            button_login.TabIndex = 5;
            button_login.Text = "Ingresar";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(553, 294);
            Controls.Add(button_login);
            Controls.Add(textBox_contrasenia);
            Controls.Add(textBox_nombreUsuario);
            Controls.Add(label_contrasenia);
            Controls.Add(label_nombreUsuario);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label_nombreUsuario;
        private Label label_contrasenia;
        private TextBox textBox_nombreUsuario;
        private TextBox textBox_contrasenia;
        private Button button_login;
    }
}