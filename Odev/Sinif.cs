using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Sinif
    {
        public int Kapasite { get; set; }
        public string SubeKodu { get; set; }
        // bu kod bu sınıfa ait öğrencileri verir.
        public List<Ogrenci> OgrenciList { get; set; }
    }



}
