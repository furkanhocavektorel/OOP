using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class CanliEylemleri
    {
        // Polimorfizm (çok biçimlilik)
        // virtual , override
        public virtual void yürü()
        {
            Console.WriteLine("canli yürüyor");
        }
  

        public void kos()
        {
            Console.WriteLine("canli kosuyor");
        }
    }
}
