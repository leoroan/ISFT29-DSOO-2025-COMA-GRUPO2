using System.Drawing.Printing;
namespace Proyecto.Formularios
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }
        /*________________________________________________________
        * Variables para traer LOS DATOS del formulario
        * donde se ejecuta la lógica
        * ------------------------------------------------------ */
        public string? alumno_f;
        public string? curso_f;
        public string? pago_f;
        public float monto_f;
        public int numero_f;
        public DateTime fecha_f;
        public string? forma_f;

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /* -----------------------------------------------------
            * Ocultamos los botones que no pertenecen al diseño
            * pero si para la funcionalidad
            * Usamos la propiedad VISIBLE y los posibles
            * valores son True o False
            * ---------------------------------------------------- */
            btnImprimir.Visible = false;

            /* ---------------------------------------
            * creamos los objetos para la impresion
            * ------------------------------------------ */
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();
            btnImprimir.Visible = true; // visualizamos nuevamente el objeto
            /* _________________________________
            * regreso al formulario principal
            * después del dar aviso
            * ---------------------------------- */
            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        /* -------------------------------------------------------
        * Conjunto de sentencias necesarias para
        * el objeto Print
        * ------------------------------------------------------- */
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            // Crear un bitmap del tamaño del formulario
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            // Copiar desde la pantalla (por si DrawToBitmap no muestra todo)
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Point formLocation = this.PointToScreen(Point.Empty);
                g.CopyFromScreen(formLocation, Point.Empty, this.Size);
            }

            // Dibujar el bitmap en el documento
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            /* ----------------------------------------
            * asignación de los valores a los datos
            * que muestra cada etiqueta del diseño
            * del comprobante de pago
            * --------------------------------------------- */
            lblAlumno.Text = alumno_f;
            lblCurso.Text = "Se inscribio al curso: " + curso_f;
            lblDia.Text = "Fecha de Comienzo: " + Convert.ToString(fecha_f);
            lblValor.Text = "Monto: $" + Convert.ToString(monto_f);
            lblFPago.Text = "Forma de Pago: " + forma_f;
            // se obtiene la fecha actual
            lblDfecha.Text = "Fecha: " + DateTime.UtcNow.ToShortDateString();
        }
    }
}
