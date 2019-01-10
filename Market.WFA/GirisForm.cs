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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private AlisSifreForm frmAlisSifre;
        private void alisIslemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmAlisSifre == null || frmAlisSifre.IsDisposed)
            {
                frmAlisSifre = new AlisSifreForm()
                {
                    MdiParent = this,
                    Text = "Sifre Giris"
                };
            }
            frmAlisSifre.Show();
        }
        private SatisSifreForm frmSatisSifre;
        private void satisIslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSatisSifre == null || frmSatisSifre.IsDisposed)
            {
                frmSatisSifre = new SatisSifreForm()
                {
                    MdiParent = this,
                    Text = "Sifre Giris"
                };
            }
            frmSatisSifre.Show();
        }
    }
}
