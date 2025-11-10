using ClubDeportivo.Datos;

namespace ClubDeportivo.Formularios
{
    public partial class frmListado : Form
    {
        #region Variables y Constructor
        public frmListado()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void frmListado_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Listado de Socios deudores a la fecha " + DateTime.Now.ToShortDateString() + ":";
            Listado listado = new Listado();
            dtgListado.DataSource = listado.TraerDeudores();
            if (dtgListado.Rows.Count == 0)
            {
                MessageBox.Show("No existe registros de deudores a la fecha Actual", "Listado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnExportar.Enabled = false;
            }
            else 
            {
                btnExportar.Enabled = true;
            }

                btnExportar.Click += BtnExportar_Click;
        }
        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (dtgListado.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                FileName = "Deudores_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        // Encabezados
                        for (int i = 0; i < dtgListado.Columns.Count; i++)
                        {
                            sw.Write(dtgListado.Columns[i].HeaderText);
                            if (i < dtgListado.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Filas de datos
                        foreach (DataGridViewRow fila in dtgListado.Rows)
                        {
                            for (int c = 0; c < dtgListado.Columns.Count; c++)
                            {
                                sw.Write(fila.Cells[c].Value?.ToString()?.Replace(",", " "));
                                if (c < dtgListado.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Archivo exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start("explorer.exe", saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar los datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}