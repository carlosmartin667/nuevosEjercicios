using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BaseDeDatos5;

namespace BaseDeDatos5.Models
{
    public class BaseDeDatos5Context : DbContext
    {
        public BaseDeDatos5Context (DbContextOptions<BaseDeDatos5Context> options)
            : base(options)
        {
        }

        public DbSet<BaseDeDatos5.Libro> Libros { get; set; }
    }
}
