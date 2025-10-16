using Ejer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer
{
    public class Multa : IExportable
    {
        private string _patente = string.Empty;

        public string Patente
        {
            get => _patente;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new ApplicationException("Patente inválida");
                _patente = value.Trim().ToUpper();
            }
        }

        public DateTime Vencimiento { get; set; }
        public decimal Importe { get; set; }

        public override string ToString()
        {
            return $"{Patente} - {Vencimiento:dd/MM/yyyy} - ${Importe}";
        }
    }
}
public class Multa : IExportable
{
    private string _patente = string.Empty;

    public string Patente
    {
        get => _patente;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                throw new ApplicationException("Patente inválida");
            _patente = value.Trim().ToUpper();
        }
    }

    public DateTime Vencimiento { get; set; }
    public decimal Importe { get; set; }

    public override string ToString()
    {
        return $"{Patente} - {Vencimiento:dd/MM/yyyy} - ${Importe}";
    }
}