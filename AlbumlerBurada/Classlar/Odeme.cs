using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumlerBurada.Classlar
{
    public abstract class Odeme
    {
        public virtual float tutar { get; set; }

        public virtual void Odemek()
        {
            MessageBox.Show("Ödeme işleminiz başarıyla gerçekleşmiştir.");
        }

        
    }
}
