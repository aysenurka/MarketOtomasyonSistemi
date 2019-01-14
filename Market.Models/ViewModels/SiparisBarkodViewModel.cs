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
        public int UrunDetayId { get; set; }
        public int UrunId { get; set; }
    
        public string UrunAdi { get; set; }
        public string Barkod { get; set; }
        public int BirimAdet { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime UrunAlındıgıTarih { get; set; }

        public decimal TaneSatis { get; set; }
    
  
        public decimal AlişFiyat { get; set; }
        public decimal ToplamAdet { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal GuncelStok { get; set; }
        public string UrunAciklama { get; set; }
        public virtual Urun Urun { get; set; }
        public Satis satis { get; set; }
        public SatisDetay Satisdetay { get; set; }

        public override string ToString() => $"{UrunAdi}  {SatisFiyati:c2} Bilgi : {UrunAciklama} ";
       
    }
}
