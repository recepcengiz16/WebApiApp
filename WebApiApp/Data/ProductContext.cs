using Microsoft.EntityFrameworkCore;

namespace WebApiApp.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[] 
            {
                new(){Id=1,Name="Elektronik"},
                new(){Id=2,Name="Giyim"},
            });
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new (){Id=1,Name="Bilgisayar",CreatedDate=DateTime.Now.AddDays(-3),Price=15000,Stock=300,CategoryId=1},

                new (){Id=2,Name="Telefon",CreatedDate=DateTime.Now.AddDays(-30),Price=3750,Stock=400,CategoryId=1},

                new (){Id=3,Name="Tablet",CreatedDate=DateTime.Now.AddDays(-15),Price=2500,Stock=350,CategoryId=1},

                new (){Id=4,Name="Akıllı Saat",CreatedDate=DateTime.Now.AddDays(-60),Price=1500,Stock=600,CategoryId=1},
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
