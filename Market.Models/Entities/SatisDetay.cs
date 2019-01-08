using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("SatisDetaylar")]
    public class SatisDetay:BaseEntity<int>
    {

        public Guid UrunDetayId { get; set; }
        public int SatisId { get; set; }


        [ForeignKey("UrunDetayId")]
        public virtual UrunDetay UrunDetay { get; set; }
        [ForeignKey("SatisId")]
        public virtual Satis Satis { get; set; }
    }
}
