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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("select * from kayit where kul_ad='" + txtKullaniciAdi.Text + "'and sifre = '" + txtSifre.Text + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Sepetfrm frm = new Sepetfrm();
                    frm.ShowDialog();
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    txtKullaniciAdi.Clear();
                    txtSifre.Clear();

                }
            }
                baglanti.Close();
            
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGoster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Gizle";
            }
            else if (checkBoxGoster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Göster";
            }
        }

        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
