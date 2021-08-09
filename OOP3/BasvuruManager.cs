using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService) //hangi krediyi seçerse o hesaplama yapılacak tek metotta 3 kredi başvurusu alabiliriz
        {
            //Başvuran bilgileri değerlendirme
            //
            //method injection, hangisi olacağını enjekte ediyoruz
            krediManager.Hesapla(); //hesapla bağımsız hale geldi, hangi kredi seçilirse onun içinde tanımlı olan hesaplama kısmı çalışır !
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
