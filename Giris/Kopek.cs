using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris
{
    // 1_ kapsülleme (encapsulation)
    // get set metotları
    internal class Kopek
    {
        #region propertys
        public string _name;
        private string _soyad;
        private int kilo;
        private int boy;
        private string _gözRengi;
        // field
        private string _tüyRengi;
        // property
        public string Cinsi { get; set; }
        public bool KuyrukVarMi { get; set; }
        public int BiyikUzunlugu { get; set; }
        #endregion
        

        //OVERLOADING
        // constructor
        // bir bos bir tam dolu olusturulur.
        public Kopek()
        {
            BiyikUzunlugu = 33/100;
        }
        public Kopek(string xaxasagfdsffg,int kilo,string tüyRengi)
        {
            this._name= xaxasagfdsffg;
            this.kilo = kilo;
            this._tüyRengi = tüyRengi;
            KuyrukVarMi = true;
            
        }
        public Kopek (int kilo, int boy,int biyik)
        {
            this.kilo = kilo;
            this.boy = boy;
            this.BiyikUzunlugu = biyik;
        }

        public Kopek(string xaxasagfdsffg, int kilo, string tüyRengi,string gözRengi)
        {
            this._name = xaxasagfdsffg;
            this.kilo = kilo;
            this._tüyRengi = tüyRengi;
            this._gözRengi = gözRengi;
        }

        public void setBoy(int boy)
        {
            this.boy = boy;
        }

        public void setTüyRengi(string tüyRengi) // degisken
        {
            _tüyRengi = tüyRengi;
           
        }
        public string getTüyRengi()
        {
            return _tüyRengi;
        }

        public void setGözRengi(string gözRengi)
        {
            _gözRengi = gözRengi;
        }
        public string getGözRengi()
        {
            return _gözRengi;
        }

       
        public int getBoy()
        {
            return boy;
        }

        public void setKilo(int kilo2)
        {
            kilo = kilo2;
        }
    
        public int getKilo()
        {
            return kilo;
        }

        // set Metodu
        public void setName(string kopekIsmi)
        {
            _name=kopekIsmi;
        }    
        // get Metodu
        public string getName()
        {
            return _name;
        }
    
        public void setSoyad(string soyad)
        {
            _soyad = "karabas";
        }
    
    
        public string getSoyad()
        {
            return _soyad;
        }
    
    
    
    }

}
