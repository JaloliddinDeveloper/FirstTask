using FirstTask.Models;

using (var db=new AppDbContext())
{
    var customer1 = new Customer { Ism = "Ali", Kursi = "Dotnet" };
    var customer2 = new Customer { Ism = "Wali", Kursi = "Python" };
    db.Customers.AddRange(customer1, customer2);    
    db.SaveChanges();

    var customers = db.Customers.ToList();  
    foreach (var c in customers)
    {
        Console.WriteLine($"{c.CusID}.{c.Ism}  {c.Kursi}");
    }
}