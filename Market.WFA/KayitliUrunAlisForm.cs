using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
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

        private void KayıtlıUrunAlısForm_Load(object sender, EventArgs e)
        {
            var urunbul = txtBarkodNo.Text;
            var sonuc = new UrunDetayRepo().GetAll().Where(x => x.Barkod == urunbul)
                 .Select(x => new KayitliUrunDetayViewModel
                 {
                     barkod = x.Barkod,
                     //Düzeltilcek CategoryId=x.Urun.KategoriId,
                     UrunDetayId = x.Id,
                     UrunId = x.UrunId,
                     Fiyat = x.Fiyat,
                     UrunAlıstarihi = x.UrunAlısTarihi,
                     BirimAdet = x.BirimAdet,
                     Urun = x.Urun,
                     Kategori = x.Urun.Kategori,


                 }).ToList().FirstOrDefault();

            txtBarkodNo.Text = sonuc.barkod;
            txtAlinanadetSayisi.Text = sonuc.BirimAdet.ToString();
            txtUrunİsmi.Text = sonuc.Urun.UrunAd;

        }
    }
}
