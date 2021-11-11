using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Furkan");
            Console.WriteLine(isimler.Length);

            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);
            Console.WriteLine("Hello World!");
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
