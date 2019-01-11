using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("SatisDetaylar")]
    public class SatisDetay
    {
        [Key, Column(Order = 1)]
        public int UrunId { get; set; }
        [Key, Column(Order = 2)]
        public int SatisId { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }



        [ForeignKey("SatisId")]
        public virtual Satis Satis { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

    }
}
