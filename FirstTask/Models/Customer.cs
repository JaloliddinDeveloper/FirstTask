using System.ComponentModel.DataAnnotations;
namespace FirstTask.Models
{
    internal class Customer
    {
        [Key]
        public int CusID { get; set; }
        [MaxLength(25)]
        public string  Ism { get; set; }
        [MinLength(1)]
        public string  Kursi { get; set; }
    }
}
