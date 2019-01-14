using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SatisDetayViewModel
    {
        public List<SepetViewModel> SepetModel { get; set; }
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public int UrunAdet { get; set; }
        public decimal UrunBirimFiyat { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public decimal anatoplam { get; set; }
        public int BirimAdet { get; set; }
        public decimal AlinanurunAdedi { get; set; }
       
        public OdemeTipi odemeTipi { get; set; }
        
        public DateTime Tarih { get; set; } = DateTime.Now.Date;
    }
}
