using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class UrunDetay : BaseEntity<Guid>
    {
        public UrunDetay()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid UrunId { get; set; }
        [Index("IX_Barkod", IsUnique = true)]
        [StringLength(11)]
        public string Barkod { get; set; }
        public short Adet { get; set; }
        public int BirimAdet { get; set; } = 1;
        public int ToplamAdet { get; set; }//computed
        public decimal Fiyat { get; set; }
        public decimal AlisFiyat { get; set; }//computed
        public decimal SatisFiyat { get; set; }//computed

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
    }
}
