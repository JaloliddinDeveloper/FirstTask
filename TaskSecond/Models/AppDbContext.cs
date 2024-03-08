﻿using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace TaskSecond.Models
{
    internal class AppDbContext:EFxceptionsContext
    {
        public AppDbContext()
        {
           
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-D1BB1FN;Initial Catalog=TestSecondDB;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Guruh> Guruhlar { get; set; }
        public DbSet<Customer> Customers { get; set; }  
    }
}
