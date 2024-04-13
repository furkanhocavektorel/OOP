using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class KediEylemleri:Deneme
    {
        Kedi kedi;

        // value 5- iseed
        // reference 2- g
        public KediEylemleri(Kedi kedi2)
        {
            this.kedi = kedi2;
         
        }
        public void uyu2()
        {

        }

        public void kos()
        {
            throw new NotImplementedException();
        }

     

        public void yürü()
        {
            throw new NotImplementedException();
        }
    }
}
