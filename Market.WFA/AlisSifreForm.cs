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
    public partial class AlisSifreForm : Form
    {
        public AlisSifreForm()
        {
            InitializeComponent();
        }
        private YeniUrunDetayForm frmYeniUrunDetay;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "admin" && txtSifre.Text == "1234")
            {
                if (frmYeniUrunDetay == null || frmYeniUrunDetay.IsDisposed)
                {
                    frmYeniUrunDetay = new YeniUrunDetayForm()
                    {
                        Text = "Yeni Urun Detay Form"
                    };
                }
                lblAd.Visible = false;
                lblSifre.Visible = false;
                txtAd.Visible = false;
                txtSifre.Visible = false;
                btnGiris.Visible = false;
                this.Close();
                frmYeniUrunDetay.Show();
            }
            else
            {
                MessageBox.Show("Giris denemesi basarisiz, lutfen tekrar deneyin");
                txtAd.Text = string.Empty;
                txtSifre.Text = string.Empty;
            }
        }
    }
}
