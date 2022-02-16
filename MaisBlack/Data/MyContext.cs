using MaisBlack.Models;
using Microsoft.EntityFrameworkCore;

namespace MaisBlack.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
