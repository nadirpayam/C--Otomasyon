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
    public partial class OdemeKart : Form
    {
        public OdemeKart()
        {
            InitializeComponent();
        }
        Classlar.KrediKarti kart123 = new Classlar.KrediKarti();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text=="" || comboBox2.Text=="" || comboBox3.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                kart123.kartSahibi = textBox1.Text;
                kart123.kartNumarasi = textBox2.Text;
                kart123.Odemek();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OdemeKart_Load(object sender, EventArgs e)
        {

        }
    }
}
