using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AlbumlerBurada
{
    public partial class AlbumIslemler : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public AlbumIslemler()
        {
            InitializeComponent();
        }
        
        void AlbumGetir()
        {
            baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Album", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView.DataSource = tablo;
            baglanti.Close();
        }
        private void AlbumIslemler_Load(object sender, EventArgs e)
        {
            AlbumGetir();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAd.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxSanatci.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxfiyati.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
      
           
        }
        Classlar.Album album1 = new Classlar.Album();

        private void buttonEkle_Click(object sender, EventArgs e)
        {

            if (textBoxAd.Text == "" || textBoxSanatci.Text == "" || textBoxfiyati.Text == ""  )
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                string sorgu = "INSERT INTO Album(adi,sanatci,fiyati,cikisYili,eklenmeTarihi) VALUES (@ad,@sanatci,@fiyat,@dcikisyili,@deklenmeTarihi)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@ad", textBoxAd.Text);
                komut.Parameters.AddWithValue("@sanatci", textBoxSanatci.Text);
                komut.Parameters.AddWithValue("@fiyat", textBoxfiyati.Text);
                komut.Parameters.AddWithValue("@dcikisyili", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@deklenmeTarihi", dateTimePicker2.Value);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                AlbumGetir();

                album1.albumAdi = textBoxAd.Text;
                album1.sanatciAdi = textBoxSanatci.Text;
                album1.fiyati = Convert.ToInt32(textBoxfiyati.Text);
                album1.cikisYili = dateTimePicker1.Value;
                album1.eklenmeTarihi = dateTimePicker2.Value;


                MessageBox.Show("Albüm eklendi.");

            }
            textBoxAd.Clear();
            textBoxSanatci.Clear();
            textBoxfiyati.Clear();
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Album WHERE adi=@adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adi", dataGridView.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AlbumGetir();
            MessageBox.Show("Albüm silindi");
 


        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Album set fiyati=@fiyati WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView.CurrentRow.Cells["id"].Value));
            komut.Parameters.AddWithValue("@fiyati", textBoxfiyati.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Albüm bilgileri güncellendi.");
        }
    }
}
