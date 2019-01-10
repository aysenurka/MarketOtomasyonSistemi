using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Urunler")]
    public class Urun : BaseEntity<int>
    {
        [Required]
        [StringLength(30)]
        [Index("IX_UrunAd", IsUnique = true)]
        public string UrunAd { get; set; }
        public int UrunStok { get; set; } = 0;
        public decimal UrunFiyat { get; set; } = 0;
        public int KategoriId { get; set; }
      

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<UrunDetay> UrunDetaylar { get; set; } = new HashSet<UrunDetay>();
    }
}
