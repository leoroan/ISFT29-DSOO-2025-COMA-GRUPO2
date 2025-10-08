using ClubDeportivo.Formularios;
using System.Data;

namespace ClubDeportivo.formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que  contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso","Ingreso al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frmPrincipal Principal = new frmPrincipal();
                Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                Principal.usuario = Convert.ToString(txtUsuario.Text);
                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login

            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
