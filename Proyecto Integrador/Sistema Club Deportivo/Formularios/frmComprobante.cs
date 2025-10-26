using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ClubDeportivo.Entidades;
using QRCoder; 

namespace ClubDeportivo.Formularios
{
    public partial class frmComprobante : Form
    {
        private Bitmap comprobanteBitmap;

        public E_Pago PagoRealizado { get; set; }

        public frmComprobante()
        {
            InitializeComponent();
        }

        private void frmComprobante_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.ForeColor = Color.White;

            if (PagoRealizado != null)
            {
                lblSocio.Text = $"N° de Socio: {PagoRealizado.CarnetNumero}";
                lblTipo.Text = $"Tipo Persona: {(PagoRealizado.TipoPersona == 1 ? "Socio" : "Otro")}";
                lblFecha.Text = $"Fecha: {PagoRealizado.Fecha:dd/MM/yyyy HH:mm}";
                lblImporte.Text = $"Importe: ${PagoRealizado.Precio:F2}";
                lblMedio.Text = $"Medio de Pago: {(PagoRealizado.MedioPago == 1 ? "Efectivo" : "Tarjeta")}";
                lblActividad.Text = $"Actividad: {(PagoRealizado.Actividad != null ? PagoRealizado.Actividad.Nombre : "-")}";

                GenerarCodigoQR();
            }
        }

        private void GenerarCodigoQR()
        {
            try
            {
                string datosQR = $"Socio: {PagoRealizado.CarnetNumero}\n" +
                                 $"Fecha: {PagoRealizado.Fecha:dd/MM/yyyy}\n" +
                                 $"Monto: ${PagoRealizado.Precio:F2}\n" +
                                 $"Pago: {(PagoRealizado.MedioPago == 1 ? "Efectivo" : "Tarjeta")}";

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
            try
            {
                comprobanteBitmap = new Bitmap(panelComprobante.Width, panelComprobante.Height);
                panelComprobante.DrawToBitmap(comprobanteBitmap, new Rectangle(0, 0, comprobanteBitmap.Width, comprobanteBitmap.Height));

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += Pd_PrintPage;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    WindowState = FormWindowState.Maximized
                };
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el comprobante:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (comprobanteBitmap != null)
            {
                int x = (e.PageBounds.Width - comprobanteBitmap.Width) / 2;
                int y = (e.PageBounds.Height - comprobanteBitmap.Height) / 3;
                e.Graphics.DrawImage(comprobanteBitmap, x, y);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
