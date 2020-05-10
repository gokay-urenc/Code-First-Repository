using Code_First_Repository.DAL.Context;
using Code_First_Repository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_First_Repository
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectContext db = new ProjectContext();
            Product yeniUrun = new Product();
            yeniUrun.Name = txtAd.Text;
            yeniUrun.Price = Convert.ToDecimal(txtFiyat.Text);
            yeniUrun.UnitsInStock = Convert.ToInt16(txtStokMiktari.Text);
            db.Urunler.Add(yeniUrun);
            int sonuc = db.SaveChanges();
            MessageBox.Show(sonuc > 0 ? "Ürün ekleme başarılı" : "Ürün ekleme sırasında hata oluştu.");
        }
    }
}