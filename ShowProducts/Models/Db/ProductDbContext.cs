using Microsoft.EntityFrameworkCore;

namespace ShowProducts.Models.Db
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O8SFUP7\\SQLEXP; DataBase=Prodct-MVC; Integrated Security=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
