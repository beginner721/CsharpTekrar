using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Orhan", "Rezan", "Memduh", "Baran" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler[4] = "ilker"; bu eklenemez stringler oluşturduğunuz an sınırları belirlenir o yüzden koleksiyon kullanacağız

            List<string> isimler2 = new List<string> { "Orhan", "Rezan", "Memduh", "Baran" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            Console.WriteLine("*********** EKLEME **********");
            isimler2.Add("Recep");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
