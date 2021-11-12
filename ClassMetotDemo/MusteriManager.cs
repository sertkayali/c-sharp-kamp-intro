using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi : " + musteri.Ad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi : " + musteri.Ad);
        }
    }
}
