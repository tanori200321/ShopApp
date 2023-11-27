using Microsoft.EntityFrameworkCore;


namespace ShopApp.DataAccess
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Category> Categorias { get; set; }
        public DbSet<Product> Productos { get; set; }
        public DbSet<Client> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ShopComputer");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category(1, "Computadoras"),
                new Category(2, "Laptops"),
                new Category(3, "Accesorios"),
                new Category(4, "Monitores"),
                new Category(5, "Impresoras")
                );

            modelBuilder.Entity<Product>().HasData(
                new Product(1, "Computadora de escritorio", "Computadora de escritorio", 1000, 1),
                new Product(2, "Laptop", "Laptop", 2000, 2),
                new Product(3, "Mouse", "Mouse", 10, 3),
                new Product(4, "Teclado", "Teclado", 20, 3),
                new Product(5, "Monitor", "Monitor", 100, 4),
                new Product(6, "Impresora", "Impresora", 200, 5)
                );

            modelBuilder.Entity<Client>().HasData(
                new Client(1, "Juan Perez", "Av. Siempre Viva 123"),
                new Client(2, "Maria Lopez", "Av. Siempre Viva 456"),
                new Client(3, "Pedro Ramirez", "Av. Siempre Viva 789"),
                new Client(4, "Jose Gonzalez", "Av. Siempre Viva 1011"),
                new Client(5, "Ana Martinez", "Av. Siempre Viva 1213"),
                new Client(6, "Luis Rodriguez", "Av. Siempre Viva 1415")
                );


        }



    }

    public record Category(int Id, string Nombre);
    public record Product(int Id, string Nombre, string Descripcion, decimal Precio, int CategoryId)
    {
        public Category Category { get; init; }
    }

    public record Client(int Id, string Nombre, string Direccion);



}
