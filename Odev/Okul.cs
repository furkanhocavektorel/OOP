using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Okul
    {
        public string Ad { get; set; }
        public List<Ogrenci> OgrenciListesi { get; set; }
        public List<Ogretmen> OgretmenListesi{ get; set; }
        public List<Sinif> SinifListesi { get; set; }

        public Okul(string ad)
        {
            this.Ad = ad;
            OgrenciListesi = new List<Ogrenci>();
            Dictionary<string, Sinif> sinifListesi = new Dictionary<string, Sinif>();
            OgretmenListesi = new List<Ogretmen>();
        }

    }
}
