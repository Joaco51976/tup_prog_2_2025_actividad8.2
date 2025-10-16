using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer
{
    public interface IExportador
    {
        List<IExportable> Importar(string rutaArchivo);
        void Exportar(List<IExportable> datos, string rutaArchivo);
    }
}