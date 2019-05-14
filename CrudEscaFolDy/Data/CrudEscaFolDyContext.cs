using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudEscaFolDy.Models
{
    public class CrudEscaFolDyContext : DbContext
    {
        public CrudEscaFolDyContext (DbContextOptions<CrudEscaFolDyContext> options)
            : base(options)
        {
        }

        public DbSet<CrudEscaFolDy.Models.Categoria> Categoria { get; set; }
    }
}
