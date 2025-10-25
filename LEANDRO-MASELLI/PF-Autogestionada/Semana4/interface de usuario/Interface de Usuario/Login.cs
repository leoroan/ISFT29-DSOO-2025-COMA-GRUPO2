using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPostulantesForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void MostrarMensajeUsuarioInexistente()
        {
            MessageBox.Show(
                "Usuario inexistente.\nVerifique su nombre de usuario y contraseña.",
                "Error de autenticación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_nombreUsuario.Text;
            string password = textBox_contrasenia.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete ambos campos.");
                return;
            }

            if (username == "Administrador" && password == "Admin1234")
            {
                this.Hide();
                Form principal = new Form1();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
            }
            else
            {
                MostrarMensajeUsuarioInexistente();
            }
        }
    }
}
