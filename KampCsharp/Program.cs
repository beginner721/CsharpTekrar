using System;

namespace KampCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself - kendini tekrarlama
            //kategoriEtiketi = Alias = Değer tutucu

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000; //tamsayı için int
            double faizOrani = 1.45; //ondalıklı için double
            bool sistemeGirisYapmisMi = true; //doğru veya yanlış ikili durumlar için kullanılır
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Hesap Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
