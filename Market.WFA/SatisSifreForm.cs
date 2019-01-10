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
    public partial class SatisSifreForm : Form
    {
        public SatisSifreForm()
        {
            InitializeComponent();
        }
        private SatisDetayForm frmSatisDetay;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "admin2" && txtSifre.Text == "1234")
            {
                if (frmSatisDetay == null || frmSatisDetay.IsDisposed)
                {
                    frmSatisDetay = new SatisDetayForm()
                    {
                        Text = "Satis Detay Form"
                    };
                }
                pnlSifre.Visible = false;
                this.Close();
                frmSatisDetay.Show();
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
