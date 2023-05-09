using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Context : DbContext
    {
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
    }
}
