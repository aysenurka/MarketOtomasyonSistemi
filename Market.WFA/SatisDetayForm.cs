using Market.BLL.Helpers;
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
    public partial class SatisDetayForm : Form
    {
        public SatisDetayForm()
        {
            InitializeComponent();
        }

        private void SatisDetayForm_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = UrunHelper.UrunleriGetir();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            pnlOdeme.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            
        }
    }
}
