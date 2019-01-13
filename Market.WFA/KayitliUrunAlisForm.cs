﻿using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
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
            string urunbul = "123";

            var sonuc = UrunDetayHelper.BarkodluUrunuGetir(urunbul);
            VerileriDoldur(sonuc);

        }
        string urunbul;
        private void button1_Click(object sender, EventArgs e)
        {
            ////Düzeltilicek Bulunan Barkodun gelmesine göre 
            try
            {
                urunbul = txtBarkodNo.Text;

                var sonuc = UrunDetayHelper.BarkodluUrunuGetir(urunbul);
                sonuc.Adet = Convert.ToInt32(txtAlinanadetSayisi.Text);
                var deger = new UrunDetayRepo().KayitliUrunEkle(sonuc);
                MessageBox.Show($"{deger} Stoga Eklendi..");
                VerileriDoldur(sonuc);

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            btnUrunGuncelle.Visible = true;
            txtSEcilenindirim.ReadOnly = false;
            txtKDVDegeri.ReadOnly = false;
            txtKar.ReadOnly = false;
            txtUrunAdetSayisi.ReadOnly = false;
            txtUrunGuncelFiyat.ReadOnly = false;
            pnurunler.Visible = false;
            txtguncelFiyat.ReadOnly = false;
            label14.Visible = true;
            txtguncelFiyat.Visible = true;
            btnGuncelle.Visible = false;
            //Kullanılabilir
            //this.Controls.OfType<TextBox>().All(tb => tb.ReadOnly = true);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnurunler.Visible = true;
            btnUrunGuncelle.Visible = false;
            txtSEcilenindirim.ReadOnly = true;
            txtKDVDegeri.ReadOnly = true;
            txtKar.ReadOnly = true;
            txtUrunAdetSayisi.ReadOnly = true;
            txtUrunGuncelFiyat.ReadOnly = true;
            label14.Visible = true;
            txtguncelFiyat.Visible = true;
            btnGuncelle.Visible = true;

            urunbul = txtBarkodNo.Text;

            using (var urun = new UrunDetayRepo())
            {
                var Guncelleurun = new UrunDetayRepo().GetAll().Where(x => x.Barkod == urunbul).FirstOrDefault();
                Guncelleurun.Kar = decimal.Parse(txtKar.Text);
                //Guncelleurun.Fiyat = decimal.Parse(txtUrunGuncelFiyat.Text);
                Guncelleurun.Kdv = decimal.Parse(txtKDVDegeri.Text);
                Guncelleurun.Indirim = decimal.Parse(txtSEcilenindirim.Text);
                Guncelleurun.Fiyat = decimal.Parse(txtguncelFiyat.Text);
                urun.Update();
                var urunFiyatG = new UrunRepo().GetById(Guncelleurun.UrunId);
                urunFiyatG.UrunFiyat = Guncelleurun.SatisFiyat / Guncelleurun.ToplamAdet;
                new UrunRepo().Update();

                MessageBox.Show($"{Guncelleurun.Urun.UrunAd} isimli urun guncellendi.");
            }

            var sonuc = UrunDetayHelper.BarkodluUrunuGetir(urunbul);
            VerileriDoldur(sonuc);

        }

        private void VerileriDoldur(KayitliOlanUrunViewModel sonuc)
        {
            txtKar.Text = sonuc.Kar.ToString();
            txtUrunTaneSatısFiyat.Text = sonuc.TaneSatis.ToString("c2");
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
