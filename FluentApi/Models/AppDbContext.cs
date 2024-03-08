using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace FluentApi.Models
{
    internal class AppDbContext : EFxceptionsContext
    {
        public AppDbContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=FluentApi2;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Mijoz> Mijozlar { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Kurs>().HasKey(a => a.KursRaqami);
            modelBuilder.Entity<Kurs>().Property(b => b.KursNomi).HasColumnName("CourseName").HasMaxLength(30);
            modelBuilder.Entity<Kurs>().Property(u => u.Teacher).HasColumnName("O'qituvchi");
            modelBuilder.Entity<Mijoz>().ToTable("O'quvchilar");
            modelBuilder.Entity<Mijoz>().HasKey(d => d.MijozRaqami);
            modelBuilder.Entity<Mijoz>().Property(e => e.Kursi).HasColumnName("BoughtCourse");
            modelBuilder.Entity<Mijoz>().HasOne(f => f.Kurs).WithMany(h => h.Mijozlar)
                .HasForeignKey(g => g.KursFK).
                OnDelete(DeleteBehavior.SetNull);

        }
    }
}
