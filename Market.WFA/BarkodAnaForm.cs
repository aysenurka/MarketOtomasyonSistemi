using Market.BLL.Repository;
using Market.Models.Entities;
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
        private YeniUrunForm yeniurunform;
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
            var sonuc = new UrunDetayRepo().GetAll().FirstOrDefault(x=>x.Barkod==ara);
            if (sonuc==null)
            {
                if (yeniurunform == null || yeniurunform.IsDisposed)
                {
                    yeniurunform = new YeniUrunForm
                    {
                        MdiParent = this
                    };
                    yeniurunform.Show();
                    yeniurunform.txtBarkodNo.Text = ara;
                }
             
              
            }
            else
            {
                if (kayitliurunalisform == null || kayitliurunalisform.IsDisposed)
                {
                    kayitliurunalisform = new KayitliUrunAlisForm
                    {
                        MdiParent = this
                    };
                    kayitliurunalisform.Show();
                    kayitliurunalisform.txtBarkodNo.Text = ara;
                }

            }
        }
        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 1500);
            return sayi.ToString();
        }
        private void btnBarkodUret_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Barkod okundu");
            }
        }
    }
}
