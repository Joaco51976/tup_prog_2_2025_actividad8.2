using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;

namespace Ejer
{
    public class ExportadorCsv : IExportador
    {
        public List<IExportable> Importar(string rutaArchivo)
        {
            var lista = new List<IExportable>();
            using (var reader = new StreamReader(rutaArchivo))
            {
                string header = reader.ReadLine(); 
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    var multa = new Multa
                    {
                        Patente = parts[0],
                        Vencimiento = DateTime.Parse(parts[1]),
                        Importe = decimal.Parse(parts[2])
                    };
                    lista.Add(multa);
                }
            }
            return lista;
        }

        public void Exportar(List<IExportable> datos, string rutaArchivo)
        {
            using (var writer = new StreamWriter(rutaArchivo))
            {
                writer.WriteLine("Patente;Vencimiento;Importe");
                foreach (var item in datos)
                {
                    writer.WriteLine($"{item.Patente};{item.Vencimiento:dd/MM/yyyy};{item.Importe}");
                }
            }
        }
    }
}