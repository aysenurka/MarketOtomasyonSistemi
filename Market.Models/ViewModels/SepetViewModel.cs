using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SepetViewModel
    {
        public int UrunId { get; set; }
        public int UrunDetayId { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Kdv { get; set; }
        //public decimal ToplamFiyat { get; set } = Adet * Fiyat;

        //public override string ToString() => $"{UrunAdi} x{Adet} {ToplamFiyat():c2}";
        public override string ToString() => $"{UrunAdi,-20} x{Adet,-7} {ToplamFiyat():c2}";

        public decimal ToplamFiyat() => Adet * BirimFiyat;
    }
}
