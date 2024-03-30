namespace Giris
{
    internal class Program
    {
        // public
        // internal
        // private
        // protected
        static void Main(string[] args)
        {
            #region 17.03
            // yazar : 5
            // yazmaz: 1
            //boga reu = new boga();
            //reu._ad = "reu simental";
            //reu._boy = 150;
            //reu._kilo = 600;
            //reu._boynuzuvarmi = false;
            //reu._rengi = "turuncu";
            //reu._ayaksayisi = 4;

            //reu.kos(3);

            //Boga karabas = new Boga();
            //karabas._ad = "karabas jersey";
            //karabas._kilo = 850;
            //karabas._boynuzuVarMi = true;
            //karabas._rengi = "siyah";
            //karabas._boy = 200;
            //karabas._cinsi = "simental";
            //karabas.kos(6);

            //Boga das = new Boga();
            //das._ad = "boga1";
            //das.boynuzla();

            //das.kos(3);


            //das.boynuzla();
            //karabas.Yürü();
            #endregion

            // ******** OOP ********
            // 1_ Kapsülleme            (encapsulation) 
            // 2_ kalıtım_miras alma    (inheritence)
            // 3_ çok biçimlilik        (polimorfizm)
            // 4_ soyutlama             (abstraction)

            //kopek1.KuyrukVarMi = true;

            //kopek1.setName("faruk");
            //Console.WriteLine(kopek1.getName());
            //Console.WriteLine(kopek1.Cinsi);
            //Console.WriteLine(kopek1.KuyrukVarMi);
            #region encapsulation 1.asama
            //Kopek k = new Kopek();
            //k.setName("altin");
            //k.setSoyad("karabas");
            //Console.WriteLine(k.getSoyad());
            //k.KuyrukVarMi = true;
            //Console.WriteLine(k.KuyrukVarMi);
            //k.Cinsi = "kangal";
            //Console.WriteLine(k.Cinsi);
            #endregion


            // 2.asama
            // constructor metot(yapıcı metot)

            Kopek kopek1 = new Kopek(55, 7, 6);
            Kopek k2 = new Kopek("sarı",50,"kahve");
            Console.WriteLine(kopek1.getKilo());
            Console.WriteLine(k2.getTüyRengi());
            



        }
    }
}