using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AlbumlerBurada.Classlar
{
    public class Nakit: Odeme
    {
        public float TotalFiyat { get; set; }

        public override void Odemek()
        {
            MessageBox.Show("Ödeme için teşekkürler.");
        }

    }
}
