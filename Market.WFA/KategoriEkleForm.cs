using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class KategoriEkleForm : Form
    {
        public KategoriEkleForm()
        {
            InitializeComponent();
        }

        private void KategoriEkleForm_Load(object sender, EventArgs e)
        {
           

            var categories = new List<KategoriViewModel>
            {
                new KategoriViewModel() { KategoriId=0, KategoriAd = "Üst Kategori Ekle"}
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

        private void btnYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            if (lstCategoryiSec.SelectedItem == null || txtYeniKategoriAdi.Text==string.Empty || txtYeniKategoriAdi.Text=="") return;
            var seciliUstKategori = lstCategoryiSec.SelectedItem as KategoriViewModel;
            try
            {

                new KategoriRepo().Insert(new Kategori
                {
                    Aciklama = txtKategoriOzet.Text,
                    KategoriAd = txtYeniKategoriAdi.Text,
                    UstKategoriId = seciliUstKategori.KategoriId == 0 ? (int?)null : seciliUstKategori.KategoriId,
                });
                MessageBox.Show("Kategori Basarılı bir Şekilde Kaydedildi.");
              
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }
        
        private void btnKategoriVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            
     
        }
    }
}
