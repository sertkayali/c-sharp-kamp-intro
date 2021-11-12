using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.NationalId = "11111111111";
            musteri1.Ad = "Furkan";
            musteri1.Soyad = "Sertkayalı";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.NationalId = "22222222222";
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Yılmaz";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
        }
    }
}
