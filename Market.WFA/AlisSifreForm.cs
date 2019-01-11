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
        private BarkodAnaForm frmBarkodAna;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "admin" && txtSifre.Text == "1234")
            {
                if (frmBarkodAna == null || frmBarkodAna.IsDisposed)
                {
                    frmBarkodAna = new BarkodAnaForm()
                    {
                        Text = "Barkod Ana Form"
                    };
                }
                pnlSifre.Visible = false;
                this.Close();
                frmBarkodAna.Show();
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
