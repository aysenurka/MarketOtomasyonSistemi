﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class KategoriViewModel
    {
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }

        public string Aciklama { get; set; }
       
        public int  SubCategorySayisi { get; set; }

        public override string ToString() => $" {KategoriAd}";
       
    }
}
