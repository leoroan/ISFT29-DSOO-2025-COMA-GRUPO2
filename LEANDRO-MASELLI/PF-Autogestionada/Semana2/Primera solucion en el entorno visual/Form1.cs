namespace PrimerProyecto
{
    public partial class Formulario1 : Form
    {
        private Persona personaGlobal;
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();
            string edadStr = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(edadStr))
            {
                MessageBox.Show("¡Hola!");
            }
            else
            {
                int edad = 0;
                int.TryParse(edadStr, out edad);

                // Crear instancia de Persona
                personaGlobal = new Persona(nombre, edad);
                MessageBox.Show(personaGlobal.Saludar());
            }
        }

        // Ejemplo de otro método que puede usar la misma instancia
        private void button2_Click(object sender, EventArgs e)
        {
            if (personaGlobal != null)
            {
                MessageBox.Show($"Información guardada: {personaGlobal.Nombre}, {personaGlobal.Edad} años");
            }
            else
            {
                MessageBox.Show("No hay información de persona guardada");
            }
        }

    }
}
