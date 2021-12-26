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
    public partial class Müsteriler : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Müsteriler()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM kayit", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewMusteriler.DataSource = tablo;
            baglanti.Close();
        }
        private void Müsteriler_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM kayit WHERE ad=@ad";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", dataGridViewMusteriler.CurrentRow.Cells[0].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();

            MessageBox.Show("Müşteri silindi");
        }

        private void dataGridViewMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            this.Visible = false;
            anasayfa.ShowDialog();
            this.Visible = true;
        }
    }
}
