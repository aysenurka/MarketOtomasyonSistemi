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
using Market.Models.Entities;

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
            if (seciliUrun.UrunStok > 0)
            {
                if (varMi)
                    sepettekiUrun.Adet++;
                else
                {
                    sepet.Add(new SepetViewModel()
                    {
                        UrunId = seciliUrun.UrunId,
                        UrunAdi = seciliUrun.UrunAd,
                        BirimFiyat = seciliUrun.UrunFiyat,
                        Adet = 1,
                        UrunDetayId = seciliUrun.UrunDetayId
                        //Kdv =seciliUrun.UrunDetay.Kdv
                    });
                }
                seciliUrun.UrunStok--;
            }
            SepetGetir();
        }
        private decimal total;
        private void SepetGetir()
        {
            lstSepet.Items.Clear();

            foreach (var sepetViewModel in sepet)
                lstSepet.Items.Add(sepetViewModel);

            total = sepet.Sum(x => x.ToplamFiyat());
            lblToplam.Text = $"Toplam: {total:c2}";
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            pnlOdeme.Visible = true;
            btnEkle.Enabled = false;
            lstSepet.Enabled = false;
            lstUrunler.Enabled = false;
            btnOde.Enabled = false;
            cbPoset.Visible = true;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked)
            {
                lblNakit.Visible = true;
                txtNakit.Visible = true;
                btnTamamla.Visible = true;
            }
        }

        private void rbKart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbKart.Checked)
            {
                lblNakit.Visible = false;
                txtNakit.Visible = false;
                btnTamamla.Visible = false;
                lblParaUstu.Visible = false;
                btnTamamla.Visible = true;
            }
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true)
            {
                if (txtNakit == null || txtNakit.Text == "")
                {
                    MessageBox.Show("Lutfen nakit girisi yapınız");
                }
                else
                {
                    var odenen = Convert.ToDecimal(txtNakit.Text);
                    if (odenen >= anaToplam)
                    {
                        lblParaUstu.Visible = true;
                        lblParaUstu.Text = $"Para Ustu: {(odenen - anaToplam):c2}";
                    }
                    else MessageBox.Show("Girilen para yetersiz");
                }
            }
        }
        private int posetSayisi = 0;
        private decimal posetFiyat;
        private decimal anaToplam = 0;
        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoset.Checked == true)
            {
                nuPoset.Visible = true;
            }
        }

        private void nuPoset_ValueChanged(object sender, EventArgs e)
        {
            posetSayisi = (int)nuPoset.Value;
            posetFiyat = Convert.ToDecimal(posetSayisi * 0.25);
            anaToplam = total + posetFiyat;
            lblToplam.Text = $"Toplam: {anaToplam:c2}";
        }
    }
}
