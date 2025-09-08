namespace RegistroPostulantesForm
{
    public partial class Form1 : Form
    {
        private Postulante PostulanteGlobal;
        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            comboBox_tipo.SelectedIndex = -1;
            textBox_numeroDocumento.Text = string.Empty;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_Dni_Click(object sender, EventArgs e)
        {

        }
        private void label_Tipo_Click(object sender, EventArgs e)
        {

        }
        private void label_Num_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (comboBox_tipo.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, seleccione un tipo de documento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = textBox_nombre.Text;
            string apellido = textBox_apellido.Text;
            string tipoDocumento = comboBox_tipo.Text;
            string numeroDocumento = textBox_numeroDocumento.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(tipoDocumento) ||
                string.IsNullOrWhiteSpace(numeroDocumento))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PostulanteGlobal = new Postulante(nombre, apellido, tipoDocumento, numeroDocumento);

            MessageBox.Show(PostulanteGlobal.ToString(), "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            comboBox_tipo.SelectedIndex = -1;
            textBox_numeroDocumento.Text = string.Empty;
            MessageBox.Show("Campos limpiados", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_numeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
