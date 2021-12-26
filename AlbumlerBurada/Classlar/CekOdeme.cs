using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumlerBurada.Classlar
{
    public class CekOdeme : Odeme
    {

        public string cekSahibininAdi { get; set; }

        public string bankaId { get; set; }

        public override void Odemek()
        {
            MessageBox.Show(cekSahibininAdi + "tarafından ücret ödenmiştir.");
        }

    }
}
