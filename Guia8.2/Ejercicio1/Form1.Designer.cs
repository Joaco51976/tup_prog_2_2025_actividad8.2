namespace Ejer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox tbPatente;
        private TextBox tbVencimiento;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private Button btnActualizar;
        private Button btnImportar;
        private Button btnExportar;
        private ListBox lstMultas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbPatente = new TextBox();
            this.tbVencimiento = new TextBox();
            this.tbImporte = new TextBox();
            this.btnConfirmar = new Button();
            this.btnActualizar = new Button();
            this.btnImportar = new Button();
            this.btnExportar = new Button();
            this.lstMultas = new ListBox();
            this.SuspendLayout();
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new Point(30, 30);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new Size(150, 23);
            // 
            // tbVencimiento
            // 
            this.tbVencimiento.Location = new Point(30, 70);
            this.tbVencimiento.Name = "tbVencimiento";
            this.tbVencimiento.Size = new Size(150, 23);
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new Point(30, 110);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new Size(150, 23);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new Point(200, 30);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new Size(120, 23);
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new EventHandler(this.btnConfirmar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new Point(200, 70);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new Size(120, 23);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new EventHandler(this.btnActualizar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new Point(200, 110);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new Size(120, 23);
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new Point(200, 150);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new Size(120, 23);
            this.btnExportar.Text = "Exportar";
            this.btnExportar.Click += new EventHandler(this.btnExportar_Click);
            // 
            // lstMultas
            // 
            this.lstMultas.Location = new Point(30, 200);
            this.lstMultas.Name = "lstMultas";
            this.lstMultas.Size = new Size(290, 150);
            // 
            // Form1
            // 
            this.ClientSize = new Size(370, 380);
            this.Controls.Add(this.tbPatente);
            this.Controls.Add(this.tbVencimiento);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lstMultas);
            this.Name = "Form1";
            this.Text = "Gestión de Multas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}