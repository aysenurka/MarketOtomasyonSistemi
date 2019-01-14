using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.BLL.Repository;

namespace Market.WFA
{
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            //var urunler = new UrunRepo().GetAll();
            //var urunDetaylar = new UrunDetayRepo().GetAll();
            //var kategoriler = new KategoriRepo().GetAll();
            //var satislar = new SatisRepo().GetAll();
            //var satisDetaylar = new SatisDetayRepo().GetAll();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarihSec.Value;
            GunlukRapor(tarih);
        }

        private void GunlukRapor(DateTime seciliTarih)
        {
            var urunler = new UrunRepo().GetAll();
            var urunDetaylar = new UrunDetayRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var satisDetaylar = new SatisDetayRepo().GetAll();

            var gunluk = from u in urunler
                         join ud in urunDetaylar on u.Id equals ud.UrunId
                         join k in kategoriler on u.KategoriId equals k.Id
                         join sd in satisDetaylar on u.Id equals sd.Id2
                         join s in satislar on sd.Id equals s.Id
                         where s.SatisTarih.Date == seciliTarih.Date
                         group new
                         {
                             u,
                             ud,
                             k,
                             sd,
                             s
                         } by new
                         {
                             s.Id,
                             s.SatisTarih,
                             u.UrunAd,
                             k.KategoriAd,
                             s.ToplamFiyat,
                             s.OdemeTipi,
                             sd.Adet,
                             u.UrunFiyat,
                             u.UrunStok
                         }
                into gp
                         orderby gp.Key.Id
                         orderby gp.Key.KategoriAd
                         select new
                         {
                             gp.Key.Id,
                             gp.Key.SatisTarih,
                             gp.Key.UrunAd,
                             gp.Key.UrunFiyat,
                             gp.Key.UrunStok,
                             gp.Key.KategoriAd,
                             gp.Key.OdemeTipi,
                             gp.Key.ToplamFiyat,
                             //gp.Key.Adet
                             ToplamAdet = gp.Sum(x => x.sd.Adet)
                         };

            dgvRapor.DataSource = gunluk.ToList();

        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarihSec.Value;
            HaftalikRapor(tarih);
        }

        private void HaftalikRapor(DateTime seciliTarih)
        {
            DateTime birHafta = dtpTarihSec.Value.AddDays(-7);

            var urunler = new UrunRepo().GetAll();
            var urunDetaylar = new UrunDetayRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var satisDetaylar = new SatisDetayRepo().GetAll();

            var haftalik = from u in urunler
                           join ud in urunDetaylar on u.Id equals ud.UrunId
                           join k in kategoriler on u.KategoriId equals k.Id
                           join sd in satisDetaylar on u.Id equals sd.Id2
                           join s in satislar on sd.Id equals s.Id
                           where s.SatisTarih <= seciliTarih && s.SatisTarih >= birHafta
                           group new
                           {
                               u,
                               ud,
                               k,
                               sd,
                               s
                           } by new
                           {
                               s.Id,
                               s.SatisTarih,
                               u.UrunAd,
                               k.KategoriAd,
                               s.ToplamFiyat,
                               s.OdemeTipi,
                               sd.Adet,
                               u.UrunFiyat,
                               u.UrunStok
                           }
                into gp
                           orderby gp.Key.Id
                           orderby gp.Key.KategoriAd
                           select new
                           {
                               gp.Key.Id,
                               gp.Key.SatisTarih,
                               gp.Key.UrunAd,
                               gp.Key.UrunFiyat,
                               gp.Key.UrunStok,
                               gp.Key.KategoriAd,
                               gp.Key.OdemeTipi,
                               gp.Key.ToplamFiyat,
                               //gp.Key.Adet
                               ToplamAdet = gp.Sum(x => x.sd.Adet)
                           };

            dgvRapor.DataSource = haftalik.ToList();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarihSec.Value;
            AylikRapor(tarih);
        }

        private void AylikRapor(DateTime seciliTarih)
        {
            DateTime birAy = dtpTarihSec.Value.AddMonths(-1);

            var urunler = new UrunRepo().GetAll();
            var urunDetaylar = new UrunDetayRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var satisDetaylar = new SatisDetayRepo().GetAll();

            var aylik = from u in urunler
                        join ud in urunDetaylar on u.Id equals ud.UrunId
                        join k in kategoriler on u.KategoriId equals k.Id
                        join sd in satisDetaylar on u.Id equals sd.Id2
                        join s in satislar on sd.Id equals s.Id
                        where s.SatisTarih <= seciliTarih && s.SatisTarih >= birAy
                        group new
                        {
                            u,
                            ud,
                            k,
                            sd,
                            s
                        } by new
                        {
                            s.Id,
                            s.SatisTarih,
                            u.UrunAd,
                            k.KategoriAd,
                            s.ToplamFiyat,
                            s.OdemeTipi,
                            sd.Adet,
                            u.UrunFiyat,
                            u.UrunStok
                        }
                into gp
                        orderby gp.Key.Id
                        orderby gp.Key.KategoriAd
                        select new
                        {
                            gp.Key.Id,
                            gp.Key.SatisTarih,
                            gp.Key.UrunAd,
                            gp.Key.UrunFiyat,
                            gp.Key.UrunStok,
                            gp.Key.KategoriAd,
                            gp.Key.OdemeTipi,
                            gp.Key.ToplamFiyat,
                            //gp.Key.Adet
                            ToplamAdet = gp.Sum(x => x.sd.Adet)
                        };

            dgvRapor.DataSource = aylik.ToList();
        }

        private void btnYillik_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarihSec.Value;
            YillikRapor(tarih);
        }

        private void YillikRapor(DateTime seciliTarih)
        {
            DateTime birYil = dtpTarihSec.Value.AddYears(-1);

            var urunler = new UrunRepo().GetAll();
            var urunDetaylar = new UrunDetayRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var satislar = new SatisRepo().GetAll();
            var satisDetaylar = new SatisDetayRepo().GetAll();

            var yillik = from u in urunler
                         join ud in urunDetaylar on u.Id equals ud.UrunId
                         join k in kategoriler on u.KategoriId equals k.Id
                         join sd in satisDetaylar on u.Id equals sd.Id2
                         join s in satislar on sd.Id equals s.Id
                         where s.SatisTarih <= seciliTarih && s.SatisTarih >= birYil
                         group new
                         {
                             u,
                             ud,
                             k,
                             sd,
                             s
                         } by new
                         {
                             s.Id,
                             s.SatisTarih,
                             u.UrunAd,
                             k.KategoriAd,
                             s.ToplamFiyat,
                             s.OdemeTipi,
                             sd.Adet,
                             u.UrunFiyat,
                             u.UrunStok
                         }
                into gp
                         orderby gp.Key.Id
                         orderby gp.Key.KategoriAd
                         select new
                         {
                             gp.Key.Id,
                             gp.Key.SatisTarih,
                             gp.Key.UrunAd,
                             gp.Key.UrunFiyat,
                             gp.Key.UrunStok,
                             gp.Key.KategoriAd,
                             gp.Key.OdemeTipi,
                             gp.Key.ToplamFiyat,
                             //gp.Key.Adet,
                             ToplamAdet = gp.Sum(x => x.sd.Adet)
                         };

            dgvRapor.DataSource = yillik.ToList();
        }
    }
}
