using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Tedarikci
    {
        [Key]
        public int TedarikciId { get; set; }
        public string SirketAdi { get; set; }
        public string Sehir { get; set; }
        public ICollection<Urun> Uruns { get; set; }

    }
}
