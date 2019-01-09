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
                     //UrunDetayId = x.Id,
                     //UrunId = x.UrunId,
                     Fiyat = x.Fiyat,
                     UrunAlıstarihi = x.UrunAlısTarihi,
                     BirimAdet = x.BirimAdet

                 }).ToList();

            //txtUrunAdetSayisi.Text = sonuc;

        }
    }
}
