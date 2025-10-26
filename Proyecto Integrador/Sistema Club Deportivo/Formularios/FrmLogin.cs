using ClubDeportivo.Formularios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo.formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsuario;
        }

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(0, 102, 204),
                Color.White,
                45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable();
            Datos.Usuarios dato = new Datos.Usuarios();
            tablaLogin = dato.Log_Usu(txtUsuario.Text.Trim(), txtPass.Text.Trim());

            if (tablaLogin.Rows.Count > 0)
            {
                MessageBox.Show("Ingreso exitoso ✅", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPrincipal Principal = new frmPrincipal
                {
                    rol = Convert.ToString(tablaLogin.Rows[0][0]),
                    usuario = txtUsuario.Text
                };
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUsuario.Focus();
            }
        }
    }
}