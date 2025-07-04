using Microsoft.EntityFrameworkCore;
using RESTful_teste.Models;

namespace RESTful_teste.Data
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                        .HasMany(p => p.Itens)
                        .WithOne()
                        .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
