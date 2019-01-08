﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;

namespace Market.Models.Entities
{
    [Table("Alislar")]
    public class Alis : BaseEntity<int>
    {
        public DateTime AlisTarih { get; set; }
        public Guid UrunDetayId { get; set; }

        [ForeignKey("UrunDetayId")]
        public virtual UrunDetay UrunDetay { get; set; }
    }
}
