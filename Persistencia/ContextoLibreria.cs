using Microsoft.EntityFrameworkCore;
using Uttt.Micro.Libro.Modelo;

namespace Uttt.Micro.Libro.Persistencia
{
    public class ContextoLibreria : DbContext
    {
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options)
        {

        }
        public DbSet<LibreriaMaterial> LibreriasMateriales { get; set; }
    }
}