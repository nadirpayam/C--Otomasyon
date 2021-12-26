using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumlerBurada
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriGiris musteri = new MusteriGiris();

            _ = musteri.ShowDialog();
   
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            KayıtOl kaydol = new KayıtOl();
            this.Visible = false;
            kaydol.ShowDialog();
            this.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
