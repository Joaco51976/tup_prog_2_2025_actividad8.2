using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer
{
    public interface IExportable
    {
        string Patente { get; set; }
        DateTime Vencimiento { get; set; }
        decimal Importe { get; set; }
    }
}
