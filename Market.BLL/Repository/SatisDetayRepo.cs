using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Repository
{
    public class SatisDetayRepo : RepositoryBase<SatisDetay, int>
    {

        public int SatisYap(SatisDetayViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var satis = new Satis
                    {
                        SatisTarih = DateTime.Now,
                        ToplamFiyat = model.anatoplam,
                        OdemeTipi = model.odemeTipi,
                    };
                    db.Satislar.Add(satis);
                    db.SaveChanges();
                    foreach (var item in model.SepetModel)
                    {
                        db.SatisDetaylar.Add(new SatisDetay
                        {
                            Id = satis.Id,
                            Id2 = item.UrunId,
                            Adet = item.Adet*(int)item.BirimAdet,
                            BirimFiyat = item.BirimFiyat
                        });
                        db.SaveChanges();
                        var urun = db.Urunler.Find(item.UrunId);
                        urun.UrunStok = urun.UrunStok - (item.Adet * (int)item.BirimAdet);
                        db.SaveChanges();
                       
                        
                    }
               
                    tran.Commit();
                    return satis.Id;
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
