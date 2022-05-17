using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Dominio
{
    public class Camioneta : IVehiculo
    {
        public int Id { get; set; }
        public double Precio { get; set; }
        public string NroPatente { get; set; }
        public int Anio { get; set; }

        public virtual Marca Marca { get; set; }
        public int MarcaId { get; set; }

        public double CalcularSeguro(double Porcentaje = 0.05)
        {
            return Precio * Porcentaje;
        }
    }
}
