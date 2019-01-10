using Market.BLL.Helpers;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class KategoriEkleForm : Form
    {
        public KategoriEkleForm()
        {
            InitializeComponent();
        }
    
        private void KategoriEkleForm_Load(object sender, EventArgs e)
        {
            
            KategorileriGetir();
            KategorilerTreeView();

        }

        private void KategorilerTreeView()
        {
            treeKategoriView.Nodes.Clear();
            var categories = new KategoriRepo().GetAll(x => x.UstKategoriId == null).OrderBy(x => x.KategoriAd).ToList();
            foreach (var category in categories)
            {

                TreeNode node = new TreeNode(category.KategoriAd)
                {
                    Tag = category.Id
                };
                treeKategoriView.Nodes.Add(node);
                if (category.Kategoriler.Count>0)
                {
                    UstKategoriSetle(node, category.Kategoriler.OrderBy(x => x.KategoriAd).ToList());
                }
            }
            treeKategoriView.ExpandAll();
        }

        private void UstKategoriSetle(TreeNode node, List<Kategori> categories)
        {
            foreach (var category in categories)
            {
                TreeNode subNode = new TreeNode(category.KategoriAd)
                {
                    Tag = category.Id
                };
                node.Nodes.Add(subNode);
                if (category.Kategoriler.Count>0)
                {
                    UstKategoriSetle(subNode, category.Kategoriler.OrderBy(x => x.KategoriAd).ToList());
                }
            }
        }

        private void KategorileriGetir()
        {

            var categories = new List<KategoriViewModel>
            {
                new KategoriViewModel() {KategoriId = 0,  KategoriAd = "Ust Kategori Ekle"}
            };
            try
            {
                categories.AddRange(new KategoriRepo().GetAll()
                    .OrderBy(x => x.KategoriAd)
                    .Select(x => new KategoriViewModel()
                    {
                        KategoriAd = x.KategoriAd,
                        Aciklama = x.Aciklama,
                        KategoriId = x.Id,
                        SubCategorySayisi = x.Kategoriler.Count                       
                      
                    }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cmbKategoriler.DataSource = categories;
        }

        private void btnYeniKategoriEkle_Click(object sender, EventArgs e)
        {
            if (cmbKategoriler.SelectedItem == null ) return;
            try
            {
                var SeciliKategori = cmbKategoriler.SelectedItem as KategoriViewModel;
                new KategoriRepo().Insert(new Kategori
                {
                    Aciklama = txtAciklama.Text,
                    KategoriAd = txtKategoriAdi.Text,
                    UstKategoriId = SeciliKategori.KategoriId == 0 ? (int?)null : SeciliKategori.KategoriId,
                    
                });
                MessageBox.Show("Kategori Basarılı bir Şekilde Kaydedildi.");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            KategorileriGetir();
            KategorilerTreeView();

        }


        public YeniUrunDetayForm yeniurundetayform;
        private void btnKategoriVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            //Bu şekildede digerdaki public olan tüm alanlara erişebiliyoruz.
            yeniurundetayform.cmbYeniCategory.DataSource = KategoriHelper.EnUstKategorileriGetir();

        }
    
      
    }
}
