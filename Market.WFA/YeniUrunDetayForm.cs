using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class YeniUrunDetayForm : Form
    {
        public YeniUrunDetayForm()
        {
            InitializeComponent();
        }

        private void YeniUrunForm_Load(object sender, EventArgs e)
        {
            cmbYeniCategory.DataSource = KategoriHelper.EnUstKategorileriGetir();

            cmbUrunCategory.DataSource = UrunHelper.UrunleriGetir();
        }

        private UrunEkleForm frmUrunEkle;
        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            pnYeniUrunEkle.Visible = true;
            if (frmUrunEkle == null || frmUrunEkle.IsDisposed)
            {
                frmUrunEkle = new UrunEkleForm
                {
                    Text = "Urun Ekle Form"
                };
            }
            frmUrunEkle.Show();
        }

        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            //Formlar Arası geçiş ve geri deger döndürme bu şekilde yapmamızlazım.
            KategoriEkleForm urun = new KategoriEkleForm();
            urun.Show();
            urun.yeniurundetayform = this;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var id = new UrunDetayRepo().UrunDetayEkle(new KayitliUrunDetayViewModel()
                {
                    Barkod = txtBarkodNo.Text,
                    Adet = 0,
                    Indirim = nuYeniUrunIndirim.Value,
                    Kar = nuUrunKarOranı.Value,
                    Kdv = nuYeniUrunKdvDegeri.Value,
                    UrunId = (cmbUrunCategory.SelectedItem as UrunViewModel).UrunId,
                    CategoryId = (cmbYeniCategory.SelectedItem as KategoriViewModel).KategoriId,
                    UrunAlıstarihi = DateTime.Now,
                    BirimAdet= (short)nuUrunAdetBilgisi.Value,
                     Fiyat=nuUrunKoliFiyati.Value,

                });

                MessageBox.Show($"Oldu bu iş\n{id}");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "bir hata olustu");
            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            //gerek olmayabilir. veritabanında required ise
            if (txtYeniUrunAdi.Text == null || txtYeniUrunAdi.Text == string.Empty) return;

            try
            {
                new UrunRepo().Insert(new Urun
                {
                    UrunAd = txtYeniUrunAdi.Text,
                    UrunFiyat = nuYeniUrunTaneFiyat.Value,
                    KategoriId = (cmbYeniCategory.SelectedItem as KategoriViewModel).KategoriId,
                    UrunStok = 0
                });
                MessageBox.Show("Urun eklendi");
                cmbUrunCategory.DataSource = UrunHelper.UrunleriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
