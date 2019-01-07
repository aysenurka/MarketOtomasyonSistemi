using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Entities;

namespace Market.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MarketCon")
        {
        }

        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<UrunDetay> UrunDetaylar { get; set; }
        public virtual DbSet<Alis> Alislar { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
    }
}
