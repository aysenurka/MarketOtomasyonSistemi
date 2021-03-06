﻿using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class YeniUrunDetayForm : Form
    {
        public YeniUrunDetayForm()
        {
            InitializeComponent();
        }

        private void YeniUrunForm_Load(object sender, EventArgs e)
        {
            cmbYeniCategory.DataSource = KategoriHelper.EnUstKategorileriGetir();

            cmbUrunCategory.DataSource = UrunHelper.UrunleriGetir();
            cmbUrunCategory.DisplayMember = "UrunAd";
        }

     
        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkleForm urunekle = new UrunEkleForm();
            urunekle.yeniurundetayform = this;
            urunekle.Show();
         
        }

        private void btnYeniKategori_Click(object sender, EventArgs e)
        {
            //Formlar Arası geçiş ve geri deger döndürme bu şekilde yapmamızlazım.
            KategoriEkleForm urun = new KategoriEkleForm();
            urun.Show();
            urun.yeniurundetayform = this;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var id = new UrunDetayRepo().UrunDetayEkle(new KayitliOlmayanUrunViewModel()
                {
                    Barkod = txtBarkodNo.Text,
                    Adet = (int)nuAdet.Value,
                    Indirim = nuYeniUrunIndirim.Value,
                    Kar = nuUrunKarOranı.Value,
                    Kdv = nuYeniUrunKdvDegeri.Value,
                    UrunId = (cmbUrunCategory.SelectedItem as UrunViewModel).UrunId,
                    CategoryId = (cmbYeniCategory.SelectedItem as KategoriViewModel).KategoriId,
                    UrunAlındıgıTarih = DateTime.Now,
                    BirimAdet= (int)nuUrunAdetBilgisi.Value,
                    Fiyat=nuUrunKoliFiyati.Value,
                     UrunAdetAciklama=richAdetAciklama.Text

                });

                MessageBox.Show($"Oldu bu iş\n{id}");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "bir hata olustu");
            }
            this.Close();
        }
    }
}
