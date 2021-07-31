using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Product product) //normal parantez varsa orada metot çalışıyordur ...
        {
            Console.WriteLine("Sepete eklendi : "+ product.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdet)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
