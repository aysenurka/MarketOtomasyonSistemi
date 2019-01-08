using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class YeniUrunForm : Form
    {
        public YeniUrunForm()
        {
            InitializeComponent();
        }

        private void YeniUrunForm_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            if (pnKategoriEkle.Visible == true) return;
        }

        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            if (pnYeniUrunEkle.Visible == true) return;
        }

        private void btnUrunVazgec_Click(object sender, EventArgs e)
        {
            pnUrunBilgileri.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnYeniUrunEkle.Controls.Clear();
        }

        private void btnKategoriVazgec_Click(object sender, EventArgs e)
        {
            pnUrunBilgileri.Visible = true;
            pnYeniUrunEkle.Visible = false;
            pnKategoriEkle.Controls.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new UrunDetayRepo().Insert(new UrunDetay
                {

                });


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"bir hata olustu");
            }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            //gerek olmayabilir. veritabanında required ise
            if (txtYeniUrunAdi.Text == null || txtYeniUrunAdi.Text==string.Empty) return;
            
            try
            {
                new UrunRepo().Insert(new Urun
                {

                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new KategoriRepo().Insert(new Kategori
                {

                });
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbYeniCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            btnYeniUrunEkle.Visible = true;
            cmbUrunCategory.Visible = true;
        }
    }
}
