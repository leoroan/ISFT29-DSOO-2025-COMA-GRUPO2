using ClubDeportivo.Entidades;
using QRCoder; 
using System.Drawing.Printing;
using static ClubDeportivo.Datos.Pago;

namespace ClubDeportivo.Formularios
{
    public partial class frmComprobante : Form
    {
        private Bitmap comprobanteBitmap;

        public E_Pago PagoRealizado { get; set; }

        public frmComprobante(int tipoPersona)
        {
            InitializeComponent();
            tipoPersona = TipoPersona;
        }
        public E_Socio socio = null;
        public E_NoSocio noSocio = null;
        public E_Pago E_Pago = null;
        public int TipoPersona = 0; // 1 = socio, 2 = no socio
        private void frmComprobante_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.ForeColor = Color.White;

            TipoPago tipo = (TipoPago)E_Pago.MedioPago;
            if (TipoPersona == 1)
            {
                lblNro.Text = "Nro de Carnet: " + socio.CarnetNumero;
                lblTipo.Text ="Tipo de Persona: Socio";
                lblNombre.Text = "Nombre de Socio: " + socio.Nombre + " " + socio.Apellido;
            }
            else
            {
                lblNro.Text = "Nro de Carnet Temporal: " + noSocio.CarnetTemporal;
                lblTipo.Text = "Tipo de Persona: No Socio";
                lblNombre.Text = "Nombre del No Socio: " + noSocio.Nombre + " " + noSocio.Apellido;
            }
            lblFecha.Text = "Fecha: " + DateTime.Now.ToShortDateString();
            lblPrecio.Text = "Precio Pagado: $" + E_Pago.Precio;
            lblFormaPago.Text = "Forma de Pago: " + tipo.ToString();
            lblActividad.Text = "Actividad: " + (E_Pago.Actividad != null ? E_Pago.Actividad.Nombre : "N/A");

            GenerarCodigoQR(TipoPersona);
        }
        private void GenerarCodigoQR(int TipoPersona)
        {
            try
            {
                string datosQR = string.Empty;
                if (TipoPersona ==1)
                {
                    datosQR =   $"Socio: {socio.CarnetNumero}\n" +
                                $"Fecha Inscripcion: {socio.FechaInscripcion:dd/MM/yyyy}\n" +
                                $"Precio: ${E_Pago.Precio:F2}\n" +
                                $"Pago: {(E_Pago.MedioPago == 1 ? "Efectivo" : "Tarjeta")}";
                }
                else
                {
                    datosQR =   $"No Socio: {noSocio.CarnetTemporal}\n" +
                                $"Fecha: {DateTime.Now:dd/MM/yyyy}\n" +
                                $"Precio: ${E_Pago.Precio:F2}\n" +
                                $"Pago: {(E_Pago.MedioPago == 1 ? "Efectivo" : "Tarjeta")}";
                }
                

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(datosQR, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);

                pbQR.Image = qrCode.GetGraphic(5, Color.Black, Color.White, true);
            }
            catch
            {
                // si algo falla con el QR
                pbQR.Image = null;
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
