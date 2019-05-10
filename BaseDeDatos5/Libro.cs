using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseDeDatos5
{
    public class Libro
    {
        
   

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioCompra { get; set; }
        public int NumeroDePagina { get; set; }

    }
}
