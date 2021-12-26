using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AlbumlerBurada
{
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }

        private void lblCik_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Classlar.Musteri musteri = new Classlar.Musteri();

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtBoxAd.Text == "" || txtBoxSoyad.Text == "" || txtBoxKulAd.Text == "" || txtBoxSifre.Text == "" || txtBoxAdres.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                string sorgu = "insert into kayit(ad,soyad,kul_ad,sifre,adres)values(@ad,@soyad,@kulad,@sifre,@adres)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", txtBoxAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtBoxSoyad.Text);
                komut.Parameters.AddWithValue("@kulad", txtBoxKulAd.Text);
                komut.Parameters.AddWithValue("@sifre", txtBoxSifre.Text);
                komut.Parameters.AddWithValue("@adres", txtBoxAdres.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
                musteri.ad = txtBoxAd.Text;
                musteri.soyad = txtBoxSoyad.Text;
                musteri.kullaniciAdi = txtBoxKulAd.Text;
                musteri.sifre = Convert.ToInt32(txtBoxSifre.Text);
                musteri.Adres = txtBoxAdres.Text;

            }   
            
            txtBoxAd.Clear();
            txtBoxSoyad.Clear();
            txtBoxKulAd.Clear();
            txtBoxSifre.Clear();
            txtBoxAdres.Clear();
            baglanti.Close();

            
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster1.CheckState == CheckState.Checked)
            {
                txtBoxSifre.UseSystemPasswordChar = true;
                checkBoxGoster1.Text = "Gizle";
            }
            else if (checkBoxGoster1.CheckState == CheckState.Unchecked)
            {
                txtBoxSifre.UseSystemPasswordChar = false;
                checkBoxGoster1.Text = "Göster";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            this.Visible = false;
            anasayfa.ShowDialog();
            this.Visible = true;
        }
    }
}
