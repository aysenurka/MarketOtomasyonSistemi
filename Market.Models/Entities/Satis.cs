using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;
using Market.Models.Enums;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis : BaseEntity<int>
    {
        public decimal ToplamFiyat { get; set; }
        public DateTime SatisTarih { get; set; }
        public OdemeTipi OdemeTipi { get; set; }

        public virtual ICollection<SatisDetay> SatisDetaylar { get; set; } = new HashSet<SatisDetay>();
    }
}
