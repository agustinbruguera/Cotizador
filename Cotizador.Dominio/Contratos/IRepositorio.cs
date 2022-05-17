using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Dominio.Contratos
{
    public interface IRepositorio<T> where T : class
    {
        
        void Create(T entidad);
        List<T> GetAll();
    }
}
