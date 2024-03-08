using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Models
{
    internal class Kurs
    {
        public int KursRaqami { get; set; }
        public string KursNomi { get; set; }
        public string Teacher { get; set; }
        public ICollection<Mijoz> Mijozlar { get; set;}
    }
}
