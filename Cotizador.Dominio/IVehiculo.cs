using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Dominio
{
    public interface IVehiculo
    {
        double Precio { get; set; }
        string NroPatente { get; set; }
        int Anio { get; set; }

        Marca Marca { get; set; }

        double CalcularSeguro(double Porcentaje = 0.05);

    }
}
