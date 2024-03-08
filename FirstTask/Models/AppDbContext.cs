using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace FirstTask.Models
{
    internal class AppDbContext:EFxceptionsContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=TaskOneDb;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

