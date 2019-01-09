using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Windows.Forms;

namespace Market.BLL.Repository
{
    public class UrunDetayRepo : RepositoryBase<UrunDetay, int>
    {
        public int UrunDetayEkle(KayitliUrunDetayViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var UrunDetayEkle = new UrunDetay
                    {
                        Barkod = model.Barkod,
                        UrunAlısTarihi = model.UrunAlıstarihi,
                        Fiyat = model.Fiyat,
                        Kar = model.Kar,
                        Kdv = model.Kdv,
                        Adet = model.Adet,
                        BirimAdet = model.BirimAdet,
                        UrunId = model.UrunId,
                        Indirim = model.Indirim, 
                       
                    };
                    db.UrunDetaylar.Add(UrunDetayEkle);
                    db.SaveChanges();
                  var urun  =  db.Urunler.Find(model.UrunId);
                    urun.UrunFiyat = UrunDetayEkle.SatisFiyat;
                    urun.UrunStok = 0;
                    db.SaveChanges();
                
                    MessageBox.Show("UrunEklendi");
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
    }
}
