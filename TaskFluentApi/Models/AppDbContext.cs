using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace TaskFluentApi.Models
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
            optionsBuilder.
                UseSqlServer
                (@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=TaskApi;
                 Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Kurs> Kurslar { get; set; }
        public DbSet<Mijoz> Mijozlar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kurs>().ToTable("Kurslar");
            modelBuilder.Entity<Kurs>().HasKey(a => a.KRaqami).HasName("KursIdsi");
            modelBuilder.Entity<Kurs>().Property(b => b.KNomi).HasColumnName("KursNomi");
            modelBuilder.Entity<Kurs>().Property(c => c.Teacher).HasColumnName("O'qituvchi");
            modelBuilder.Entity<Mijoz>().ToTable("O'quvchilar");
            modelBuilder.Entity<Mijoz>().HasKey(d => d.MRaqami).HasName("MijozIdsi");
            modelBuilder.Entity<Mijoz>().Property(e => e.Ism).HasMaxLength(25);
            modelBuilder.Entity<Mijoz>().HasOne(f => f.Kurs).WithMany(h => h.Mijozlar).HasForeignKey(g => g.KFK);
        }










    }
}
