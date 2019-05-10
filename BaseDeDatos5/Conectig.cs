using BaseDeDatos5;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public partial class LibreriaContext : DbContext
{
    //public LibrosgingContext()
    //{
    //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = ELE\\SQLEXPRESS; Initial Catalog = libreria3; Integrated Security = True")
        .EnableSensitiveDataLogging(true)
        .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));

    }
    public DbSet<Libro> Libros { get; set; }
}





 

   
    
