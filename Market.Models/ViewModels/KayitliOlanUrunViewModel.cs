using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
   public class KayitliOlanUrunViewModel
    {
        public int UrunDetayId { get; set; }
        public int UrunId { get; set; }
        public int CategoryId { get; set; }
        public string Categoryİsmi { get; set; }
        public string Barkod { get; set; }
        public int BirimAdet { get; set; }
        public short Adet { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime UrunAlıstarihi { get; set; } = DateTime.Now;
        public decimal Kdv { get; set; }
        public decimal Kar { get; set; }
        public decimal Indirim { get; set; }


        public virtual Urun Urun { get; set; }
    }
}
