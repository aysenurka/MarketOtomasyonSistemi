using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class FisViewModel
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal UrunToplamFiyat { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
    }
}
