using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumlerBurada.Classlar
{
   public class Album
    {
        public string albumAdi { get; set; }
        public string sanatciAdi { get; set; }
        public double fiyati { get; set; }

        public DateTime cikisYili { get; set; }

        public DateTime eklenmeTarihi { get; set; }
    }
}
