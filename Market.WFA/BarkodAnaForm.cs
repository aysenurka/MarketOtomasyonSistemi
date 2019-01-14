using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class BarkodAnaForm : Form
    {
        public BarkodAnaForm()
        {
            InitializeComponent();
        }

        private KayitliUrunAlisForm kayitliurunalisform;
        string ara;
        private void btnBarkodUret_Click(object sender, EventArgs e)
        {

            #region Barkod

            txtBarkod.Visible = true;
            PrintDocument doc = new PrintDocument();
            Barkod barkod = new Barkod();

            barkod.Height = 30f;
            barkod.Width = 70f;
            barkod.FontSize = 16f;
            //bu kod barkodun ilk 2 hanesi -ülke kodu
            barkod.CountryCode = "90";
            //Bu kod üretici-imalatçı numarası -bu kısımın legal illegal gibi durumları da var
            barkod.ManufacturerCode = "95525";
            //Bu kod ürün kodu
            barkod.ProductCode = UrunKodu();
            //Bu kısım boş geçilsede birşey değişmiyor EAN-13 te zaten 12 veri okuyorsunuz ,bu sayı  barkodun sonunda oluyor. kontrol kodu
            barkod.ChecksumDigit = "0";
            pictureBox1.Image = barkod.CreateBitmap();
            txtBarkod.Text = barkod.ToString();
            this.ActiveControl = txtBarkod;
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
            #endregion
            ara = txtBarkod.Text;
            var sonuc = new UrunDetayRepo().GetAll().FirstOrDefault(x => x.Barkod == ara);
            if (sonuc == null)
            {
                YeniUrunDetayForm yeniurunform = new YeniUrunDetayForm();
                yeniurunform.txtBarkodNo.Text = ara;
                yeniurunform.Show();

            }
            else
            {
                KayitliUrunAlisForm kayitliurunalisform = new KayitliUrunAlisForm();
                kayitliurunalisform.txtBarkodNo.Text = ara;
                kayitliurunalisform.Show();

            }
            txtBarkod.Text = string.Empty;
        }
        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0,5);
            return sayi.ToString();
        }
        private void btnBarkodUret_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Barkod okundu");
            }
        }


        private void BarkodAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunAl_Click(object sender, EventArgs e)
        {
            pnUrunKabul.Visible = true;
            pnUrunStok.Visible = false;
        }

        private void btnStokSiparis_Click(object sender, EventArgs e)
        {
            lstStokdaAzalanUrunler.DataSource = UrunHelper.StoktakiAzalanUrunler();
            pnUrunStok.Visible = true;
            pnUrunKabul.Visible = false;
        }

        private void lstStokdaAzalanUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuSiparisAdet.Value = 1;
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (lstStokdaAzalanUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Bir Ürün Seciniz");
                return;
            }
            else
            {
                var secili = lstStokdaAzalanUrunler.SelectedItem as UrunSiparisViewModel;
                secili.AlınanSiparisSayisi =(int)nuSiparisAdet.Value;
                var sonuc = new UrunRepo().UrunStokSiparis(secili);
                MessageBox.Show($"{sonuc} Siparis Edildi.");
                lstStokdaAzalanUrunler.DataSource = UrunHelper.StoktakiAzalanUrunler();
            }
        }
    }
}
