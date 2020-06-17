using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Ihbar
    {
        public DateTime IhbarTarihi{ get; private set; }
        public string Sehir{ get; set; }
        public string Ilce { get; set; }
        public string AcikAdres { get; set; }
        public string IhbarAciklama { get; set; }

        public Ihbar()
        {
            IhbarTarihi = DateTime.Now;
        }
    }
}
