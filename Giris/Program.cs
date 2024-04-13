namespace Giris
{
    internal class Program
    {
        /*
            en üstte 1 interface
            interface'i implement eden bir class
            Opsiyonel: bu class'ı da extend eden bir class daha
         
         */





        /* OOP 
         1_ encapsulation (kapsülleme) +
         2_ polimorfizm (çok biçimlilik) +
         3_ inheritence (kalıtım) +
         4_ soyutlama (interface & abstract class)
         */
       
        static void Main(string[] args)
        {
            DB d= new DB();
            string 
            #region giris
            // bir boga olusturup liste icine atıcam
            // 2 adet yöntem var şu ana kadar bildiginiz
            // 1_ main içinde oluşturmak.
            // 2_ entity icinde olusturmak.

            //KurtEylemleri kurtEylemleri = new KurtEylemleri();
            //kurtEylemleri.yürü();

            //KartBogasi asda = new KartBogasi();
            //asda.yöre = "asd";

            //Kopek k = new Kopek();

            //Console.WriteLine(asda.yöre);
            #endregion

            Kopek ko = new Kopek();
            ko._name = "it";
            ko.setGözRengi("mavi");
            ko.KuyrukVarMi = true;
            ko.BiyikUzunlugu = 22;
            DB.KopekDB.Add(ko);
           

            KopekEylemleri kopekEylemleri = new KopekEylemleri(ko);
            kopekEylemleri.yürü();

            Kedi kedi = new Kedi();
            kedi.Ad = "lena";
            kedi.Kilo = 3;
            kedi.Yas = 1;
            kedi.Cinsiyet = "disi";
            kedi.Cins = "ingiliz";
            KediEylemleri kediEylemleri = new KediEylemleri(kedi);
            kediEylemleri.yürü();
            Console.WriteLine(kedi.Yas);

            // 12:25
       
          

            DB.KediDB.Add(new Kedi());
            string 

        }



    }
}