using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    // entity
    // model
    internal class Boga
    {
        // field
        internal bool _boynuzuVarMi;
        internal int _boy;
        internal bool _kuyrukVarMi;
        internal int _kilo;
        internal int _ayakSayisi;
        internal string _ad;
        internal string _gözRengi;
        internal string _rengi;
        internal string _cinsi;
        internal bool _saglikliMi;
        internal int _disSayisi;

        // SOLID
        // -> O -> OPEN-CLOSED
        // -> S -> Single Responsebility
        public void kos(int ayak)
        {
            Console.WriteLine("sol ayagını kaldırdı");
            Thread.Sleep(2000);
            Console.WriteLine("sol ayağını indirdi");
            Console.WriteLine(_ad + " kosuyor");
            Console.WriteLine("sırtını kasıyor");
            Thread.Sleep(1000);
            Console.WriteLine("agzini kapatıyor");
            Console.WriteLine("zıplama için hazırlnaıyor baişado");
            Thread.Sleep(2000);
            Console.WriteLine("vicudunu esnetmeye basladi");
            Console.WriteLine(_ad + " ziplamayi");
            Console.WriteLine("sol ayakalrı yere değiyor");
            Thread.Sleep(1000);
            Console.WriteLine("esnemeyi bitirdi");
            Console.WriteLine(_ad + " zipliyor");



        }

        public void boynuzla()
        {
            Console.WriteLine("boynuzlamak için hazırlanıyor");
            Thread.Sleep(1000);
            Console.WriteLine("kafasını eğiyor");
            Console.WriteLine("ayağını yere sürtüyor");
            Thread.Sleep(2000);
            Console.WriteLine("kosmaya basliyor");
            Console.WriteLine("boynuz vuruyor");
            Console.WriteLine("sol boynuz vuruyor");
            Thread.Sleep(2000);
            Console.WriteLine("adam havalanıyor");
            Console.WriteLine("boga yerine döndü");
        }

        public void Yürü()
        {
            Console.WriteLine($"{_boy} boydaki , {_kilo} kiloundaki boga yürüyor");

        }

    }
}
