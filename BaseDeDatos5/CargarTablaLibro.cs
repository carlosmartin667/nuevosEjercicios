using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseDeDatos5
{
    public class CargarTablaLibro
    {

        static void CargaLibros()
        {
            using (var context = new LibreriaContext())
            {
                var libros = new Libro();

                libros.Nombre = "Steve Jobs. Lecciones de Liderazgo";
                libros.NumeroDePagina = 112;
                libros.PrecioVenta = 429;
                libros.PrecioCompra = 400;
            }
            using (var context = new LibreriaContext())
            {
                var libros = context.Libros.ToList();
            }
        }


    }

}
