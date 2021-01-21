using System;

namespace ClassMetoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.Ad = "Engin";
            musteri.Soyad = "Demirog";
            musteri.DogumTarihi = 99999999;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Kamran";
            musteri2.Soyad = "Hashimov";
            musteri2.DogumTarihi = 99999999;

            Musteri[] musteriler = new Musteri[] { musteri, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("==========Müşteri Ekleme==========");

            musteriManager.Ekleme(musteri);
            musteriManager.Ekleme(musteri2);

            Console.WriteLine("==========Müşteri Silme==========");

            musteriManager.Silme(musteri);
            musteriManager.Silme(musteri2);

            Console.WriteLine("==========Müşteri Listeleme==========");

            musteriManager.Listele(musteriler);
        }
    }
}
