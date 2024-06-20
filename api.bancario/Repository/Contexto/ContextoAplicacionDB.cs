
using Microsoft.EntityFrameworkCore;
using Repository.Entidades;


namespace Repository.Contexto
{
    public class ContextoAplicacionDB : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Cliente>()
                .HasKey(c => c.id);
            base.OnModelCreating(modelBuilder);
        }

        public ContextoAplicacionDB(DbContextOptions<ContextoAplicacionDB> options) : base(options)
        {

        }
    }
}
