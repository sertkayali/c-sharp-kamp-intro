using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 25;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Furkan S";
            kurs1.IzlenmeOrani = 90;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Furkan Sert";
            kurs2.IzlenmeOrani = 95;
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
