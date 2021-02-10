using System;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
         
            Musteri musteri1 = new Musteri();
            musteri1.Id = 151321;
            musteri1.Adi = "Sezin";
            musteri1.Soyadi = "Coşkunsu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 55665;
            musteri2.Adi = "Ceren";
            musteri2.Soyadi = "Başer";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine("******************");


            }

            Console.WriteLine("-----------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            Console.WriteLine("*****************");
            musteriManager.Ekle2(musteri1);
            musteriManager.Ekle2(musteri2);
            Console.WriteLine("*****************");
            musteriManager.Ekle3(musteri1);
            musteriManager.Ekle3(musteri2);


        }
    }
}


//Bir bankada müşteri takibi yapmak istiyorsunuz.

//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.