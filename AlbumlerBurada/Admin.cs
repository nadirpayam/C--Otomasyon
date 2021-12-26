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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=giris;Integrated Security=True");
        private void btnAdmingiris_Click(object sender, EventArgs e)
        {
            
       try
            {
                baglanti.Open();
                string sql = "Select * From parola where ad=@adi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", txtBoxAdmin.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", txtBoxAdminSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    KontrolPaneli fr = new KontrolPaneli();
                    fr.Show();
                }    
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            this.Visible = false;
            anasayfa.ShowDialog();
            this.Visible = true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
