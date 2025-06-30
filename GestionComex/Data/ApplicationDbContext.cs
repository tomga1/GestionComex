using GestionComex.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionComex.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set;}
    }
}
