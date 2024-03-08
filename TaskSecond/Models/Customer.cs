using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSecond.Models
{
    internal class Customer
    {
        [Key]
        public int CurID { get; set; }
        public string Ism { get; set; }
        public string Kurs { get; set; }
        public int GuruhRaqami { get; set; }
        [ForeignKey("GuruhRaqami")]
        public Guruh Guruh { get; set; }
    }
}
