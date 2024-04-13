using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class KopekEylemleri:CanliEylemleri
    {
        Kopek kopek;
        public KopekEylemleri(Kopek kopek)
        {
           this.kopek = kopek;
        }
        public void saveDog()
        {
            Console.WriteLine("isim gir");
            Kopek ko = new Kopek();
            
        }

        public override void yürü()
        {
            Console.WriteLine(kopek.KuyrukVarMi+ kopek._name + "köpek yürüyor"); 
            base.yürü();
        }

    }
}
