using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using EF_TemelCrudIslemleri.ViewModels;
// ReSharper disable All

namespace EF_TemelCrudIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriGetir();
        }

        private void KategorileriGetir()
        {
            NorthEntities db = new NorthEntities();
            var kategoriler1 = db.Categories
                .OrderBy(category => category.CategoryName)
                .Select(x => new CategoryViewModel
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();

            var kategoriler2 = db.Categories
                .OrderBy(category => category.CategoryName)
                .Select(x => new CategoryViewModel
                {
                    CategoryID = x.CategoryID,
                    CategoryName = x.CategoryName,
                    ProductCount = x.Products.Count
                })
                .ToList();

            cmbUrunKategori.DataSource = kategoriler2;
            cmbKategori.DataSource = kategoriler1;
        }

        private void btnKatKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new NorthEntities();
                db.Categories.Add(new Category()
                {
                    CategoryName = string.IsNullOrEmpty(txtKategoriAdi.Text) ? null: txtKategoriAdi.Text,
                    Description = txtAciklama.Text,
                });
                var sonuc = db.SaveChanges();
                MessageBox.Show($@"{sonuc} kayit eklendi.");
                KategorileriGetir();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationError in dbEx.EntityValidationErrors)
                {
                    foreach (var error in validationError.ValidationErrors)
                    {
                        if (error.PropertyName=="CategoryName")
                        {
                            ep1.SetError(txtKategoriAdi,error.ErrorMessage);
                        }
                    }
                }
                MessageBox.Show(EntityHelper.ValidationMessage(dbEx),@"Bir Hata Olustu",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtKategoriAdi_MouseHover(object sender, EventArgs e)
        {
            try
            {
                ep1.Clear();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;

            CategoryViewModel cat = cmbKategori.SelectedItem as CategoryViewModel;

            var db = new NorthEntities();

            // lstUrunler.DataSource = db.Products.Where(x => x.CategoryID == cat.CategoryID).OrderBy(x => x.ProductName).ToList();
            //   lstUrunler.DisplayMember = "ProductName";

            lstUrunler.DataSource = db.Categories
                .First(x => x.CategoryID == cat.CategoryID)
                .Products
                .Select(x=> new ProductViewModel
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice
            })
                .OrderBy(x=>x.ProductName)
                .ToList();

        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem==null) return;

            var seciliUrun = lstUrunler.SelectedItem as ProductViewModel;

            var db = new NorthEntities();
            var urun = db.Products.Find(seciliUrun.ProductID);

            txtUrunAdi.Text = urun.ProductName;
            nuFiyat.Value = urun.UnitPrice ?? 0;
            var katId = urun.CategoryID;
            cmbUrunKategori.SelectedItem = katId;

            var uruncatList = cmbUrunKategori.DataSource as List<CategoryViewModel>;

            foreach (var item in uruncatList)
            {
                if (item.CategoryID==urun.CategoryID)
                {
                    cmbUrunKategori.SelectedItem = item;
                    break;
                }
            }

            

        }
    }
}
