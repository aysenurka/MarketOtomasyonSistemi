using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Windows.Forms;

namespace Market.BLL.Repository
{
    public class UrunDetayRepo : RepositoryBase<UrunDetay, int>
    {
        public int UrunDetayEkle(KayitliOlmayanUrunViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var UrunDetayEkle = new UrunDetay
                    {
                        Barkod = model.Barkod,
                        UrunAlısTarihi = model.UrunAlındıgıTarih,
                        Fiyat = model.Fiyat,
                        Kar = model.Kar,
                        Kdv = model.Kdv,
                        Adet = model.Adet,
                        BirimAdet = model.BirimAdet,
                        UrunId = model.UrunId,
                        Indirim = model.Indirim,
                         UrunAdetAciklama=model.UrunAdetAciklama,

                    };
                    db.UrunDetaylar.Add(UrunDetayEkle);
                    db.SaveChanges();
                    var urun = db.Urunler.Find(model.UrunId);
                    urun.UrunFiyat = UrunDetayEkle.SatisFiyat;
                    urun.UrunStok = 0;
                    db.SaveChanges();

                    MessageBox.Show("Yeni UrunDetay Olusturuldu.");
                    tran.Commit();
                    return model.UrunId;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw;
                }

            }
        }
        public int KayitliUrunEkle(KayitliOlanUrunViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {

                    var bulurundetay = new UrunDetayRepo().GetById(model.UrunDetayId);
                    bulurundetay.Adet = bulurundetay.Adet+model.Adet;
                    bulurundetay.UrunAlısTarihi = DateTime.Now;
                    new UrunDetayRepo().Update();

                    var urun = new UrunRepo().GetById(model.UrunId);
                    urun.UrunStok = urun.UrunStok + (model.Adet*bulurundetay.BirimAdet);
                    urun.UrunFiyat = model.SatisFiyati / model.BirimAdet;
                    
                    new UrunRepo().Update();
                    tran.Commit();
                    MessageBox.Show("oldu bu iş.");
                    return (int)model.Adet*bulurundetay.BirimAdet;

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw;
                }

            }
        }

    }
}
