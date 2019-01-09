using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("SatisDetaylar")]
    public class SatisDetay:BaseEntity<int>
    {

        public int UrunDetayId { get; set; }
        public int SatisId { get; set; }


        [ForeignKey("UrunDetayId")]
        public virtual UrunDetay UrunDetay { get; set; }
        [ForeignKey("SatisId")]
        public virtual Satis Satis { get; set; }
    }
}
