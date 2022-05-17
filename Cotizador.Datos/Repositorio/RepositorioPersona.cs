using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cotizador.Dominio;
using Cotizador.Dominio.Contratos;

namespace Cotizador.Datos.Repositorio
{
    class RepositorioPersona : IRepositorio<Persona>
    {
        private readonly CotizadorDB _Contexto;

        public RepositorioPersona(CotizadorDB Contexto)
        {
            _Contexto = Contexto;
        }


        public void Create(Persona entidad)
        {
            _Contexto.Personas.Add(entidad);
            _Contexto.SaveChanges();
        }

        public List<Persona> GetAll()
        {
            return _Contexto.Personas.ToList();
        }
    }
}
