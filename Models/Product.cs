using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
