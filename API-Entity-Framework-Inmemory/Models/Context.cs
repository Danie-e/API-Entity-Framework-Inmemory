using Microsoft.EntityFrameworkCore;


namespace API_Entity_Framework_Inmemory.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Usuario> DbSet { get; set; } = null;
    }
}
