using Microsoft.EntityFrameworkCore;
using Product.Models.Domain;

namespace Product.Models.Database
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
            : base(options) { }

        public DbSet<ProductItem> Products => Set<ProductItem>();
        public DbSet<CategoryItem> Categories => Set<CategoryItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductItem>(entity =>
            {
                entity.Property(p => p.Price).HasColumnType("decimal(10,2)");
                entity.HasIndex(p => p.Name);
            });
        }
    }
}