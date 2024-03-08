using SimpleTaskSecond.Models;

using (var db=new AppDbContext())
{
    var kurs1 = new Kurs { GuruhNomi = "Dotnet" };
    var kurs2 = new Kurs { GuruhNomi = "Python" };
    db.Kurslar.AddRange(kurs1,kurs2);
    db.SaveChanges();

    var kurslar = db.Kurslar.ToList();
    foreach (var k in kurslar)
    {
        Console.WriteLine($"{k.ID}.{k.GuruhNomi}");
    }

}