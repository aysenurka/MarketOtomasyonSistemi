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
    [Table("Urunler")]
    public class Urun : BaseEntity<Guid>
    {
        public Urun()
        {
            this.Id = Guid.NewGuid();
        }
        [Required]
        [StringLength(30)]
        [Index("IX_UrunAd", IsUnique = true)]
        public string UrunAd { get; set; }
        public short UrunStok { get; set; }
        public decimal UrunFiyat { get; set; }
        public Guid KategoriId { get; set; }

        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<UrunDetay> UrunDetaylar { get; set; } = new HashSet<UrunDetay>();
    }
}
