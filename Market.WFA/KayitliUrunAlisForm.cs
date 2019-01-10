﻿using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class KayitliUrunAlisForm : Form
    {
        public KayitliUrunAlisForm()
        {
            InitializeComponent();

        }

        private void KayıtlıUrunAlısForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Düzeltilicek Bulunan Barkodun gelmesine göre 
            //Belki Görünüşte Numaric Yapılabilir.
            var urunbul = txtBarkodNo.Text;
            //string urunbul = 12354.ToString();
            var sonuc = new UrunDetayRepo().GetAll().Where(x => x.Barkod == urunbul)
                 .Select(x => new KayitliOlmayanUrunViewModel
                 {
                     Barkod = x.Barkod,
                     Indirim = x.Indirim,
                     Kar = x.Kar,
                     Adet = x.Adet,
                     Kdv = x.Kdv,
                     UrunDetayId = x.Id,
                     UrunId = x.UrunId,
                     Categoryİsmi = x.Urun.Kategori.KategoriAd,
                     Fiyat = x.Fiyat,
                     UrunAlındıgıTarih = x.UrunAlısTarihi,
                     BirimAdet = x.BirimAdet,
                     Urun = x.Urun,
                     AlişFiyat = x.AlisFiyat,
                     GuncelStok = x.Urun.UrunStok,
                     SatisFiyati = x.SatisFiyat,
                     ToplamAdet = x.ToplamAdet
                 }).ToList().FirstOrDefault();

            //sonuc.Adet =Convert.ToInt32( txtAlinanadetSayisi.Text);
            txtUrunTaneSatısFiyat.Text = (sonuc.SatisFiyati / sonuc.ToplamAdet).ToString("c2");
            txtGuncelSatisFiyat.Text = sonuc.SatisFiyati.ToString("c2");
            txtGuncelStok.Text = sonuc.GuncelStok.ToString();
            txtBarkodNo.Text = sonuc.Barkod;
            txtAlisFiyat.Text = sonuc.AlişFiyat.ToString("c2");
            txtUrunİsmi.Text = sonuc.Urun.UrunAd;
            txtSEcilenindirim.Text = sonuc.Indirim.ToString();
            txtUrunKategori.Text = sonuc.Categoryİsmi;
            txtUrunİsmi.Text = sonuc.Urun.UrunAd;
            txtBarkodNo.Text = sonuc.Barkod;
            txtUrunAdetSayisi.Text = sonuc.BirimAdet.ToString();
            txtKDVDegeri.Text = sonuc.Kdv.ToString();
            txtUrunGuncelFiyat.Text = sonuc.Fiyat.ToString("c2");



        }
    }
}
