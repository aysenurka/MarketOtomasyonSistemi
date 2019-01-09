using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Helpers
{
    public class KategoriHelper
    {
        public static object EnUstKategorileriGetir()
        {
            return new KategoriRepo().GetAll().Where(x => x.AltKategoriId == null)
                .Select(x => new KategoriViewModel
                {
                    KategoriId = x.Id,
                    Aciklama = x.Aciklama,
                    KategoriAd = x.KategoriAd,
                  SubCategorySayisi=x.Kategoriler.Count
                }).ToList();
        }
    }
}
