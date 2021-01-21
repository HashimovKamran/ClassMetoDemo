using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetoDemo
{
    class MusteriManager
    {
        public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri Eklendi\n\n" + "Id: " + musteri.Id + "\n" + "Ad: " + musteri.Ad + "\n" + "Soyad: " + musteri.Soyad + "\n" + "Doğum tarihi: " + musteri.DogumTarihi + "\n");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Çıkartıldı\n\n" + "Id: " + musteri.Id + "\n" + "Ad: " + musteri.Ad + "\n" + "Soyad: " + musteri.Soyad + "\n" + "Doğum tarihi: " + musteri.DogumTarihi + "\n");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Bilgileri\n\n" + "Id: " + musteri.Id + "\n" + "Ad: " + musteri.Ad + "\n" + "Soyad: " + musteri.Soyad + "\n" + "Doğum tarihi: " + musteri.DogumTarihi + "\n");
            }
        }
    }
}
