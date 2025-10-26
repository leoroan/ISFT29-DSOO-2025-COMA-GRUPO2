using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ClubDeportivo.Datos; 

namespace ClubDeportivo.Formularios
{
    public partial class frmCarnet : Form
    {
        private Bitmap carnetBitmap;

        // Propiedad pública para recibir el socio desde frmRegistrarSocio
        public E_Socio socio { get; set; }

        public frmCarnet()
        {
            InitializeComponent();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            // Si se envió un socio, mostrar sus datos reales
            if (socio != null)
            {
                lblNumero.Text = $"Nro de Carnet: {socio.CarnetNumero}";
                lblNombre.Text = $"Nombre: {socio.Nombre} {socio.Apellido}";
                lblFecha.Text = $"Fecha de Inscripción: {socio.FechaInscripcion:dd/MM/yyyy}";
            }
            else
            {
                // Modo demostración si no se carga un socio
                lblNumero.Text = "Nro de Carnet: 00001";
                lblNombre.Text = "Nombre: Ejemplo";
                lblFecha.Text = "Fecha de Inscripción: 01/01/2025";
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos el panel del carnet
                carnetBitmap = new Bitmap(panelContenido.Width, panelContenido.Height);
                panelContenido.DrawToBitmap(carnetBitmap,
                    new Rectangle(0, 0, carnetBitmap.Width, carnetBitmap.Height));

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += pd_PrintPage;

                PrintPreviewDialog preview = new PrintPreviewDialog
                {
                    Document = pd,
                    WindowState = FormWindowState.Maximized
                };
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar imprimir el carnet:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (carnetBitmap != null)
            {
                int x = (e.PageBounds.Width - carnetBitmap.Width) / 2;
                int y = (e.PageBounds.Height - carnetBitmap.Height) / 3;
                e.Graphics.DrawImage(carnetBitmap, x, y);
            }
        }
    }
}