using Market.BLL.Helpers;
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
        public BarkodAnaForm barkodgel;
        private void KayıtlıUrunAlısForm_Load(object sender, EventArgs e)
        {

          
            var sonuc = UrunDetayHelper.BarkodluUrunuGetir(txtBarkodNo.Text);

            VerileriDoldur(sonuc);

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
 
                var sonuc = UrunDetayHelper.BarkodluUrunuGetir(txtBarkodNo.Text);
                sonuc.Adet = Convert.ToInt32(txtAlinanadetSayisi.Text);
                var deger = new UrunDetayRepo().KayitliUrunEkle(sonuc);
                MessageBox.Show($"{deger} Stoga Eklendi..");
                new UrunRepo().Update();

            }
            catch (Exception ex)
            {

                throw;
            }
            var sonucx = UrunDetayHelper.BarkodluUrunuGetir(txtBarkodNo.Text);
            VerileriDoldur(sonucx);
            this.Close();
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
            

            using (var urun = new UrunDetayRepo())
            {
                var Guncelleurun = new UrunDetayRepo().GetAll().Where(x => x.Barkod == txtBarkodNo.Text).FirstOrDefault();
                Guncelleurun.Kar = decimal.Parse(txtKar.Text);
                //Guncelleurun.Fiyat = decimal.Parse(txtUrunGuncelFiyat.Text);
                Guncelleurun.Kdv = decimal.Parse(txtKDVDegeri.Text);
                Guncelleurun.Indirim = decimal.Parse(txtSEcilenindirim.Text);
                //Guncelleurun.Fiyat = decimal.Parse(txtguncelFiyat.Text);
                urun.Update();
                var urunFiyatG = new UrunRepo().GetById(Guncelleurun.UrunId);
                urunFiyatG.UrunFiyat = Guncelleurun.SatisFiyat / Guncelleurun.ToplamAdet;
                new UrunRepo().Update();

                MessageBox.Show($"{Guncelleurun.Urun.UrunAd} isimli urun guncellendi.");
            }

            var sonuc = UrunDetayHelper.BarkodluUrunuGetir(txtBarkodNo.Text);
            VerileriDoldur(sonuc);
            txtguncelFiyat.Visible = false;
            label14.Visible = false;
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
            richAdetAciklama.Text = sonuc.UrunAciklama;
        }
    }
}
