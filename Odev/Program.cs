namespace Odev
{
    internal class Program
    {

        static List<Okul> okulList = new List<Okul>();
        static void Main(string[] args)
        {
            okulOlustur();
            okulOlustur();


            foreach (Okul o in GetSchools())
            {
                Console.WriteLine(o.Ad);
                Console.WriteLine(o.SinifListesi.Count);
            }

            sinifOlustur();
            sinifOlustur();

            foreach (Okul o in GetSchools())
            {
                Console.WriteLine(o.Ad);
                Console.WriteLine(o.SinifListesi.Count);
                Console.WriteLine(o);
            }




        }
        public static void okulOlustur()
        {
            Console.WriteLine("okul adi giriniz");
            string okulAdi = Console.ReadLine();
            Okul okul = new Okul(okulAdi);
            okulList.Add(okul);
        }

        public static List<Okul> GetSchools ()
        {
            return okulList;
        }


        public static void sinifOlustur()
        {
            Console.WriteLine("sinif kapasitesi giriniz");
            int kapasite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sube kodunu giriniz");
            string subeKodu = Console.ReadLine();

            Sinif sınıf1 = new Sinif();
            sınıf1.Kapasite = kapasite;
            sınıf1.SubeKodu = subeKodu;

            Console.WriteLine("bu sinif hangi okula ait asagidan okul adi giriniz ?");
            int i = 1;
            foreach(Okul o in GetSchools())
            {
                Console.WriteLine(i+"_"+o.Ad);
                i++;
            }
            string okuladi = Console.ReadLine();
            //sorun : girilen okul adina göre bu okulu getiriyor olmam lazım.
            Okul okul = GetSchool(okuladi);
            okul.SinifListesi.Add(sınıf1);

        }


        public static Okul GetSchool(string ad)
        {
            foreach (Okul okul in GetSchools())
            {
                if (okul.Ad.Equals(ad))
                {
                    return okul;
            
                }

            }
            Dictionary<string, List<Okul>> dic = new Dictionary<string, List<Okul>>();
            Dictionary<string, Sinif > sinifListesi = new Dictionary<string, Sinif>();

            return null;

        }


    }
}