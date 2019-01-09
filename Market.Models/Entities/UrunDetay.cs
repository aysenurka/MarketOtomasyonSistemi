using Market.Models.Abstracts;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("UrunDetaylar")]
    public class UrunDetay : BaseEntity<int>
    {
        public int UrunId { get; set; }
        [Index("IX_Barkod", IsUnique = true)]
        [StringLength(11)]
        public string Barkod { get; set; }
        public short Adet { get; set; }
        public int BirimAdet { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int ToplamAdet
        {
            get => Adet * BirimAdet;
            set { }
        }
        [Required]
        public decimal Kdv { get; set; }
        [Required]
        public decimal Kar { get; set; }
        public decimal Indirim { get; set; }
        public decimal Fiyat { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal AlisFiyat
        {
            get => Fiyat * (1 + Kdv);
            set { }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal SatisFiyat
        {
            get => AlisFiyat * (1 + Kar) * (1 - Indirim);
            set { }
        }
        public DateTime UrunAlısTarihi { get; set; } = DateTime.Now;

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
    }
}
