using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }
        public E_Socio socio = null;

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

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNroCarnet.Text = "Nro de Carnet: " + socio.CarnetNumero;
            lblNombreSocio.Text = "Nombre de Socio: " + socio.Nombre + " " + socio.Apellido;
            lblFechaInscripcion.Text = "Fecha de Inscripcion: " + socio.FechaInscripcion;
        }
    }
}
