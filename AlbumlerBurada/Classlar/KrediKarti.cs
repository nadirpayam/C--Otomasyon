using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumlerBurada.Classlar
{
    public class KrediKarti : Odeme
    {
        public override float tutar { get => base.tutar; set => base.tutar = value; }
        
        public string kartSahibi { get; set; }
        public string kartNumarasi { get; set; }
        public string kartTipi { get; set; }

        public DateTime sonKullanmaTarihi { get; set; }

        public override void Odemek()
        {
            MessageBox.Show("Kredi kartınızdan ödeme işlemi alınmıştır.");
        }


    }
}
