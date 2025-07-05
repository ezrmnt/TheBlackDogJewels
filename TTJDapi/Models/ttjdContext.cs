using Microsoft.EntityFrameworkCore;

namespace TTJDapi.Models
{
    public class ttjdContext : DbContext
    {
        public ttjdContext(DbContextOptions<ttjdContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}