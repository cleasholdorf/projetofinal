using Microsoft.EntityFrameworkCore;

namespace projeto_final.Models
{
    public class ProjetoFinalDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public ProjetoFinalDbContext(DbContextOptions<ProjetoFinalDbContext> options) : base(options)
        {
            
        }
    }
}
