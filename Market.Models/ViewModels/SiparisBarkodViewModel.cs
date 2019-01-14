using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SiparisBarkodViewModel
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }
        public int KategoriId { get; set; }
        public int UrunDetayId { get; set; }
        public int BirimAdet { get; set; }
        public string Barkod { get; set; }
        public decimal Adet { get; set; }
        public decimal SatisFiyati { get; set; }
        public string UrunAciklama { get; set; }
        public Kategori Kategori { get; set; }
        public UrunDetay UrunDetay { get; set; }

        public override string ToString() => $"{UrunAd}--{SatisFiyati:c2}-{UrunAciklama}";

    }
}
