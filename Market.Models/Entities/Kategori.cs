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
    public class Kategori : BaseEntity<Guid>
    {
        public Kategori()
        {
            this.Id = Guid.NewGuid();
        }
        [Required]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        [StringLength(100)]
        public string Aciklama { get; set; }
        [Required]
        public decimal Kdv { get; set; }


        public virtual ICollection<Urun> Urunler { get; set; }=new HashSet<Urun>();
    }
}
