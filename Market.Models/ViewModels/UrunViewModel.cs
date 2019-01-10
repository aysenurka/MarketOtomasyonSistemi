using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class UrunViewModel
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }
        public int KategoriId { get; set; }


        public Kategori Kategori { get; set; }

        public override string ToString() => $"{UrunAd} - {(UrunStok)}";
    }
}
