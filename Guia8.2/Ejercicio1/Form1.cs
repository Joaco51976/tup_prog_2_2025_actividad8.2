namespace Ejer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                var nueva = new Multa
                {
                    Patente = tbPatente.Text,
                    Vencimiento = DateTime.Parse(tbVencimiento.Text),
                    Importe = decimal.Parse(tbImporte.Text)
                };

                int index = Multa.FindIndex(m => m.Patente == nueva.Patente);
                if (index >= 0)
                    Multa[index] = nueva;
                else
                    Multa.Add(nueva);

                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstMultas.Items.Clear();
            foreach (var m in Multa)
            lstMultas.Items.Add(m);
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IExportador exportador = new ExportadorCsv();
                var datos = exportador.Importar(ofd.FileName);
                Multa.AddRange(datos);
                ActualizarLista();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                IExportador exportador = new ExportadorCsv();
                exportador.Exportar(Multa, sfd.FileName);
            }
        }
    }
}