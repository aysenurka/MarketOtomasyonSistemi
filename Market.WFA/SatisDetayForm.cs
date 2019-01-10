using Market.BLL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Models.ViewModels;

namespace Market.WFA
{
    public partial class SatisDetayForm : Form
    {
        public SatisDetayForm()
        {
            InitializeComponent();
        }

        private List<SepetViewModel> sepet = new List<SepetViewModel>();
        private UrunViewModel seciliUrun;
        private void SatisDetayForm_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = UrunHelper.UrunleriGetir();
            //lstSepet.DataSource=
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            pnlOdeme.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            seciliUrun = lstUrunler.SelectedItem as UrunViewModel;

            bool varMi = false;
            var sepettekiUrun = new SepetViewModel();
            foreach (var sepetViewModel in sepet)
            {
                if (seciliUrun.UrunId == sepetViewModel.UrunId)
                {
                    varMi = true;
                    sepettekiUrun = sepetViewModel;
                    break;
                }
            }

            if (varMi)
                sepettekiUrun.Adet++;
            else
            {
                sepet.Add(new SepetViewModel()
                {
                    UrunId = seciliUrun.UrunId,
                    UrunAdi = seciliUrun.UrunAd,
                    BirimFiyat = seciliUrun.UrunFiyat,
                    Adet = 1
                    //Kdv =seciliUrun.UrunDetay.Kdv
                });
            }

            SepetGetir();
        }

        private void SepetGetir()
        {
            lstSepet.Items.Clear();

            foreach (var sepetViewModel in sepet)
                lstSepet.Items.Add(sepetViewModel);

            var total = sepet.Sum(x => x.ToplamFiyat());
            lblToplam.Text = $"Toplam: {total:c2}";
        }
    }
}
