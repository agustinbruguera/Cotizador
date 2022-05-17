using Cotizador.Dominio;
using Cotizador.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotizador.Datos.Repositorio
{
    class RepositorioMarca : IRepositorio<Marca>
    {
        private readonly CotizadorDB _Contexto;

        public RepositorioMarca(CotizadorDB Contexto)
        {
            _Contexto = Contexto;
        }
        public void Create(Marca entidad)
        {
            _Contexto.Marcas.Add(entidad);
            _Contexto.SaveChanges();
        }

        public List<Marca> GetAll()
        {
            return _Contexto.Marcas.ToList(); ;
        }
    }
}
