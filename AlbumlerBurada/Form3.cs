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
    public partial class KontrolPaneli : Form
    {
        public KontrolPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            AlbumIslemler alb = new AlbumIslemler();
            alb.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Müsteriler musteriler = new Müsteriler();
            musteriler.ShowDialog();
                
        }

        private void KontrolPaneli_Load(object sender, EventArgs e)
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
