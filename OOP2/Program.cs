using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456789";
            musteri1.Adi = "Furkan";
            musteri1.Soyadi = "Sertkayalı";
            musteri1.TcNo = "11111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "6789";
            musteri2.SirketAdi = "Dividesoft";
            musteri2.VergiNo = "12345";
            
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
        }
    }
}
