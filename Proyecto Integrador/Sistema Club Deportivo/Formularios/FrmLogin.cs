using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                MessageBox.Show("Ingreso exitoso","Ingreso Al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto", "Ingreso Al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
