using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrudOdev.ViewModels;

namespace CrudOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<ProductViewModel> aramalar = new List<ProductViewModel>();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            UrunleriGetir();
            CalisanlariGetir();
            MusterileriGetir();
            NakliyecileriGetir();
        }

        private void NakliyecileriGetir()
        {
            var db = new NorthEntities();
            var nakliyeciler = db.Shippers
                .OrderBy(x => x.CompanyName)
                .Select(x => new ShipperViewModel()
                {
                    ShipperID = x.ShipperID,
                    CompanyName = x.CompanyName,
                }).ToList();
            cbNakliye.DataSource = nakliyeciler;
        }

        private void MusterileriGetir()
        {
            var db = new NorthEntities();
            var musteriler = db.Customers
                .OrderBy(x => x.ContactName)
                .Select(x => new CustomerViewModel()    
                {
                    CustomerID = x.CustomerID,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName
                }).ToList();
            cbMusteri.DataSource = musteriler;
        }

        private void CalisanlariGetir()
        {
            var db = new NorthEntities();
            var calisanlar = db.Employees
                .OrderBy(x => x.FirstName)
                .Select(x => new EmployeeViewModel()
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();
            cbCalisan.DataSource = calisanlar;
        }

        private void UrunleriGetir()
        {
            var db = new NorthEntities();
            var urunler = db.Products
                .OrderBy(p => p.ProductName)
                .Select(x => new ProductViewModel
                {
                    ProductID = x.ProductID,
                    ProductName = x.ProductName,
                }).ToList();
            lstUrunler.DataSource = urunler;
        }

        private void txtArama_KeyUp(object sender, KeyEventArgs e)
        {
            var db = new NorthEntities();
            var ara = txtArama.Text.ToLower();
            aramalar = new List<ProductViewModel>();

            db.Products.Where(x => x.ProductName.ToLower().Contains(ara)).ToList().ForEach(x =>
                aramalar.Add(new ProductViewModel()
                {
                    ProductName = x.ProductName,
                    ProductID = x.ProductID
                }));
            lstUrunler.DataSource = aramalar.ToList();
        }

        private void btnSepeteEkle_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
