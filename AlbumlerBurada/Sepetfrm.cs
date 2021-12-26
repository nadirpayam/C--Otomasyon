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
    public partial class Sepetfrm : Form
    {
        public Sepetfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void AlbumGetir()
        {
            baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM album", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewSepet1.DataSource = tablo;
            baglanti.Close();
        }
        private void Sepetfrm_Load(object sender, EventArgs e)
        {
            AlbumGetir();
        }

        Classlar.SiparisDetayi siparis = new Classlar.SiparisDetayi();
        private void btnSiparis_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Çek")
            {
                OdemeCek cekkk = new OdemeCek();
                cekkk.ShowDialog();
                siparis.OdemeYontemi = "Çek";
            }
            else if(comboBox1.Text == "Kredi Kartı")
            {
                OdemeKart karttt = new OdemeKart();
                karttt.ShowDialog();
                siparis.OdemeYontemi = "Kredi Kartı";
            }
            else
            {
                Classlar.Nakit nakt = new Classlar.Nakit();
                nakt.Odemek();
                siparis.OdemeYontemi = "Nakit";
            }
        }

        double vergi, total, tutar;

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string adet, fiyat, ad;
        double toplam = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxAdet.Text == "" )
            {
                MessageBox.Show("Lütfen adeti ekleyin.");
            }
            else
            {
                adet = textBoxAdet.Text;
                listBox2.Items.Add(adet);
                textBoxAdet.Clear();
                siparis.Adet = Convert.ToInt32(textBoxAdet.Text);


                ad = dataGridViewSepet1.CurrentRow.Cells[0].Value.ToString();
                fiyat = dataGridViewSepet1.CurrentRow.Cells[2].Value.ToString();
                tutar = (Convert.ToDouble(fiyat)) * (Convert.ToDouble(adet));
                listBox1.Items.Add(ad);
                listBox3.Items.Add(tutar.ToString());

               
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    toplam += Convert.ToDouble(listBox3.Items[i]);
                }

                vergi = toplam * 20 / 100;
                total = vergi + toplam;
                textBoxTutar.Text = toplam.ToString();

                textBoxVergi.Text = vergi.ToString();
                textBoxToplamTutar.Text = total.ToString();

                siparis.Tutar = Convert.ToInt32(textBoxToplamTutar.Text);


            }
            
        }
    }
}
