namespace RegistroPostulantesForm
{
    public partial class Form1 : Form
    {
        private Postulante PostulanteGlobal;
        private List<Postulante> listaPostulantes = new List<Postulante>();

        public Form1()
        {
            InitializeComponent();
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LimpiarCampos()
        {
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            comboBox_tipo.SelectedIndex = 0;
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
                string.IsNullOrWhiteSpace(numeroDocumento))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que numeroDocumento sea un número entero sin letras ni decimales
            if (!long.TryParse(numeroDocumento, out _))
            {
                MessageBox.Show("El número de documento debe ser un número entero sin letras ni decimales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PostulanteGlobal = new Postulante(nombre, apellido, tipoDocumento, numeroDocumento);

            listaPostulantes.Add(PostulanteGlobal);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaPostulantes;

            MessageBox.Show(PostulanteGlobal.ToString(), "Postulante cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            textBox_nombre.Text = string.Empty;
            textBox_apellido.Text = string.Empty;
            textBox_numeroDocumento.Text = string.Empty;
            comboBox_tipo.SelectedIndex = 0;
        }

        private void textBox_numeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MessageBox.Show((string)dataGridView1.Rows[e.RowIndex].Cells
                [1].Value);
            }
            else
            {
                MessageBox.Show("selecciono el ENCABEZADO");
            }

        }
    }
}
