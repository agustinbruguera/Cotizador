using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public int DNI { get; set; }
        public virtual IVehiculo Vehiculo { get; set; }
        public int VehiculoId { get; set; }
    }
}
