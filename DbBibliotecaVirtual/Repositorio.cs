using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DbBibliotecaVirtual
{
    public class Repositorio
    {
        private ContexBiBliotecaVirtual _contex;

        public Repositorio()
        {
            _contex = new ContexBiBliotecaVirtual();
        }
        public List<Libros> GetLibros()
        {
            List<Libros> ListaLibros = _contex.Libros.ToList();
            return ListaLibros;
        }
    }
}
