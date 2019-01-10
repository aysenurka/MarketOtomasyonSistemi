using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class UrunEkleForm : Form
    {
        public UrunEkleForm()
        {
            InitializeComponent();
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            if (txtYeniUrunAdi.Text == null || txtYeniUrunAdi.Text == string.Empty) return;

            try
            {
                new UrunRepo().Insert(new Urun
                {
                    UrunAd = txtYeniUrunAdi.Text,
                    KategoriId = (cmbKategoriler.SelectedItem as KategoriViewModel).KategoriId,
                    //UrunStok = 0,
                    //UrunFiyat = 0

                });
                MessageBox.Show("Urun basarili bir sekilde kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Urun eklenirken bir hata olustu\n"+ex.Message);
            }
            yeniurundetayform.cmbUrunCategory.DataSource = UrunHelper.UrunleriGetir();
        }

        private void UrunEkleForm_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DataSource =KategoriHelper.EnUstKategorileriGetir();
        }

        public YeniUrunDetayForm yeniurundetayform;
        private void btnUrunVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            yeniurundetayform.cmbUrunCategory.DataSource = UrunHelper.UrunleriGetir();
        }
    }
}
