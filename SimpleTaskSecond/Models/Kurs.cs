namespace SimpleTaskSecond.Models
{
    internal class Kurs
    {
        public  int ID { get; set; }
        public  string GuruhNomi { get; set; }
        public ICollection<Mijoz> Mijozlar { get; set;}
    }
}
