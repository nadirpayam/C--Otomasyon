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
    public partial class OdemeCek : Form
    {
        public OdemeCek()
        {
            InitializeComponent();
        }

        Classlar.CekOdeme cek123 = new Classlar.CekOdeme();


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                cek123.cekSahibininAdi = textBox1.Text;
                cek123.bankaId = textBox2.Text;
                cek123.Odemek();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sepetfrm sepet = new Sepetfrm();
            this.Visible = false;
            sepet.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAnasayfa anasayfa = new FormAnasayfa();
            this.Visible = false;
            anasayfa.ShowDialog();
            this.Visible = true;
        }

        private void OdemeCek_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
