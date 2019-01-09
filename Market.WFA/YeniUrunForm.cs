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
    public partial class YeniUrunForm : Form
    {
        public YeniUrunForm()
        {
            InitializeComponent();
        }

        private void YeniUrunForm_Load(object sender, EventArgs e)
        {
            cmbYeniCategory.DataSource = KategorileriGetir();

            cmbUrunCategory.DataSource = UrunleriGetir();
        }

        private List<KategoriViewModel> KategorileriGetir()
        {
            var sonuc = new KategoriRepo().GetAll().Where(x => x.UstKategoriId == null).Select(x => new KategoriViewModel
            {
                KategoriId = x.Id,
                Aciklama = x.Aciklama,
                KategoriAd = x.KategoriAd,
                UstKategoriId = x.UstKategoriId
            }).ToList();
            return sonuc;
        }

        private List<UrunViewModel> UrunleriGetir()
        {
            var sonuc = new UrunRepo().GetAll().Select(x => new UrunViewModel
            {
                UrunId = x.Id,
                UrunAd = x.UrunAd,
                KategoriId = x.KategoriId,
                UrunFiyat = x.UrunFiyat,
                UrunStok = x.UrunStok
            }).ToList();
            return sonuc;
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
            pnKategoriEkle.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnUrunBilgileri.Visible = false;

            var categories = new List<KategoriViewModel>
            {
                new KategoriViewModel() { KategoriId=0, KategoriAd = "Boş"}
            };
            categories.AddRange(new KategoriRepo().GetAll().Where(x => x.UstKategoriId == null)
                .Select(x => new KategoriViewModel
                {
                    KategoriId = x.Id,
                    Aciklama = x.Aciklama,
                    KategoriAd = x.KategoriAd,
                    UstKategoriId = x.UstKategoriId
                }));
            lstCategoryiSec.DataSource = categories;

        }

        private void btnUrunVazgec_Click(object sender, EventArgs e)
        {
            pnUrunBilgileri.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnKategoriEkle.Visible = false;



        }

        private void btnKategoriVazgec_Click(object sender, EventArgs e)
        {
            pnUrunBilgileri.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnKategoriEkle.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new UrunDetayRepo().Insert(new UrunDetay
                {

                });


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
                cmbUrunCategory.DataSource = UrunleriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            if (lstCategoryiSec.SelectedItem == null) return;
            var seciliUstKategori = lstCategoryiSec.SelectedItem as KategoriViewModel;
            try
            {

                new KategoriRepo().Insert(new Kategori
                {
                    Aciklama = txtKategoriOzet.Text,
                    KategoriAd = txtYeniKategoriAdi.Text,
                    UstKategoriId = seciliUstKategori.KategoriId == 0 ? (int?)null : seciliUstKategori.KategoriId,
                });

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            pnUrunBilgileri.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnKategoriEkle.Visible = false;
            cmbYeniCategory.DataSource = KategorileriGetir();

        }

        private void cmbYeniCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            btnYeniUrunEkle.Visible = true;
            cmbUrunCategory.Visible = true;
        }
    }
}
