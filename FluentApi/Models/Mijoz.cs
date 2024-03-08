using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi.Models
{
    internal class Mijoz
    {
        public int MijozRaqami { get; set; }
        public string Ism { get;set; }
        public string Kursi { get; set; }
        public int? KursFK { get; set; }
        public Kurs Kurs { get; set; }  
    }
}
