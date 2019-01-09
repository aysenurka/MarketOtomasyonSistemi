using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Market.BLL.Repository
{
   public class KategoriRepo:RepositoryBase<Kategori,int>
    {
        public override int Insert(Kategori entity)
        {
            try
            {
                var category = db.Kategoriler.Find(entity.Id);
                if (category == null)
                    throw new Exception("Kategori bulunamadi");
                if (category.Kategoriler.Any())
                    throw new Exception("Ust kategorilere urun ekleyemezsiniz");
                return base.Insert(entity);
            }
            catch
            {
                throw;
            }
        }
    }
}
