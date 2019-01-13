using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Helpers
{
    public class UrunDetayHelper
    {
        public static KayitliOlanUrunViewModel BarkodluUrunuGetir(string BarkodNo)
        {
            return new UrunDetayRepo().GetAll().Where(x => x.Barkod == BarkodNo)
                    .Select(x => new KayitliOlanUrunViewModel
                    {
                        UrunDetayId = x.Id,
                        Barkod = x.Barkod,
                        Indirim = x.Indirim,
                        Kar = x.Kar,
                        TaneSatis = x.Urun.UrunFiyat,
                        //Adet = Convert.ToInt32(txtAlinanadetSayisi.Text),

                        Kdv = x.Kdv,
                        UrunId = x.UrunId,
                        Categoryİsmi = x.Urun.Kategori.KategoriAd,
                        Fiyat = x.Fiyat,
                        UrunAlındıgıTarih = x.UrunAlısTarihi,
                        BirimAdet = x.BirimAdet,
                        Urun = x.Urun,
                        AlişFiyat = x.AlisFiyat,
                        GuncelStok = x.Urun.UrunStok,
                        SatisFiyati = x.SatisFiyat,
                        ToplamAdet = x.ToplamAdet
                    }).ToList().FirstOrDefault();
        }
    }
}
