using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Windows.Forms;

namespace Market.BLL.Repository
{
    public class UrunRepo:RepositoryBase<Urun,int>
    {
        public int UrunStokSiparis(UrunSiparisViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                 var urun = db.Urunler.Find(model.UrunId);
                    urun.UrunStok = urun.UrunStok + model.AlınanSiparisSayisi;
                    db.SaveChanges();

                    tran.Commit();
                    return model.AlınanSiparisSayisi;
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
