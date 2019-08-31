using LiveMusicFinder.Models;
using LiveMusicFInder.Models;
using Microsoft.EntityFrameworkCore;

namespace LiveMusicFinder.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        public DbSet<LiveShow> LiveShows { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Curso> Cursos { get; set; }
    }
}