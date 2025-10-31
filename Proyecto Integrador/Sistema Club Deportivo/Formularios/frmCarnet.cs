using ClubDeportivo.Datos; 
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class frmCarnet : Form
    {
        private Bitmap carnetBitmap;

        // Propiedad pública para recibir el socio desde frmRegistrarSocio
        public E_Socio socio = null;
        public E_NoSocio noSocio = null;
        public int TipoPersona = 0; // 1 = socio, 2 = no socio

        public frmCarnet(int tipoPersona)
        {
            InitializeComponent();
            TipoPersona = tipoPersona;
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            if (TipoPersona == 1)
            {
                lblTipoCarnet.Text = "Carnet de Socio";
                lblNumero.Text = "Nro de Carnet: " + socio.CarnetNumero;
                lblNombre.Text = "Nombre de Socio: " + socio.Nombre + " " + socio.Apellido;
                lblFecha.Text = "Fecha de Inscripcion: " + socio.FechaInscripcion;
                lblDni.Text = "Dni: " + socio.DNI.ToString();
            }
            else
            {
                lblTipoCarnet.Text = "Carnet Temporal";
                lblNumero.Text = "Nro de Carnet Temporal: " + noSocio.CarnetTemporal;
                lblNombre.Text = "Nombre de No Socio: " + noSocio.Nombre + " " + noSocio.Apellido;
                lblDni.Text = "Dni: " + noSocio.DNI.ToString();
                lblFecha.Visible = false;
            }
        }

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
    }
}