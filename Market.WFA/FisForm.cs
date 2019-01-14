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
    public partial class FisForm : Form
    {
        public FisForm()
        {
            InitializeComponent();
        }
        public SatisDetayForm satisDetayForm;

        private void FisForm_Load(object sender, EventArgs e)
        {
            satisDetayForm = new SatisDetayForm();
            satisDetayForm.frmFis = this;
        }
    }
}
