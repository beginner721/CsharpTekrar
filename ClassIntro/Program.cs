using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Baran";
            int yas = 24;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Baran Bey ";
            kurs1.IzlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Orhan Bey ";
            kurs2.IzlenmeOrani = 77;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Memduh Bey ";
            kurs3.IzlenmeOrani = 48;

            //Console.WriteLine(kurs1.KursAdi +" : "+ kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 }; //bunun içinde kurs tutacağız

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +": "+ kurs.Egitmen +" Görüntülenme: "+ kurs.IzlenmeOrani);
            }
        }

        class Kurs // clas oluşturduk ve istediğimiz tarzda verileri barındırıyoruz..
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
