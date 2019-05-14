using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseDeDatos5.Models;


namespace BaseDeDatos5
{
    public class DbsInicialisador
    {


        public static void Inicializar(BaseDeDatos5Context context)
        {
            context.Database.EnsureCreated();
            if (context.Libros.Any())
            {
                return;
            }
            var libro = new Libro[]
            {
                new Libro { Nombre= "carlos",PrecioVenta=200 ,PrecioCompra=99 ,NumeroDePagina=124}
            };

            foreach( Libro c in libro)
            {
                context.Libros.Add(c);
            }
            context.SaveChanges();
        }
    }
}
