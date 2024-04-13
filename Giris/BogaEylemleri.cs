using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    // inheritence ise adı : extend etme
    // poli ise adı :        implement etme
    internal class BogaEylemleri:Deneme,IUyu
    {
        public void uyu()
        {
            throw new NotImplementedException();
        }

        public void yürü()
        {
            Console.WriteLine("boga yürüyor");
        }

      
        public void boynuzla()
        {
            Console.WriteLine("boga boynuzluyor");
        }

        public void kos()
        {
            throw new NotImplementedException();
            string
        }

       
    }
}
