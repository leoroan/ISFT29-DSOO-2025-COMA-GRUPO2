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
            this.pnlMain = new Panel();
            this.lblTitulo = new Label();
            this.txtUsuario = new TextBox();
            this.txtPass = new TextBox();
            this.labelUsuario = new Label();
            this.labelPassword = new Label();
            this.BtnIngresar = new Button();
            this.pictureBox1 = new PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(700, 380);
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.Text = "Inicio de Sesión - Club Deportivo";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Paint += new PaintEventHandler(this.FrmLogin_Paint);

            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = AnchorStyles.None;
            this.pnlMain.BackColor = Color.White;
            this.pnlMain.BorderStyle = BorderStyle.FixedSingle;
            this.pnlMain.Location = new Point(160, 70);
            this.pnlMain.Size = new Size(380, 250);
            this.pnlMain.Controls.Add(this.lblTitulo);
            this.pnlMain.Controls.Add(this.txtUsuario);
            this.pnlMain.Controls.Add(this.txtPass);
            this.pnlMain.Controls.Add(this.labelUsuario);
            this.pnlMain.Controls.Add(this.labelPassword);
            this.pnlMain.Controls.Add(this.BtnIngresar);

            // 
            // lblTitulo
            // 
            this.lblTitulo.Text = "🏆 CLUB DEPORTIVO";
            this.lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTitulo.ForeColor = Color.FromArgb(0, 51, 102);
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitulo.Dock = DockStyle.Top;
            this.lblTitulo.Height = 60;

            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtUsuario.Location = new Point(50, 100);
            this.txtUsuario.Width = 280;
            this.txtUsuario.PlaceholderText = "Ingrese su usuario";

            // 
            // txtPass
            // 
            this.txtPass.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.txtPass.Location = new Point(50, 150);
            this.txtPass.Width = 280;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.PlaceholderText = "Ingrese su contraseña";

            // 
            // labelUsuario
            // 
            this.labelUsuario.Text = "Usuario:";
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new Point(50, 80);
            this.labelUsuario.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.labelUsuario.ForeColor = Color.FromArgb(50, 50, 50);

            // 
            // labelPassword
            // 
            this.labelPassword.Text = "Contraseña:";
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new Point(50, 130);
            this.labelPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.labelPassword.ForeColor = Color.FromArgb(50, 50, 50);

            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.BtnIngresar.Size = new Size(280, 40);
            this.BtnIngresar.Location = new Point(50, 200);
            this.BtnIngresar.FlatStyle = FlatStyle.Flat;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.BackColor = Color.FromArgb(0, 102, 204);
            this.BtnIngresar.ForeColor = Color.White;
            this.BtnIngresar.Cursor = Cursors.Hand;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.BtnIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 160);

            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Properties.Resources.Icono;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Location = new Point(30, 100);
            this.pictureBox1.Size = new Size(120, 120);

            // 
            // FrmLogin (final)
            // 
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.ResumeLayout(false);
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
