using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFluentApi.Models
{
    internal class Kurs
    {
        public int KRaqami { get; set; }
        public string KNomi { get; set; }
        public string Teacher { get; set; }
        public ICollection<Mijoz> Mijozlar { get; set; }
    }
}
