using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskSecond.Models
{
    internal class Guruh
    {
        [Key]
        public int GuruhID { get; set; }
        [Column("GuruhNomi")]
        public string GNomi { get; set; }
        [Column("KursUstozi")]
        public string Teacher { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
