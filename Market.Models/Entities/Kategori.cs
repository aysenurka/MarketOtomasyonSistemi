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
    [Table("Kategoriler")]
    public class Kategori : BaseEntity<int>
    {
        [Required]
        [StringLength(30)]
        [Index("IX_KategoriAd", IsUnique = true)]
        public string KategoriAd { get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
        public int? UstKategoriId { get; set; }


        [ForeignKey("UstKategoriId")]
        public virtual Kategori UstKategori { get; set; }
        public virtual ICollection<Kategori> Kategoriler { get; set; } = new HashSet<Kategori>();
        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}
