using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Ad = "Memduh";
            musteri1.Soyad = "Kurtbogan";
            musteri1.TcNo = "123456789768";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5435";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //müşteri classı hem gerçek hem tüzelin REFERANS NUMARASINI tutabiliyor, NEW görürseniz referans no. aklınıza gelsin

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            //aynı referans olduğu için musterimanager' a hem tüzel hem gerçek yollayabildik.....

        }
    }
}
