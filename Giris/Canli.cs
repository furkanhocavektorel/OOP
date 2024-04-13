using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class Canli
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Canli()
        {

        }

        public Canli(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }
    }
}
