using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace SimpleTaskSecond.Models
{
    internal class AppDbContext:EFxceptionsContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=KursSimple;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Mijoz> Mijozlar { get; set;}
    }
}
