using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 75;
            product2.Aciklama = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat+" TL");
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("** BOŞLUK **");

            }

            Console.WriteLine("------- Metotlar -------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut","Sarı",15,20);
            sepetManager.Ekle2("Elma","Yeşil",11,20);
            sepetManager.Ekle2("Karpuz","Diyarbakır",19,20);

        }
    }
}
