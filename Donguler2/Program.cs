using System;

namespace Donguler2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Kurs1", "Kurs2", "Kurs3" };

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            } 


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
        }
    }
}
