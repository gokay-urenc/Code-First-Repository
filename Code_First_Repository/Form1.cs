using Code_First_Repository.DAL.Context; //
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectContext db = new ProjectContext();
            if (db.Kullanicilar.Any(x => x.UserName == txtKullaniciAdi.Text && x.password == txtSifre.Text))
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                lblHata.Text = "Giriş bilgileri hatalı.";
                lblHata.Visible = true;
            }
        }
    }
}