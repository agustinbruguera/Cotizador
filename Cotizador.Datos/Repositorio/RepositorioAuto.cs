using Cotizador.Dominio;
using Cotizador.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Datos.Repositorio
{
    class RepositorioAuto: IRepositorio<Auto>
    {
        private readonly CotizadorDB _Contexto;

        public RepositorioAuto(CotizadorDB Contexto)
        {
            _Contexto = Contexto;
        }
        public void Create(Auto entidad)
        {
            _Contexto.Autos.Add(entidad);
            _Contexto.SaveChanges();
        }

        public List<Auto> GetAll()
        {
            return _Contexto.Autos.ToList(); ;
        }
    }
}
