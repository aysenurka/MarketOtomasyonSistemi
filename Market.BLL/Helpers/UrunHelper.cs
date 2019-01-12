using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Helpers
{
   public  class UrunHelper
    {
        public static object UrunleriGetir()
        {
            return new UrunRepo().GetAll().Select(x => new UrunViewModel
            {
                UrunId = x.Id,
                UrunAd = x.UrunAd,
                KategoriId = x.KategoriId,
                UrunFiyat = x.UrunFiyat,
                UrunStok = x.UrunStok
            }).ToList();
        }

        public static object StoktakiAzalanUrunler()
        {
            return new UrunRepo().GetAll().Where(x=>x.UrunStok<=20).Select(x => new UrunSiparisViewModel
            {
                UrunId = x.Id,
                UrunAd = x.UrunAd,
                UrunFiyat = x.UrunFiyat,
                UrunStok = x.UrunStok,
            }).ToList();
        }
    }
}
