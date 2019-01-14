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
using Market.BLL.Repository;
using Market.Models.Enums;

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
        public FisForm frmFis;
        private void SatisDetayForm_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = UrunHelper.UrunleriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            seciliUrun = lstUrunler.SelectedItem as UrunViewModel;

            btnOde.Visible = true;
            lblToplam.Visible = true;

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

                //var guncellenecekUrun = new UrunRepo().GetById(seciliUrun.UrunId);
                //guncellenecekUrun.UrunStok = --seciliUrun.UrunStok;
                //new UrunRepo().Update();
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
                pnlNakit.Visible = true;
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

                odemeBasarili = true;

                if (cbPoset.Checked == false)
                    anaToplam = total;
            }
        }

        private bool odemeBasarili = false;
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

                    if (posetSayisi == 0)
                        anaToplam = total;

                    if (odenen >= anaToplam)
                    {
                        lblParaUstu.Visible = true;
                        lblParaUstu.Text = $"Para Ustu: {(odenen - anaToplam):c2}";
                        odemeBasarili = true;
                    }
                    else
                    {
                        odemeBasarili = false;
                        MessageBox.Show("Girilen para yetersiz");
                    }
                }
            }

            var rbuttonlar = pnlOdeme.Controls.OfType<RadioButton>().ToArray();
            var odemeIndex = Array.IndexOf(rbuttonlar, rbuttonlar.Single(rb => rb.Checked));

            if (rbNakit.Checked == true || rbKart.Checked == true)
            {
                try
                {
                    //new SatisRepo().Insert(new Satis
                    //{
                    //    SatisTarih = DateTime.Now,
                    //    ToplamFiyat = anaToplam,
                    //    OdemeTipi = (OdemeTipi)odemeIndex
                    //});
                    var ekle = new SatisDetayRepo();
                    var urunler = new SatisDetayViewModel
                    {
                         anatoplam=anaToplam,
                          odemeTipi=(OdemeTipi)odemeIndex,
                           SepetModel=sepet,     
                    };
                    ekle.SatisYap(urunler);
                    MessageBox.Show("Oldu bu iş");
                }
                catch (Exception)
                {
                    MessageBox.Show("Satıs eklenirken bir hata olustu");
                }
            }

            if (odemeBasarili)
            {
                //FormSifirla();
                SepetGetir();

                if (frmFis == null || frmFis.IsDisposed)
                {
                    frmFis = new FisForm()
                    {
                        Text = "Fiş Form"
                    };
                    frmFis.Show();

                }
                frmFis.satisDetayForm = this;
                foreach (var item in sepet)
                {
                    frmFis.lblFisInfo.Text += $"{item.ToString()}\n";
                }
                if (odemeIndex == 0)
                    frmFis.lblFisInfo.Text += $"\n\n\nToplam: {anaToplam}\n\n\nOdeme Tipi: {(OdemeTipi)odemeIndex}";
                else if(odemeIndex==1)
                    frmFis.lblFisInfo.Text += $"\n\n\nToplam: {anaToplam}\n\n\nOdeme Tipi: {(OdemeTipi)odemeIndex}" +
                        $"\n{lblParaUstu.Text}";
                //frmFis.lblFisInfo.Text += "bilgiler aktarıldı";

                FormSifirla();
                this.Close();

            }
        }

        private void FormSifirla()
        {
            MessageBox.Show("Odeme tamamlandı");

            lstUrunler.DataSource = UrunHelper.UrunleriGetir();
            lstUrunler.Enabled = true;
            btnEkle.Enabled = true;
            lstSepet.Enabled = true;
            btnOde.Enabled = true;
            btnOde.Visible = false;
            btnTamamla.Visible = false;
            pnlOdeme.Visible = false;
            pnlOdeme.Controls.Clear();
            pnlNakit.Visible = false;
            pnlNakit.Controls.Clear();
            lblToplam.Text = "Toplam:";
            lblParaUstu.Text = "Para Üstü:";
            cbPoset.Checked = false;
            nuPoset.Value = 0;
            cbPoset.Visible = false;
            nuPoset.Visible = false;

            odemeBasarili = false;

            sepet = new List<SepetViewModel>();
        }

        private int posetSayisi = 0;
        private decimal posetFiyat;
        private decimal anaToplam;
        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoset.Checked == true)
            {
                nuPoset.Visible = true;
            }
            else if (cbPoset.CheckState == CheckState.Unchecked)
                posetSayisi = 0;

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
