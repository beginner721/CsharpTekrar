using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.UrunAdi = "Çikolata";
            urun1.Aciklama = "Beyaz Çikolatalı Gofret";
            urun1.Fiyat = 5;

            Urunler urun2 = new Urunler();
            urun2.UrunAdi = "Deterjan";
            urun2.Aciklama = "Renkli Kıyafetler İçin";
            urun2.Fiyat = 18;

            Urunler urun3 = new Urunler();
            urun3.UrunAdi = "Sıvı Sabun";
            urun3.Aciklama = "Lavanta Kokulu Sabun";
            urun3.Fiyat = 3;

            Urunler urun4 = new Urunler();
            urun4.UrunAdi = "Bira";
            urun4.Aciklama = "Alkol oranı %5";
            urun4.Fiyat = 10;

            Urunler[] urunler = new Urunler[] {urun1,urun2,urun3,urun4 };

            Console.WriteLine(urunler.Length);

            Console.WriteLine("FOR DONGUSU");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " / / " + urunler[i].Aciklama);
            }

            Console.WriteLine("******* WHİLE ******** ");

            int x = urunler.Length-1; // eksi bir çünkü LENGHT birden başlayarak sayar, 1 2 3 4 eleman gözükür, oysa 0 1 2 3 eleman olarak sayılır, taşması engellenir...
            while (x>=0)
            {
                Console.WriteLine(urunler[x].UrunAdi);
                x--;

            }

            Console.WriteLine("******foreach dongusu*****");
            foreach (var cc in urunler)
            {
                Console.WriteLine(cc.UrunAdi);
            }
        }
    }

    class Urunler // clas oluşturup özellik belirliyoruz
    {
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public int Fiyat { get; set; }
    }
}
