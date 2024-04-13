using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    internal class DB
    {
        public static List<Kopek> KopekDB;
        public static List<Kedi> KediDB;
        public static List<Boga> BogaDB;

        public DB()
        {
            KopekDB = new List<Kopek>();
            KediDB = new List<Kedi>();
            BogaDB = new List<Boga>();
        }
        
    }
}
