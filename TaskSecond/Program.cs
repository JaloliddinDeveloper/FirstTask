using Microsoft.EntityFrameworkCore;
using TaskSecond.Models;

using (var db=new AppDbContext())
{
    var guruh1 = new Guruh { GNomi = "Dotnet", Teacher = "Elbek" };
    var guruh2 = new Guruh { GNomi = "Python", Teacher = "Zafar" };
    var guruh3 = new Guruh { GNomi = "PHP", Teacher = "Akmal" };
    db.Guruhlar.AddRange(guruh1, guruh2, guruh3);

    var customer1 = new Customer { Ism = "Ali", Kurs = "Dotnet", GuruhRaqami = 1 };
    var customer2 = new Customer { Ism = "Wali", Kurs = "Python", GuruhRaqami = 2 };
    var customer3 = new Customer { Ism = "G'ani", Kurs = "php", GuruhRaqami = 3 };
    db.Customers.AddRange(customer1, customer2, customer3);
    db.SaveChanges();
    
    var guruhlar= db.Guruhlar.ToList();

    foreach (var g in guruhlar)
    {
        Console.WriteLine($"{g.GuruhID}.{g.GNomi} {g.Teacher}");
    }
    var mijozlar = db.Customers.Include(x => x.Guruh).ToList();

    foreach (var m in mijozlar)
    {
        Console.WriteLine($"{m.CurID}.{m.Ism} {m.Kurs} {m.GuruhRaqami}");
    }
    
}