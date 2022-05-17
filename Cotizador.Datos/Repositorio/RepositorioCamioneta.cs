using Cotizador.Dominio;
using Cotizador.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Datos.Repositorio
{
    class RepositorioCamioneta: IRepositorio<Camioneta>
    {
        private readonly CotizadorDB _Contexto;

        public RepositorioCamioneta(CotizadorDB Contexto)
        {
            _Contexto = Contexto;
        }
        public void Create(Camioneta entidad)
        {
            _Contexto.Camionetas.Add(entidad);
            _Contexto.SaveChanges();
        }

        public List<Camioneta> GetAll()
        {
            return _Contexto.Camionetas.ToList(); ;
        }
    }
}
