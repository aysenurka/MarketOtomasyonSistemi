using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class KayitliUrunDetayViewModel
    {
        public Guid UrunDetayId { get; set; }
        public Guid UrunId { get; set; }
        public int CategoryId { get; set; }
        public string barkod { get; set; }
        public int BirimAdet { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime UrunAlıstarihi { get; set; }
        public Urun Urun { get; set; }
        public Kategori Kategori { get; set; }
    }
}
