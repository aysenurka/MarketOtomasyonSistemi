﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class BarkodAnaForm : Form
    {
        public BarkodAnaForm()
        {
            InitializeComponent();
        }

        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 1500);
            return sayi.ToString();
        }
        private void btnBarkodUret_Click(object sender, EventArgs e)
        {

            txtBarkod.Visible = true;
            PrintDocument doc = new PrintDocument();
            Market.WFA.Ean13 barkod = new Market.WFA.Ean13();

            barkod.Height = 30f;
            barkod.Width = 70f;
            barkod.FontSize = 16f;
            //bu kod barkodun ilk 2 hanesi -ülke kodu
            barkod.CountryCode = "90";
            //Bu kod üretici-imalatçı numarası -bu kısımın legal illegal gibi durumları da var
            barkod.ManufacturerCode = "95525";
            //Bu kod ürün kodu
            barkod.ProductCode = UrunKodu();
            //Bu kısım boş geçilsede birşey değişmiyor EAN-13 te zaten 12 veri okuyorsunuz ,bu sayı  barkodun sonunda oluyor. kontrol kodu
            barkod.ChecksumDigit = "0";
            pictureBox1.Image = barkod.CreateBitmap();
            txtBarkod.Text = barkod.ToString();
            this.ActiveControl = txtBarkod;
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;

        }

        private void btnBarkodUret_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Barkod okundu");
            }
        }
    }
}
