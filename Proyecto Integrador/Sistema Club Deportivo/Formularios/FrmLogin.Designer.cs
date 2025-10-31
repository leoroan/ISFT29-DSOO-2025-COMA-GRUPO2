namespace ClubDeportivo.formularios
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pnlMain = new Panel();
            lblTitulo = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            labelUsuario = new Label();
            labelPassword = new Label();
            BtnIngresar = new Button();
            pictureBox1 = new PictureBox();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.None;
            pnlMain.BackColor = Color.White;
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(lblTitulo);
            pnlMain.Controls.Add(txtUsuario);
            pnlMain.Controls.Add(txtPass);
            pnlMain.Controls.Add(labelUsuario);
            pnlMain.Controls.Add(labelPassword);
            pnlMain.Controls.Add(BtnIngresar);
            pnlMain.Location = new Point(160, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(380, 250);
            pnlMain.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(0, 51, 102);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(100, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏆 CLUB DEPORTIVO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(50, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(280, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.Text = "Admin2025";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(50, 150);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = "Ingrese su contraseña";
            txtPass.Size = new Size(280, 27);
            txtPass.TabIndex = 2;
            txtPass.Text = "123456";
            txtPass.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUsuario.ForeColor = Color.FromArgb(50, 50, 50);
            labelUsuario.Location = new Point(50, 80);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(60, 19);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPassword.ForeColor = Color.FromArgb(50, 50, 50);
            labelPassword.Location = new Point(50, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(82, 19);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Contraseña:";
            // 
            // BtnIngresar
            // 
            BtnIngresar.BackColor = Color.FromArgb(0, 102, 204);
            BtnIngresar.Cursor = Cursors.Hand;
            BtnIngresar.FlatAppearance.BorderSize = 0;
            BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 160);
            BtnIngresar.FlatStyle = FlatStyle.Flat;
            BtnIngresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            BtnIngresar.ForeColor = Color.White;
            BtnIngresar.Location = new Point(50, 200);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(280, 40);
            BtnIngresar.TabIndex = 5;
            BtnIngresar.Text = "INGRESAR";
            BtnIngresar.UseVisualStyleBackColor = false;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icono;
            pictureBox1.Location = new Point(30, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 380);
            Controls.Add(pictureBox1);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión - Club Deportivo";
            Load += FrmLogin_Load;
            Paint += FrmLogin_Paint;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblTitulo;
        private Label labelUsuario;
        private Label labelPassword;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button BtnIngresar;
        private PictureBox pictureBox1;
    }
}
