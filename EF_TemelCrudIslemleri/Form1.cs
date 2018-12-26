using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

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
            cmbKategori.DataSource = db.Categories.OrderBy(category => category.CategoryName).ToList();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "CategoryID";
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

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null) return;
            int catId = Int32.Parse(lstUrunler.SelectedValue.ToString());
            var db = new NorthEntities();
            lstUrunler.DataSource = db.Products.Where(x=>x.CategoryID==catId).OrderBy(x=>x.ProductName).ToList();
        }
    }
}
